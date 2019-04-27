Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports VBDB
Public Class AddNewStudent

    Private studentidInteger As Integer = 0
    Property StudentId() As Integer
        Get
            Return studentidInteger
        End Get
        Set(ByVal value As Integer)
            studentidInteger = value
        End Set
    End Property
    Private IsUpdateboolean As Boolean = False
    Property IsUpdate() As Boolean
        Get
            Return IsUpdateboolean
        End Get
        Set(ByVal value As Boolean)
            IsUpdateboolean = value
        End Set
    End Property

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub SaveButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton1.Click
        If IsValiDate() Then
            Try
                If IsUpdate Then
                    UpdateRecord()
                    MsgBox("Student Update SuccesFull ", MsgBoxStyle.Information, "Student")
                    Me.Close()
                Else
                    SaveStudent()
                    MsgBox("Student Add SuccesFull ", MsgBoxStyle.Information, "Student")
                    Me.Close()
                End If
              

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Sub SaveStudent()
        Dim connString As String = ConfigurationManager.ConnectionStrings("VBDV").ConnectionString
        Using conn As New SqlConnection(connString)

            'Using cmd As New SqlCommand("INSERT INTO Students (FirstName,LastName,Email,Mobile,Phone) VALUES (@FirstName,@LastName,@Email,@Mobile, @Phone)", conn)
            Using cmd As New SqlCommand("usp_insertStudentrecord", conn)
                cmd.CommandType = CommandType.StoredProcedure
                conn.Open()
                cmd.Parameters.AddWithValue("@FirstName", FirstNameTextBox1.Text)
                cmd.Parameters.AddWithValue("@LastName", LastNameTextBox2.Text)
                cmd.Parameters.AddWithValue("@Email", EmailTextBox3.Text)
                cmd.Parameters.AddWithValue("@Mobile", MobileTextBox4.Text)
                cmd.Parameters.AddWithValue("@Phone", PhoneTextBox5.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub AddNewStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsUpdate Then
            LoadDataToMApeControle()
            SaveButton1.Text = "Update"
        End If
    End Sub

    Private Sub LoadDataToMApeControle()
        Dim dtStudent As DataTable = GetStudentDetals()
        Dim row As DataRow = dtStudent.Rows(0)
        FirstNameTextBox1.Text = row(0)
        LastNameTextBox2.Text = row("LastName")
        EmailTextBox3.Text = row("EMail")
        MobileTextBox4.Text = row("Mobile")
        PhoneTextBox5.Text = row("Phone")
    End Sub

    Function GetStudentDetals() As DataTable
        Dim dtStudent As New DataTable
        Dim connString As String = ConfigurationManager.ConnectionStrings("VBDV").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("ups_GetStudentDetailsById", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@Studentid", StudentId)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader
                dtStudent.Load(reader)
            End Using
        End Using
        Return dtStudent
    End Function

    Private Function IsValiDate() As Boolean
        If FirstNameTextBox1.Text = String.Empty Then
            MsgBox("Enter First Name", MsgBoxStyle.Information, "Error")
            FirstNameTextBox1.Focus()
            Return False
        End If
        'If LastNameTextBox2.Text = String.Empty Then
        '    MsgBox("Enter Last Name", MsgBoxStyle.Information, "Error")
        '    LastNameTextBox2.Focus()
        '    Return False
        'End If

        If EmailTextBox3.Text = String.Empty Then
            MsgBox("Enter Email", MsgBoxStyle.Information, "Error")
            EmailTextBox3.Focus()
            Return False

        Else
            If IsUpdate = False Then
                If IsEmail() Then
                    MsgBox("Email Exist", MsgBoxStyle.Information, "Error")
                    ' EmailTextBox3.Clear()
                    EmailTextBox3.Focus()
                    Return False
                End If
            End If
        End If
        'If MobileTextBox4.Text = String.Empty Then
        '    MsgBox("Enter Mobile", MsgBoxStyle.Information, "Error")
        '    MobileTextBox4.Focus()
        '    Return False
        'End If

        If PhoneTextBox5.Text = String.Empty Then
            MsgBox("Enter Phone Number", MsgBoxStyle.Information, "Error")
            PhoneTextBox5.Focus()
            Return False
        Else
            Return True
        End If
    End Function

    Private Function IsEmail() As Boolean
        Dim connString As String = ConfigurationManager.ConnectionStrings("VBDV").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("usp_EmailExists", conn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@IsEamil", EmailTextBox3.Text)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                reader.Read()
                Return reader("Email")
            End Using
        End Using
        Return True
    End Function

    Private Sub UpdateRecord()
        Dim connString As String = ConfigurationManager.ConnectionStrings("VBDV").ConnectionString
        Using conn As New SqlConnection(connString)
            Using cmd As New SqlCommand("usp_UpdateStudentrecord", conn)
                cmd.CommandType = CommandType.StoredProcedure
                conn.Open()
                cmd.Parameters.AddWithValue("@Sid", StudentId)
                cmd.Parameters.AddWithValue("@FirstName", FirstNameTextBox1.Text)
                cmd.Parameters.AddWithValue("@LastName", LastNameTextBox2.Text)
                cmd.Parameters.AddWithValue("@Email", EmailTextBox3.Text)
                cmd.Parameters.AddWithValue("@Mobile", MobileTextBox4.Text)
                cmd.Parameters.AddWithValue("@Phone", PhoneTextBox5.Text)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class