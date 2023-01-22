Imports System.Data.OleDb

Public Class DetallesEmpeño

    Public Shared codigoEm As Integer = Principal.codigoEmpeñoPrincipal
    Private Sub AbonoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AbonoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDMIDataSet)

    End Sub

    Private Sub DetallesEmpeño_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BDMIDataSet.clientes)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.empeño' Puede moverla o quitarla según sea necesario.
        Me.EmpeñoTableAdapter.Fill(Me.BDMIDataSet.empeño)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.retiro' Puede moverla o quitarla según sea necesario.
        Me.RetiroTableAdapter.Fill(Me.BDMIDataSet.retiro)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.BDMIDataSet.producto)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.abono' Puede moverla o quitarla según sea necesario.
        Me.AbonoTableAdapter.Fill(Me.BDMIDataSet.abono)
        codigoEm = Principal.codigoEmpeñoPrincipal
        LabelAbonos.Text = "TOTAL ABONOS: $" & Me.AbonoTableAdapter.TOTALABONADO(Principal.codigoEmpeñoPrincipal) & " COP"
        LabelProductos.Text = "# PRODUCTOS ASOCIADOS: " & Me.ProductoTableAdapter.CONTAR(Principal.codigoEmpeñoPrincipal)
        Me.AbonoTableAdapter.DETALLES_COD_EMP(Me.BDMIDataSet.abono, Principal.codigoEmpeñoPrincipal)
        Me.ProductoTableAdapter.DETALLES_COD_EMP(Me.BDMIDataSet.producto, Principal.codigoEmpeñoPrincipal)
        'LabelNombreCliente.Text = Me.ClientesTableAdapter.NOMBRE_CLIENTE(Me.BDMIDataSet.clientes, "1063303465")
        Me.ClientesTableAdapter.BUSCAR_CLIENTE(BDMIDataSet.clientes, Principal.cedulaEmpeñoPrincipal)
        LabelNombreCliente.Text = "INFORMACION SOBRE: " & ClientesDataGridView.Item(5, 0).Value & " " & ClientesDataGridView.Item(6, 0).Value

        buscarInfoCliente(Principal.cedulaEmpeñoPrincipal)
        buscarInfoEmpeño(Principal.codigoEmpeñoPrincipal)
        ValorSiEmpeñoRetirado(Principal.codigoEmpeñoPrincipal)
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

    Sub ValorSiEmpeñoRetirado(ByVal codigo As Double)
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim i As Integer = 0
        Dim consulta As String
        Dim lista As Byte

        consulta = "SELECT * FROM retiro WHERE id_empeño=" & codigo
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla")
        lista = registro.Tables("TuTabla").Rows.Count
        If lista <> 0 Then
            Dim val As Double = registro.Tables("TuTabla").Rows(0).Item("valor")
            LabelAvisoEmp.Text = "Aviso: El Empeño Ya Fue Retirado Por Un Valor de: " & val.ToString("C")

        Else
            LabelAvisoEmp.Text = "Aviso: El Empeño Aun No Ha Sido Retirado"
        End If
    End Sub

    Private Sub EmpeñoDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub EmpeñoDataGridView_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles LabelProductos.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        'AbonoTableAdapter.INSERTARABONO()
        Me.AbonoBindingSource.EndEdit()
        AbonoTableAdapter.Update(BDMIDataSet.abono)
        AbonoTableAdapter.Fill(BDMIDataSet.abono)
    End Sub



    Private Sub ButtonCancelarAbono_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxIdAbono_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub ButtonDesempeñar_Click(sender As Object, e As EventArgs) Handles ButtonDesempeñar.Click

        Desempeñar.ShowDialog()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim pass As String = InputBox("Para esta accion Debe tener permisos de administrador, Porfavor introduzca la contraseña administrador", "Validacion!", "")

        If String.IsNullOrEmpty(pass) Then
            MessageBox.Show("No ingreso ninguna Contraseña")
            Return
        Else
            If (Principal.UsuariosTableAdapter.VALIDARUSUARIO(BDMIDataSet.usuarios, "admin", pass)) Then
                Try
                    Me.Validate()
                    Me.ProductoBindingSource.EndEdit()
                    Me.ProductoTableAdapter.Update(Me.BDMIDataSet.producto)
                    Principal.MensajesTableAdapter.ENVIAR_MENSAJE("invitado", "Se ha detectado una modificacion a la tabla productos, desde la ventana Invitado -> DetallesEmpeño.", Now.ToShortTimeString, "system")
                    MsgBox("Update successful")
                Catch ex As Exception
                    MsgBox("Update failed")
                End Try
            End If
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub
End Class