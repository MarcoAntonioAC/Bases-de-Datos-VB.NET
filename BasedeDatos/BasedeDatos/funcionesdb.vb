Module funcionesdb

    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BasedeDatos1.accdb;Persist Security Info=False")

    Public Sub conexion()
        Try
            conn.Open()
            MsgBox("¡Conexion Exitosa!")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
