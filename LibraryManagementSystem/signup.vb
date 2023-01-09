Imports System.Data.SqlClient
Public Class signup
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim con As SqlConnection = New SqlConnection()
        Dim cmd As SqlCommand

        con.ConnectionString = My.Settings.databaseConnectionString

        Try
            con.Open()
            Dim stmt As String = "INSERT INTO [USER] VALUES(@id,@name,@password,@email,@role)"
            cmd = New SqlCommand(stmt, con)
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = Integer.Parse(txtStudentId.Text)
            cmd.Parameters.Add("@name", SqlDbType.Text).Value = txtName.Text
            cmd.Parameters.Add("@password", SqlDbType.Text).Value = txtPassword.Text
            cmd.Parameters.Add("@email", SqlDbType.Text).Value = txtEmail.Text
            cmd.Parameters.Add("@role", SqlDbType.Text).Value = "student"
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Sucessfully registered")
        Catch ex As Exception
            MessageBox.Show("Student ID already exists")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEmail.Clear()
        txtName.Clear()
        txtPassword.Clear()
        txtStudentId.Clear()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class
