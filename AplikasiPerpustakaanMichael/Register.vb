Imports Org.BouncyCastle.Utilities

Public Class Register
    Public Shared Users As Users

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Users = New Users()
    End Sub

    Private Sub LinkLabelLogin_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelLogin.LinkClicked
        Dim formLogin = New Login()
        formLogin.Show()
        Me.Close()
    End Sub

    Private Sub ButtonRegister_Click(sender As Object, e As EventArgs) Handles ButtonRegister.Click
        Try
            If TxtUsername.Text.Length > 0 And TxtPassword.Text.Length > 0 And TxtRePassword.Text.Length > 0 Then
                If Not String.Equals(TxtPassword.Text, TxtRePassword.Text) Then
                    Throw New System.Exception("Konfirmasi Re-Password tidak cocok")
                End If

                If Users.CheckUserDatabase(TxtUsername.Text).Count > 0 Then
                    Throw New System.Exception("Username sudah terdaftar")
                End If

                'Login.Users.AddDataUsers (TxtUserName. Text, TxtPassword.Text)
                Login.Users.AddUsersDatabase(TxtUsername.Text, TxtPassword.Text)

                MessageBox.Show("Berhasil menambahkan user")

                Dim formLogin = New Login()
                formLogin.Show()
                Me.Close()
            Else
                MessageBox.Show("Lengkapi Data")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub
End Class