Public Class DetallesEmpeñoRemate
    Private Sub DetallesEmpeñoRemate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BDMIDataSet.clientes)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.BDMIDataSet.producto)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.empeño' Puede moverla o quitarla según sea necesario.
        Me.EmpeñoTableAdapter.Fill(Me.BDMIDataSet.empeño)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.abono' Puede moverla o quitarla según sea necesario.
        Me.AbonoTableAdapter.Fill(Me.BDMIDataSet.abono)
        LabelAbonos.Text = "TOTAL ABONOS: $" & Me.AbonoTableAdapter.TOTALABONADO(Administrador.codigoEmpeñoAdministrador) & " COP"
        Try
            LabelUltimoAbono.Text = Me.AbonoTableAdapter.ULTIMOABONO(Administrador.codigoEmpeñoAdministrador)
        Catch ex As Exception
            LabelUltimoAbono.Text = "Ninguno..."
        End Try

        LabelProductos.Text = "# PRODUCTOS ASOCIADOS: " & Me.ProductoTableAdapter.CONTAR(Administrador.codigoEmpeñoAdministrador)
        Me.AbonoTableAdapter.DETALLES_COD_EMP(Me.BDMIDataSet.abono, Administrador.codigoEmpeñoAdministrador)
        Me.ProductoTableAdapter.DETALLES_COD_EMP(Me.BDMIDataSet.producto, Administrador.codigoEmpeñoAdministrador)
        'LabelNombreCliente.Text = Me.ClientesTableAdapter.NOMBRE_CLIENTE(Me.BDMIDataSet.clientes, "1063303465")
        Me.ClientesTableAdapter.BUSCAR_CLIENTE(BDMIDataSet.clientes, Administrador.cedulaEmpeñoAdministrador)
        ' LabelNombreCliente.Text = "INFORMACION SOBRE: " & ClientesDataGridView.Item(5, 0).Value & " " & ClientesDataGridView.Item(6, 0).Value
        buscarInfoCliente(Administrador.cedulaEmpeñoAdministrador)
        buscarInfoEmpeño(Administrador.codigoEmpeñoAdministrador)
        'ValorSiEmpeñoRetirado(Administrador.codigoEmpeñoAdministrador)
    End Sub
    Sub buscarInfoCliente(ByVal cedula As Double)
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim i As Integer = 0
        Dim consulta As String
        Dim lista As Byte

        Dim fechaIni As Date

        consulta = "SELECT * FROM clientes WHERE cedula_cliente=" & cedula
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla")
        lista = registro.Tables("TuTabla").Rows.Count
        If lista <> 0 Then

            LabelNombreCli.Text = registro.Tables("TuTabla").Rows(0).Item("nombre")
            LabelApellidoCliente.Text = registro.Tables("TuTabla").Rows(0).Item("apellidos")
            LabelCedulaCliente.Text = cedula

        End If
    End Sub
    Sub buscarInfoEmpeño(ByVal codigo As Double)
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim i As Integer = 0
        Dim consulta As String
        Dim lista As Byte

        Dim fechaIni As Date

        consulta = "SELECT * FROM empeño WHERE codigo=" & codigo
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla")
        lista = registro.Tables("TuTabla").Rows.Count
        If lista <> 0 Then

            LabelDeudaIntereses.Text = registro.Tables("TuTabla").Rows(0).Item("interes")
            Dim DeudaTotal As Double = registro.Tables("TuTabla").Rows(0).Item("valor_total")
            LabelDeudaTotalCliente.Text = DeudaTotal.ToString("C")
            LabelEstadoEmpeño.Text = registro.Tables("TuTabla").Rows(0).Item("estado_producto")
            LabelMesesPagos.Text = registro.Tables("TuTabla").Rows(0).Item("mesesPagados")
            Dim mesespagos As Integer = registro.Tables("TuTabla").Rows(0).Item("mesesPagados")
            Dim dias As Integer = 0
            Dim meses As Integer = 0
            dias = DateDiff(DateInterval.Day, registro.Tables("TuTabla").Rows(0).Item("fecha_llegada"), Now)
            meses = DateDiff(DateInterval.Month, registro.Tables("TuTabla").Rows(0).Item("fecha_llegada"), Now)
            Dim residuo As Integer = dias Mod 30
            If (dias Mod 30 = 0) Then

            Else
                meses += 1
            End If
            'modifique esto. tenia una division en ves de  resta'
            If (dias <= 30) Then
                meses = 1
            End If
            Dim mesesnopagos As Integer = meses - mesespagos
            LabelMesesNoPagos.Text = CInt(mesesnopagos)

        End If
    End Sub
    Private Sub AbonoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AbonoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDMIDataSet)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PanelRematesAbonos.Visible = False
        PanelRematesProductos.Visible = False
        PanelRematesDetalles.Visible = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PanelRematesProductos.Visible = False
        PanelRematesDetalles.Visible = False
        PanelRematesAbonos.Visible = True

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PanelRematesDetalles.Visible = False
        PanelRematesAbonos.Visible = False
        PanelRematesProductos.Visible = True

    End Sub
End Class