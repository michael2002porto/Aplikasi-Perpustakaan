<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LinkLabelLogin = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtRePassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LinkLabelLogin
        '
        Me.LinkLabelLogin.AutoSize = True
        Me.LinkLabelLogin.Location = New System.Drawing.Point(652, 431)
        Me.LinkLabelLogin.Name = "LinkLabelLogin"
        Me.LinkLabelLogin.Size = New System.Drawing.Size(73, 32)
        Me.LinkLabelLogin.TabIndex = 13
        Me.LinkLabelLogin.TabStop = True
        Me.LinkLabelLogin.Text = "Login"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(502, 389)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 32)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Sudah punya akun?"
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Location = New System.Drawing.Point(325, 316)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(150, 46)
        Me.ButtonRegister.TabIndex = 11
        Me.ButtonRegister.Text = "Register"
        Me.ButtonRegister.UseVisualStyleBackColor = True
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(283, 128)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(437, 39)
        Me.TxtPassword.TabIndex = 10
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(283, 49)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(437, 39)
        Me.TxtUsername.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 32)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Username"
        '
        'TxtRePassword
        '
        Me.TxtRePassword.Location = New System.Drawing.Point(283, 216)
        Me.TxtRePassword.Name = "TxtRePassword"
        Me.TxtRePassword.Size = New System.Drawing.Size(437, 39)
        Me.TxtRePassword.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 32)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Re-Password"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 544)
        Me.Controls.Add(Me.TxtRePassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LinkLabelLogin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Register"
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabelLogin As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtRePassword As TextBox
    Friend WithEvents Label4 As Label
End Class
