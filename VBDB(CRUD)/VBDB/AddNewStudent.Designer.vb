<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewStudent
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LastNameTextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.EmailTextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MobileTextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PhoneTextBox5 = New System.Windows.Forms.TextBox()
        Me.SaveButton1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(65, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'FirstNameTextBox1
        '
        Me.FirstNameTextBox1.Location = New System.Drawing.Point(173, 74)
        Me.FirstNameTextBox1.MaxLength = 40
        Me.FirstNameTextBox1.Name = "FirstNameTextBox1"
        Me.FirstNameTextBox1.Size = New System.Drawing.Size(201, 22)
        Me.FirstNameTextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(65, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Last Name"
        '
        'LastNameTextBox2
        '
        Me.LastNameTextBox2.Location = New System.Drawing.Point(173, 113)
        Me.LastNameTextBox2.MaxLength = 40
        Me.LastNameTextBox2.Name = "LastNameTextBox2"
        Me.LastNameTextBox2.Size = New System.Drawing.Size(201, 22)
        Me.LastNameTextBox2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(65, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Email"
        '
        'EmailTextBox3
        '
        Me.EmailTextBox3.Location = New System.Drawing.Point(173, 152)
        Me.EmailTextBox3.MaxLength = 40
        Me.EmailTextBox3.Name = "EmailTextBox3"
        Me.EmailTextBox3.Size = New System.Drawing.Size(201, 22)
        Me.EmailTextBox3.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Mobile"
        '
        'MobileTextBox4
        '
        Me.MobileTextBox4.Location = New System.Drawing.Point(173, 191)
        Me.MobileTextBox4.MaxLength = 40
        Me.MobileTextBox4.Name = "MobileTextBox4"
        Me.MobileTextBox4.Size = New System.Drawing.Size(201, 22)
        Me.MobileTextBox4.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(65, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Phone"
        '
        'PhoneTextBox5
        '
        Me.PhoneTextBox5.Location = New System.Drawing.Point(173, 230)
        Me.PhoneTextBox5.MaxLength = 40
        Me.PhoneTextBox5.Name = "PhoneTextBox5"
        Me.PhoneTextBox5.Size = New System.Drawing.Size(201, 22)
        Me.PhoneTextBox5.TabIndex = 5
        '
        'SaveButton1
        '
        Me.SaveButton1.Location = New System.Drawing.Point(171, 294)
        Me.SaveButton1.Name = "SaveButton1"
        Me.SaveButton1.Size = New System.Drawing.Size(95, 37)
        Me.SaveButton1.TabIndex = 6
        Me.SaveButton1.Text = "Save"
        Me.SaveButton1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(279, 294)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 37)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AddNewStudent
        '
        Me.AcceptButton = Me.SaveButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(439, 423)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.SaveButton1)
        Me.Controls.Add(Me.PhoneTextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MobileTextBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.EmailTextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LastNameTextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FirstNameTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddNewStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddNewStudent"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FirstNameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LastNameTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents EmailTextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MobileTextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PhoneTextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents SaveButton1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
