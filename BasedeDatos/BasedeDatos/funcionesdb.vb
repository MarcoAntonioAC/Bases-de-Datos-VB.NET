Module Funcionesdb

    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BasedeDatos1.accdb;Persist Security Info=False")
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader

    Public Sub conexion()
        Try
            conn.Open()
            MsgBox("¡Conexion Exitosa!")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub consultar(ByRef identificacion As String)
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text

        If identificacion <> "" Then
            cmd.CommandText = "SELECT NOMBRES, APELLIDOS, CORREO, DIRECCION FROM TABLA1 WHERE ID=" + identificacion
        Else
            cmd.CommandText = "SELECT NOMBRES, APELLIDOS, CORREO, DIRECCION FROM TABLA1 "
        End If

        Try
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                While dr.Read()
                    MsgBox("Registro: " + dr(0).ToString + " " + dr(1).ToString + " " + dr(2).ToString + " " + dr(3).ToString)
                End While
            Else
                MsgBox("No Existe el Registro Solicitado!")
            End If

            dr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Module
