Imports System.Data.OleDb

Public Class Desempeñar
    Dim codigoEmp As Integer = Principal.codigoEmpeñoPrincipal
    Dim DeudaTotal As Integer = 0
    Dim TotalConDescuento As Integer = 0
    Dim cedulaCliente As Double
    Private Sub Desempeñar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.retiro' Puede moverla o quitarla según sea necesario.
        Me.RetiroTableAdapter.Fill(Me.BDMIDataSet.retiro)
        TextBoxDescuento.Text = 0
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim i As Integer = 0
        Dim consulta As String
        Dim lista As Byte

        Dim fechaIni As Date

        consulta = "SELECT * FROM empeño WHERE codigo = " & Principal.codigoEmpeñoPrincipal
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla")
        lista = registro.Tables("TuTabla").Rows.Count
        If lista <> 0 Then
            DeudaTotal = registro.Tables("TuTabla").Rows(0).Item("valor_total")
            cedulaCliente = registro.Tables("TuTabla").Rows(0).Item("cedula_cliente")
        End If
        consulta = "SELECT descripcion FROM producto WHERE codigo_empeño =" & Principal.codigoEmpeñoPrincipal
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla")
        lista = registro.Tables("TuTabla").Rows.Count
        If lista <> 0 Then
            DataGridViewP.DataSource = registro.Tables("TuTabla")

        End If
        LabelDeuda.Text = DeudaTotal.ToString("C")
        TotalConDescuento = DeudaTotal - TextBoxDescuento.Text
        LabelTotal.Text = TotalConDescuento.ToString("C")
        LabelCed.Text = cedulaCliente
        LabelCod.Text = Principal.codigoEmpeñoPrincipal
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim result = MessageBox.Show("Esta Seguro Que Desea Desempeñar el o los articulos?", "Confirme.", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
            Dim valorVenta As Double = 0
            Try
                CONEXION.Open()
                Dim CONSULTA As String = "UPDATE empeño SET estado_producto = 'retirado', fecha_salida = '" & Now.Date.ToShortDateString & "', valor_total=" & TotalConDescuento & ", interes=0 WHERE codigo = " & Principal.codigoEmpeñoPrincipal & ""
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                Dim DR As OleDbDataReader = COMANDO.ExecuteReader
                DR.Close()
                CONEXION.Close()
                DetallesEmpeño.ProductoTableAdapter.RETIRAR_PRODUCTO_EMP("retirado", Principal.codigoEmpeñoPrincipal)
                RetiroTableAdapter.AGREGAR_RETIRO(Now.ToShortDateString, Now.ToString("hh:mm:ss"), cedulaCliente, Principal.codigoEmpeñoPrincipal, TotalConDescuento)
                MsgBox("Retiro exitoso!")
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If (PictureBox1.Tag = 0) Then
            PictureBox1.Tag = 1
            Panel1.Location = New Point(180, 1)
            PanelProd.Visible = True
        Else
            PictureBox1.Tag = 0
            Panel1.Location = New Point(101, 1)
            PanelProd.Visible = False
        End If
    End Sub

    Private Sub TextBoxDescuento_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDescuento.TextChanged
        TotalConDescuento = DeudaTotal - Val(TextBoxDescuento.Text)
        LabelTotal.Text = TotalConDescuento.ToString("C")
    End Sub

    Private Sub RetiroBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RetiroBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDMIDataSet)

    End Sub
End Class