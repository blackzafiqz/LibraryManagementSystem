Imports System.Data.SqlClient

Public Class Login
    Public Sub New()
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("ODg4NDQzQDMyMzAyZTM0MmUzMGh1V1I2OUNxc245MXczbjBidnQwbXcvUUtWVDBVZGJCajJ3MjUybWl1Wm89")
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim con As SqlConnection = New SqlConnection()
        Dim cmd As SqlCommand

        con.ConnectionString = My.Settings.databaseConnectionString

        Try
            con.Open()
            Dim stmt As String = "SELECT * FROM [USER] WHERE id=@id AND password=@password"
            cmd = New SqlCommand(stmt, con)
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Integer.Parse(txtUsername.Text)
            cmd.Parameters.Add("@password", SqlDbType.Text).Value = txtPassword.Text
            Dim res = cmd.ExecuteReader()
            If res.HasRows Then
                res.GetString("role")
            Else
                Throw New Exception()
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Id or password is incorrect")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPassword.Clear()
        txtUsername.Clear()
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        signup.Show()
        Me.Close()
    End Sub
End Class