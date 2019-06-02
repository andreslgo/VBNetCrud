Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Conexion

    Public conexion As SqlConnection = New SqlConnection("Data Source=localhost\sqlexpress;Initial Catalog=estudiantes;Integrated Security=True")

    Public Sub Conectar()
        Try
            conexion.Open()
            Return conexion
        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub

End Class
