Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
        'llenaGrid()
    End Sub

    'Private Sub llenaGrid()
    '    Dim ds As New DataSet
    '    Dim dt As New DataTable
    '    Dim strSql As String = "SELECT ID, NOMBRES, APELLIDOS, CORREO, DIRECCION FROM TABLA1"
    '    Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)

    '    ds.Tables.Add("tabla")
    '    adp.Fill(ds.Tables("tabla"))

    '    Me.DataGridView1.DataSource = ds.Tables("tabla")

    '    Me.DataGridView1.Columns(0).HeaderText = "COD. CLIENTE"

    'End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Dim id As String
    '    id = TextBox1.Text
    '    consultar(id)
    'End Sub

    'Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    'End Sub

    'Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    Private Sub btnInsertar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsertar.Click
        If (Me.txtIdentificacion.Text = "") Then

            MsgBox("El campo ID CLIENTE no puede estar vacio", MsgBoxStyle.Exclamation, "Atención")
            Me.txtIdentificacion.Select()
        Else

            Dim identificacion As Integer
            Dim nombres As String = ""
            Dim apellidos As String = ""
            Dim correo As String = ""
            Dim direccion As String = ""

            identificacion = Me.txtIdentificacion.Text
            nombres = Me.txtNombres.Text
            apellidos = Me.txtApellidos.Text
            correo = Me.txtCorreo.Text
            direccion = Me.txtDireccion.Text

            cmd.CommandType = CommandType.Text
            cmd.Connection = conn

            sql = "INSERT INTO TABLA1 (ID, NOMBRES, APELLIDOS, CORREO, DIRECCION) "
            sql += "VALUES (" & identificacion & ", '" & nombres & "','" & apellidos & "', '" & correo & "', "
            sql += "'" & direccion & "')"

            'MsgBox("Registro guaradado en Base de Datos", MsgBoxStyle.Information)

            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro Ingresado Correctamente!", MsgBoxStyle.Information)
            Catch ex As Exception
                If ex.ToString.Contains("") Then
                    MsgBox("El Registro Existe Actualmente", MsgBoxStyle.Critical)
                Else
                    MsgBox(ex.ToString)
                End If
            End Try

        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
