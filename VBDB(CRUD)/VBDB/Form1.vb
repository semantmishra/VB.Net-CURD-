Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
    Dim student As New DataTable


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetStudentData()
    End Sub
    Public Function GetStudentList() As DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("VBDV").ConnectionString

        Using conn As New SqlConnection(connString)
            Using cmm As New SqlCommand("uso_StudentGetAllStudentRecords", conn)
                cmm.CommandType = CommandType.StoredProcedure
                conn.Open()
                Using redar As SqlDataReader = cmm.ExecuteReader()
                    student.Load(redar)
                End Using
            End Using
        End Using
        Return student
    End Function
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        ShowStudentInfoShowScreen(0, False)
        GetStudentData()
    End Sub
    Sub GetStudentData()
        If student.Rows.Count > 0 Then
            student.Clear()
        End If
        DataGridView1.DataSource = GetStudentList()
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        ShowUpdateForm()
        
    End Sub

    Private Sub ShowStudentInfoShowScreen(ByVal row As Integer, ByVal Update As Boolean)
        Dim studentSrceen As New AddNewStudent
        studentSrceen.StudentId = row
        studentSrceen.IsUpdate = Update
        studentSrceen.ShowDialog()
    End Sub


    Private Sub DataGridView1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseDown

        If e.Button = MouseButtons.Right Then
            Dim row As Integer = DataGridView1.HitTest(e.X, e.Y).RowIndex
            DataGridView1.Rows(row).Selected = True
            ContextMenuStrip1.Show(DataGridView1, e.X, e.Y)
        End If
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Dim m As DialogResult = MsgBox("Do You Really Want to Delete This Record ", MsgBoxStyle.YesNo, "Deleting Record")
        If m = DialogResult.Yes Then
            Dim UpdatRow As Integer = DataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected)
            Dim cell As Integer = DataGridView1.Rows(UpdatRow).Cells("StudentId").Value
            DeleteRecordById(cell)
            MsgBox("Record Deleted ", MsgBoxStyle.Information, "Deleting Record")
            GetStudentData()
        End If
    End Sub

    Private Sub DeleteRecordById(ByVal StudentId As Integer)
        Dim connString As String = ConfigurationManager.ConnectionStrings("VBDV").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmm As New SqlCommand("usp_DeleteRecordByStudentId", conn)
                cmm.Parameters.AddWithValue("@StudentId", StudentId)
                cmm.CommandType = CommandType.StoredProcedure
                conn.Open()
                cmm.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub AddStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStudentToolStripMenuItem.Click
        ShowStudentInfoShowScreen(0, False)
        GetStudentData()
    End Sub

    Private Sub ShowUpdateForm()
        Dim UpdatRow As Integer = DataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected)
        Dim cell As Integer = DataGridView1.Rows(UpdatRow).Cells("StudentId").Value
        ShowStudentInfoShowScreen(cell, True)
        GetStudentData()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        ShowUpdateForm()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Application.Exit()
    End Sub
End Class
