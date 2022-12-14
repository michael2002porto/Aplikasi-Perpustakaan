Public Class Login
    Public Shared Perpustakaan As Perpustakaan
    Public Shared Users As Users

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Perpustakaan = New Perpustakaan()
        Users = New Users()
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        Try
            Dim plainUsername As String = TxtUsername.Text
            Dim plainPassword As String = TxtPassword.Text

            If plainUsername.Length < 1 Then
                TxtUsername.Select()
                Throw New System.Exception("Please insert username")
            End If

            If plainPassword.Length < 1 Then
                TxtPassword.Select()
                Throw New System.Exception("Please insert password")
            End If

            'Dim Encrypted As String = Users.EncryptData(plainPassword)
            'MessageBox.Show(Encrypted)
            'Dim AuthStatus As Boolean = Users.CheckAuth(plainUsername, plainPassword)
            'If AuthStatus Then
            '    Perpustakaan.Show()
            'Else
            '    MessageBox.Show("Wrong Password")
            'End If

            Dim data_user As List(Of String) = Users.CheckAuthDatabase(plainUsername, plainPassword)

            If data_user.Count > 0 Then
                Users.usernameProperty = data_user(1)
                Perpustakaan.Show()
                Me.Hide()
            Else
                MessageBox.Show("Wrong Password")
            End If
        Catch ex As Exception
            MsgBox(ex.Message.ToString())
        End Try
    End Sub

    Private Sub LinkLabelRegister_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelRegister.LinkClicked
        Dim formRegister = New Register()
        formRegister.Show()
        Me.Hide()
    End Sub
End Class