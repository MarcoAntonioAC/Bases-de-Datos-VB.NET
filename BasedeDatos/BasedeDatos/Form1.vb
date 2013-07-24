Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        conexion()
        llenaGrid()
    End Sub

    Private Sub llenaGrid()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strSql As String = "SELECT ID, NOMBRES, APELLIDOS, CORREO, DIRECCION FROM TABLA1"
        Dim adp As New OleDb.OleDbDataAdapter(strSql, conn)

        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))

        Me.DataGridView1.DataSource = ds.Tables("tabla")

        Me.DataGridView1.Columns(0).HeaderText = "COD. CLIENTE"

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim id As String
        id = TextBox1.Text
        consultar(id)
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
