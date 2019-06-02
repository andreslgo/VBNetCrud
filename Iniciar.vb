Imports System.Data
Imports System.Data.SqlClient

Public Class Iniciar
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim conexion As SqlConnection = New SqlConnection("Data Source=localhost\sqlexpress;Initial Catalog=estudiantes;Integrated Security=True")
        Dim command As New SqlCommand("SELECT id FROM Usuarios WHERE usuario = @usuario AND contrasena = @password", conexion)

        command.Parameters.Add("@usuario", SqlDbType.Char).Value = usuario.Text
        command.Parameters.Add("@password", SqlDbType.Char).Value = contrasena.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count <= 0 Then
            MessageBox.Show("Usuario y/o Contraseña incorrecta!")
        Else
            Dim principal As New Principal()
            principal.Show()
            Me.Hide()
        End If


    End Sub
End Class
