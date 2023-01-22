Imports System.Data.OleDb
Imports System.IO

Public Class Principal
    Dim fileEnUso As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Dropbox\BDMILENIO\EnUso.txt"
    Public Shared codigoEmpeñoPrincipal As Integer = 0
    Public Shared cedulaEmpeñoPrincipal As Integer = 0
    Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Dropbox\BDMILENIO\BDMI.mdb"
    Dim dt1 As DateTime = File.GetLastWriteTime(path)
    'variables para el arqueo'
    Dim SaldoReal As Double = 0
    Dim vent As Double = 0
    Dim pagosInt As Double = 0
    Dim Desempe As Double = 0
    Dim Otro As Integer = 0
    Dim emp As Double = 0
    Dim compOro As Double = 0
    Dim gasto As Double = 0
    Dim devoluciones As Integer = 0
    Dim prestamos As Integer = 0
    Dim totalingresos As Double = 0
    Dim saldoCaja As Double = 0
    Dim totalesEgresos As Double = 0
    Dim SobraFaltante As Double = 0
    'variables ventana desempeños'
    Dim DeudaTotalDes As Integer = 0
    Dim TotalConDescuentoDes As Integer = 0
    Dim cedulaClienteDes As Double
    Dim codDes As Integer = 0


    Private Sub ProductoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDMIDataSet)

    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.movimientos' Puede moverla o quitarla según sea necesario.
        Me.MovimientosTableAdapter.Fill(Me.BDMIDataSet.movimientos)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.gasto' Puede moverla o quitarla según sea necesario.
        Me.GastoTableAdapter.Fill(Me.BDMIDataSet.gasto)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.retiro' Puede moverla o quitarla según sea necesario.
        Me.RetiroTableAdapter.Fill(Me.BDMIDataSet.retiro)

        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.mensajes' Puede moverla o quitarla según sea necesario.
        Me.MensajesTableAdapter.Fill(Me.BDMIDataSet.mensajes)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.arqueo' Puede moverla o quitarla según sea necesario.
        Me.ArqueoTableAdapter.Fill(Me.BDMIDataSet.arqueo)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.BDMIDataSet.usuarios)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.BDMIDataSet.venta)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.Oro' Puede moverla o quitarla según sea necesario.
        Me.OroTableAdapter.Fill(Me.BDMIDataSet.Oro)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.abono' Puede moverla o quitarla según sea necesario.
        Me.AbonoTableAdapter.Fill(Me.BDMIDataSet.abono)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BDMIDataSet.clientes)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.empeño' Puede moverla o quitarla según sea necesario.
        Me.EmpeñoTableAdapter.Fill(Me.BDMIDataSet.empeño)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.producto' Puede moverla o quitarla según sea necesario.
        Me.ProductoTableAdapter.Fill(Me.BDMIDataSet.producto)

        Dim buttonColumnEliminar As New DataGridViewButtonColumn()
        buttonColumnEliminar.Name = "Eliminar"
        EmpeñoDataGridView.Columns.Add(buttonColumnEliminar)

        Dim buttonColumnDetalles As New DataGridViewButtonColumn()
        buttonColumnDetalles.Name = "Detalles"
        EmpeñoDataGridView.Columns.Add(buttonColumnDetalles)

        'CambiarActivoaHistorial()
        'calcula los intereses para todos los empeños resgistrados
        'intereses()
        ActualizarChat()
        Labelhora.Text = Now.ToLongTimeString
        LabelFecha2.Text = Now.ToLongDateString
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        'Me.EmpeñoTableAdapter.INSERTAR_EMPEÑO(CodigoTextBox.Text, Valor_empeñoTextBox.Text, Fecha_llegadaDateTimePicker.Value, Fecha_salidaDateTimePicker.Value, Dia_empeñoTextBox.Text, InteresTextBox.Text, Valor_empeñoTextBox.Text, Estado_productoTextBox.Text, Cedula_clienteTextBox.Text)
        'Me.EmpeñoTableAdapter.Fill(Me.BDMIDataSet.empeño)
    End Sub

    Private Sub PictureAgregarProducto_Click(sender As Object, e As EventArgs) Handles PictureAgregarProducto.Click
        Panel1ModificarProducto.Visible = False
        Panel1Agregar.Visible = True

    End Sub

    Private Sub EmpeñoDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub


    Private Sub EmpeñoDataGridView_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles EmpeñoDataGridView.CellPainting
        If (e.ColumnIndex = 10 And e.RowIndex >= 0) Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celbuton As DataGridViewButtonCell = EmpeñoDataGridView.Rows(e.RowIndex).Cells("Eliminar")
            Dim ico As Icon = New Icon(Environment.CurrentDirectory & "\iconos\icons8_Delete.ico")
            e.Graphics.DrawIcon(ico, e.CellBounds.Left + 3, e.CellBounds.Top + 3)
            EmpeñoDataGridView.Rows(e.RowIndex).Height = ico.Height + 8
            EmpeñoDataGridView.Columns(e.ColumnIndex).Width = ico.Width + 8
            e.Handled = True
        End If
        If (e.ColumnIndex = 11 And e.RowIndex >= 0) Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celbuton As DataGridViewButtonCell = EmpeñoDataGridView.Rows(e.RowIndex).Cells("Detalles")
            Dim ico As Icon = New Icon(Environment.CurrentDirectory & "\iconos\icons8_info.ico")
            e.Graphics.DrawIcon(ico, e.CellBounds.Left + 3, e.CellBounds.Top + 3)
            EmpeñoDataGridView.Rows(e.RowIndex).Height = ico.Height + 8
            EmpeñoDataGridView.Columns(e.ColumnIndex).Width = ico.Width + 8
            e.Handled = True
        End If
    End Sub


    Private Sub EmpeñoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmpeñoDataGridView.CellClick
        If (e.ColumnIndex >= 0) Then
            If (EmpeñoDataGridView.Columns(e.ColumnIndex).Name = "Eliminar") Then
                Dim pass As String = InputBox("Para esta accion Debe tener permisos de administrador, Porfavor introduzca la contraseña administrador", "Validacion!", "")

                If String.IsNullOrEmpty(pass) Then
                    MessageBox.Show("No ingreso ninguna Contraseña")
                    Return
                Else
                    If (UsuariosTableAdapter.VALIDARUSUARIO(BDMIDataSet.usuarios, "admin", pass)) Then
                        Try
                            MessageBox.Show("Esta seguro que desea eliminar este dato?", "Attention!", MessageBoxButtons.YesNo)
                            If Windows.Forms.DialogResult.Yes Then
                                Me.EmpeñoTableAdapter.ELIMINAR_EMPEÑO(EmpeñoDataGridView.Rows(e.RowIndex).Cells(0).Value)
                                Me.EmpeñoTableAdapter.Fill(Me.BDMIDataSet.empeño)
                            Else


                            End If
                        Catch ex As Exception
                            MsgBox("El empeño no se pudo eliminar!")
                        End Try
                    End If
                End If

            Else


            End If
            If (EmpeñoDataGridView.Columns(e.ColumnIndex).Name = "Detalles") Then
                codigoEmpeñoPrincipal = EmpeñoDataGridView.Rows(e.RowIndex).Cells(0).Value
                cedulaEmpeñoPrincipal = EmpeñoDataGridView.Rows(e.RowIndex).Cells(8).Value
                DetallesEmpeño.ShowDialog()

            Else


            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Me.ProductoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDMIDataSet)
        MsgBox("La informacion del cliente ha sido modificada")
    End Sub

    Private Sub BtnInsertarProducto_Click(sender As Object, e As EventArgs) Handles BtnInsertarProducto.Click
        Me.ProductoTableAdapter.AGREGAR_PRODUCTO(TextBoxIdProducto.Text, TextBoxTipoProducto.Text, TextBoxDescripcion.Text, TextBoxPeso.Text, TextBoxValor.Text, TextBoxCodigoEmp.Text, "activo")
        Me.ProductoTableAdapter.Fill(Me.BDMIDataSet.producto)
    End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs)
    '    Dim ced As Integer = TextBoxCedulaConsul.Text
    '    Me.AbonoTableAdapter.HISTORIAL_ABONOS(BDMIDataSet.abono, ced)
    '    'Me.AbonoTableAdapter.Update(Me.BDMIDataSet.abono)

    'End Sub

    'Private Sub Button4_Click_1(sender As Object, e As EventArgs)
    '    Me.AbonoTableAdapter.INSERTARABONO(Id_abonoTextBox.Text, Fecha_abonoDateTimePicker.Value, Valor_abonoTextBox.Text, Codigo_empeñoTextBox.Text)
    '    Me.AbonoTableAdapter.Fill(Me.BDMIDataSet.abono)
    'End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBoxModificar_Click(sender As Object, e As EventArgs) Handles PictureBoxModificar.Click
        CodigoTextBox.Enabled = True
        Dia_empeñoTextBox.Enabled = True
        Valor_empeñoTextBox.Enabled = True
        InteresTextBox.Enabled = True
        Fecha_llegadaDateTimePicker.Enabled = True
        Valor_totalTextBox.Enabled = True
        Fecha_salidaDateTimePicker.Enabled = True
        Estado_productoTextBox.Enabled = True
        Cedula_clienteTextBox.Enabled = True
        ButtonModificarEmpeño.Enabled = True
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBoxInteresVale.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ListViewProductos.Items.RemoveAt(0)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        AgregarProducto.ShowDialog()

    End Sub

    Private Sub ListViewProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewProductos.SelectedIndexChanged

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'validar que todos los campos esten llenos'
        Dim valid As Boolean = False
        Dim Obj As Object
        For Each Obj In Me.Panel5.Controls
            valid = True
            If Obj.Tag = "valida" Then
                If (Trim(Obj.Text) = "") Then

                    MsgBox("Uppss! Campos vacios: " & Trim(Obj.Name))
                    valid = False
                    Exit For
                End If

            End If
        Next
        If (valid = True) Then
            For Each Obj In Me.GroupBox2.Controls
                valid = True
                If Obj.Tag = "valida" Then
                    If (Trim(Obj.Text) = "") Then

                        MsgBox("Uppss! Campos vacios: " & Trim(Obj.Name))
                        valid = False
                        Exit For
                    End If
                End If
            Next
        End If
        If (valid = True) Then
            If (ListViewProductos.Items.Count = 0) Then
                valid = False
                MsgBox("Uppss! No agrego ningun producto")

            Else
                valid = True
            End If
        End If
        If (valid = True) Then
            FrmEspera.Show()
            AGREGAR()

        End If


    End Sub

    Public Sub AGREGAR()
        Button7.Enabled = False
        Try
            Dim td As String = ""
            'variables para el envio de correo'
            Dim EmisorCorreo As String = "compraventa.milenio@gmail.com"
            Dim passwordCorreo As String = "ADMIN-MILENIO"
            Dim MensajeCorreo As String
            Dim AsuntoCorreo As String = "MILENIO COMPRA-VENTA"
            Dim ParaCorreo As String = TextBoxCorreoVale.Text
            'diferencia en dias entre fecha entrada del producto y fecha de salida del producto'
            Dim dias As Integer = 0
            ' On Error Resume Next
            dias = DateDiff(DateInterval.Day, FechaIniVale.Value, FechaSalidaVale.Value)
            dias = dias + 1
            'fin'
            If (ClientesTableAdapter.EXISTE(TextBoxCCVale.Text)) Then

            Else
                ClientesTableAdapter.INSERTAR_CLIENTE(TextBoxCCVale.Text, TextBoxExpedidaVale.Text, TextBoxTelVale.Text, TextBoxResideVale.Text, TextBoxCorreoVale.Text, TextBoxApellidoVale.Text, TextBoxNombreVale.Text)
            End If
            Application.DoEvents()
            ' AbonoTableAdapter.INSERTARABONO(1, TextBoxExpedidaVale.Text, TextBoxTelVale.Text, TextBoxResideVale.Text, TextBoxCorreoVale.Text, TextBoxApellidoVale.Text, TextBoxNombreVale.Text)
            ClientesTableAdapter.Fill(BDMIDataSet.clientes)
            EmpeñoTableAdapter.INSERTAR_EMPEÑO(TextBoxCodigoVale.Text, TextBoxPrecioEntregado.Text, FechaIniVale.Text, FechaSalidaVale.Text, dias, TextBoxInteresVale.Text, TextBoxValorTotalVale.Text, "activo", TextBoxCCVale.Text)
            EmpeñoTableAdapter.Fill(BDMIDataSet.empeño)
            MovimientosTableAdapter.INSERTAR_MOVIMIENTO("empeño", TextBoxPrecioEntregado.Text, Now.Date)
            'MensajeCorreo = "Hola," & TextBoxNombreVale.Text & ". "
            Application.DoEvents()
            Dim i As Double = 0
            For Each item As ListViewItem In Me.ListViewProductos.Items
                Dim tipo As String
                Dim peso As Double
                Dim precio As Double
                Dim Descripcion As String
                tipo = item.SubItems(0).Text
                peso = item.SubItems(1).Text
                precio = item.SubItems(2).Text
                Descripcion = item.SubItems(3).Text
                ' MsgBox(tipo & peso & precio & Descripcion)

                Dim codigoCalc As Object = ProductoTableAdapter.CALCULAR_CODIGO()
                If IsNothing(codigoCalc) Then
                    codigoCalc = 1
                Else
                    codigoCalc = ProductoTableAdapter.CALCULAR_CODIGO() + 1
                End If
                ' MsgBox(codigoCalc + 1 & " " & tipo & " " & Descripcion & " " & peso)
                ProductoTableAdapter.AGREGAR_PRODUCTO(codigoCalc, tipo, Descripcion, peso, precio, TextBoxCodigoVale.Text, "activo")
                ProductoTableAdapter.Fill(BDMIDataSet.producto)
                td += "<tr>
                  <td>" & item.SubItems(0).Text & "</td>
                  <td>" & FechaIniVale.Text & "</td>
                  <td>" & "6 Meses Apartir De Hoy" & " </td>
                  </tr>"
                i += 1

            Next
            'envio de correo electronico al cliente'
            If (TextBoxCorreoVale.Text <> "") Then
                enviarCorreo(EmisorCorreo, passwordCorreo, TextBoxNombreVale.Text, AsuntoCorreo, ParaCorreo, td)
            End If
            'limpiando los campos'
            TextBoxCCVale.Text = ""
            TextBoxExpedidaVale.Text = ""
            TextBoxTelVale.Text = ""
            TextBoxResideVale.Text = ""
            TextBoxCorreoVale.Text = ""
            TextBoxApellidoVale.Text = ""
            TextBoxNombreVale.Text = ""
            TextBoxCodigoVale.Text = ""
            TextBoxPrecioEntregado.Text = ""
            FechaIniVale.Text = ""
            FechaSalidaVale.Text = ""
            dias = 0
            TextBoxInteresVale.Text = ""
            TextBoxValorTotalVale.Text = ""
            ListViewProductos.Items.Clear()
            TextBoxCodigoVale.Text = CodEmpConsecutivo()
            Application.DoEvents()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        FrmEspera.Close()
        Button7.Enabled = True
        'MsgBox("TODOS LOS DATOS SE AGREGARON CORRECTAMENTE A LA BASE DE DATOS")
    End Sub

    'generamos el codigo consetivos para los empeños'
    Function CodEmpConsecutivo()
        Dim p As Object = EmpeñoTableAdapter.CALCULAR_CODIGO()

        If IsNothing(p) Then
            'TextBoxCodigoVale.Text = 1
            Return 1
        Else
            'TextBoxCodigoVale.Text = EmpeñoTableAdapter.CALCULAR_CODIGO() + 1
            Return EmpeñoTableAdapter.CALCULAR_CODIGO() + 1
        End If
    End Function


    Private Sub TabPage5_Paint(sender As Object, e As PaintEventArgs) Handles TabPage5.Paint

        TextBoxCodigoVale.Text = CodEmpConsecutivo()
    End Sub
    Private Sub Buscar(cc As Double)
        Try
            Dim comando As New OleDb.OleDbCommand
            Dim adaptador As New OleDb.OleDbDataAdapter
            Dim registro As New DataSet
            Dim consulta As String
            Dim lista As Double
            consulta = "SELECT * FROM clientes WHERE cedula_cliente = " & TextBoxCCVale.Text & ""
            adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
            registro = New DataSet
            adaptador.Fill(registro, "TuTabla")
            lista = registro.Tables("TuTabla").Rows.Count
            If lista <> 0 Then
                Dim result As DialogResult = MessageBox.Show("Se ha encontrado informacion para este numero de cedula, ¿desea cargar automaticamente la informacion de este cliente?", "Cliente se encuentra registrado", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                If result = DialogResult.Yes Then

                    TextBoxNombreVale.Text = registro.Tables("TuTabla").Rows(0).Item("nombre")
                    TextBoxApellidoVale.Text = registro.Tables("TuTabla").Rows(0).Item("apellidos")
                    TextBoxExpedidaVale.Text = registro.Tables("TuTabla").Rows(0).Item("lugar_expedicion")
                    TextBoxCorreoVale.Text = registro.Tables("TuTabla").Rows(0).Item("correo")
                    TextBoxTelVale.Text = registro.Tables("TuTabla").Rows(0).Item("telefono")
                    TextBoxResideVale.Text = registro.Tables("TuTabla").Rows(0).Item("direccion")

                ElseIf result = DialogResult.No Then


                Else

                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub TextBoxCCVale_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCCVale.TextChanged
        Try
            Buscar(TextBoxCCVale.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim dt2 As DateTime = File.GetLastWriteTime(path)
        If File.Exists(path) = False Then
            MsgBox("Base de datos no encontrada, verifique si el archivo se encuentra en la ruta: " + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Dropbox\")
        Else
            If (dt2 <> dt1) Then
                Me.ClientesTableAdapter.Fill(Me.BDMIDataSet.clientes)
                Me.ProductoTableAdapter.Fill(Me.BDMIDataSet.producto)
                Me.EmpeñoTableAdapter.Fill(Me.BDMIDataSet.empeño)
                Me.AbonoTableAdapter.Fill(Me.BDMIDataSet.abono)
                Me.OroTableAdapter.Fill(Me.BDMIDataSet.Oro)
                Me.GastoTableAdapter.Fill(Me.BDMIDataSet.gasto)
                Me.RetiroTableAdapter.Fill(Me.BDMIDataSet.retiro)
                ActualizarChat()
                'MessageBox.Show("Base de datos actualizada!.")
            End If

        End If
        dt1 = File.GetLastWriteTime(path)
    End Sub



    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If (TextBoxBuscar.Text <> "") Then
            If (ComboBox123.SelectedIndex = 0) Then
                EmpeñoTableAdapter.BUSCAR_CEDULA(BDMIDataSet.empeño, TextBoxBuscar.Text)
            End If
            If (ComboBox123.SelectedIndex = 1) Then
                EmpeñoTableAdapter.BUSCAR_CODIGO(BDMIDataSet.empeño, TextBoxBuscar.Text)
            End If
        Else
            MessageBox.Show(vbInformation, "ERROR: Campo buscar vacio")
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBoxActualizar.Click
        CargaFormularioPrincipal.Show()
        ' Me.ProductoTableAdapter.Fill(Me.BDMIDataSet.producto)
        ' Me.EmpeñoTableAdapter.Fill(Me.BDMIDataSet.empeño)
        'Me.AbonoTableAdapter.Fill(Me.BDMIDataSet.abono)
        'Me.OroTableAdapter.Fill(Me.BDMIDataSet.Oro)

    End Sub

    Private Sub TextBoxPrecioEntregado_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPrecioEntregado.TextChanged
        'Dim nfi As NumberFormatInfo = New CultureInfo("es-ES", False).NumberFormat
        'TextBoxPrecioEntregado.Text = Decimal.Parse(TextBoxPrecioEntregado.Text, nfi)
        Try
            If (TextBoxPrecioEntregado.Text <> "") Then
                Dim int As Integer = TextBoxPrecioEntregado.Text * 0.1
                Dim prec As Integer = TextBoxPrecioEntregado.Text
                TextBoxInteresVale.Text = int
                TextBoxValorTotalVale.Text = prec + int
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Id_abonoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Id_abonoTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Fecha_abonoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Fecha_abonoDateTimePicker_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Valor_abonoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Valor_abonoTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Codigo_empeñoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Codigo_empeñoTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabControlPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControlPrincipal.SelectedIndexChanged

    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles TabPage5.Click

    End Sub

    Private Sub EmpeñoDataGridView_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            Me.ContextMenuStrip = MenuDlesplegable
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        CodigoTextBox.Enabled = True
        Dia_empeñoTextBox.Enabled = True
        Valor_empeñoTextBox.Enabled = True
        InteresTextBox.Enabled = True
        Fecha_llegadaDateTimePicker.Enabled = True
        Valor_totalTextBox.Enabled = True
        Fecha_salidaDateTimePicker.Enabled = True
        Estado_productoTextBox.Enabled = True
        Cedula_clienteTextBox.Enabled = True
        ButtonModificarEmpeño.Enabled = True

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs)
        ' MsgBox(DataGridViewRemates.Rows(0).Cells(0).Value)
        'If (DataGridViewRemates.Item(0, 0).Value = True) Then
        '    MsgBox("hay uno seleccionado")
        'End If
        'codigoEmpeñoPrincipal = EmpeñoDataGridView.Rows(e.RowIndex).Cells(0).Value
        'cedulaEmpeñoPrincipal = EmpeñoDataGridView.Rows(e.RowIndex).Cells(8).Value
    End Sub


    'Private Sub TabPageRemates_Paint(sender As Object, e As PaintEventArgs)
    '    Dim comando As New OleDb.OleDbCommand
    '    Dim adaptador As New OleDb.OleDbDataAdapter
    '    Dim registro As New DataSet
    '    Dim consulta As String
    '    Dim lista As Byte
    '    consulta = "SELECT codigo, [valor_empeño], fecha_llegada, fecha_salida, [dia_empeño], interes, valor_total, estado_producto, cedula_cliente FROM empeño WHERE (estado_producto LIKE 'historial')"
    '    adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
    '    registro = New DataSet
    '    Dim dt As New DataTable()
    '    adaptador.Fill(registro, "TuTabla")
    '    lista = registro.Tables("TuTabla").Rows.Count
    '    DataGridViewRemates.DataSource = registro.Tables("TuTabla").DefaultView

    'End Sub



    Private Sub DataGridViewRemates_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        intereses()
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxInfoEmp.TextChanged
        If (TextBoxInfoEmp.Text <> "") Then
            Dim comando As New OleDb.OleDbCommand
            Dim adaptador As New OleDb.OleDbDataAdapter
            Dim registro As New DataSet
            Dim i As Double = 0
            Dim consulta As String
            Dim lista As Double
            Dim codigoEmp As Integer = TextBoxInfoEmp.Text
            Dim fechaIni As Date

            consulta = "SELECT * FROM empeño WHERE codigo=" & TextBoxInfoEmp.Text
            adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
            registro = New DataSet
            adaptador.Fill(registro, "TuTabla")
            lista = registro.Tables("TuTabla").Rows.Count

            If lista <> 0 Then
                fechaIni = registro.Tables("TuTabla").Rows(0).Item("fecha_llegada")
                codigoEmp = registro.Tables("TuTabla").Rows(0).Item("codigo")
                LabelFechaEmp.Text = registro.Tables("TuTabla").Rows(0).Item("fecha_llegada")
                LabelNombreInt.Text = registro.Tables("TuTabla").Rows(0).Item("cedula_cliente")
                'extraer numero de meses que le faltan por pagar'
                Dim mesespag As Integer = registro.Tables("TuTabla").Rows(0).Item("mesesPagados")
                Dim dias As Integer = 0
                Dim meses As Integer = 0
                dias = DateDiff(DateInterval.Day, registro.Tables("TuTabla").Rows(0).Item("fecha_llegada"), Now)
                meses = DateDiff(DateInterval.Month, registro.Tables("TuTabla").Rows(0).Item("fecha_llegada"), Now)
                Dim residuo As Integer = dias Mod 30
                If (dias Mod 30 = 0) Then

                Else
                    meses += 1
                End If
                If (dias <= 30) Then
                    meses = 1
                End If
                Dim mesesnopagos As Integer = meses - mesespag
                LabelMesesFaltantes.Text = CInt(mesesnopagos)
                'fin'

                If (AbonoTableAdapter.ULTIMOABONO(codigoEmp).HasValue) Then
                    LabelUltimoAbono.Text = AbonoTableAdapter.ULTIMOABONO(codigoEmp)
                Else
                    LabelUltimoAbono.Text = "No ha relizado ningun abono"
                End If
                Dim mesespagados As Integer = registro.Tables("TuTabla").Rows(0).Item("mesesPagados")
                LabelMesesPagados.Text = mesespagados
                LabelMontoEmpeño.Text = registro.Tables("TuTabla").Rows(0).Item("valor_empeño")
                LabelNombreInt.BackColor = Color.Transparent
                LabelUltimoAbono.BackColor = Color.Transparent
                LabelFechaEmp.BackColor = Color.Transparent
                LabelMontoEmpeño.BackColor = Color.Transparent
                LabelMesesPagados.BackColor = Color.Transparent
                LabelMesesFaltantes.BackColor = Color.Transparent
            Else
                ' MsgBox("Empeño no encontrado! verifique si el codigo de empeño esta bien escrito.")
                LabelNombreInt.Text = "No encontrado."
                LabelNombreInt.BackColor = Color.Red
                LabelFechaEmp.Text = "Dato no encontrado."
                LabelFechaEmp.BackColor = Color.Red
                LabelUltimoAbono.Text = "No encontrado."
                LabelUltimoAbono.BackColor = Color.Red
                LabelMontoEmpeño.Text = "No encontrado."
                LabelMontoEmpeño.BackColor = Color.Red
                LabelMesesPagados.Text = "n"
                LabelMesesFaltantes.Text = "n"
                LabelMesesFaltantes.BackColor = Color.Red
                LabelMesesPagados.BackColor = Color.Red
                LabelPrecioPagar2.Text = "none"
                LabelCorreo.Text = "none"
            End If
        End If


    End Sub

    Private Sub TextBoxMesesPagar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMesesPagar.TextChanged
        If (TextBoxMesesPagar.Text <> "" And TextBoxInfoEmp.Text <> "") Then
            Dim MontoEmpeño As Double = LabelMontoEmpeño.Text
            Dim meses As Integer = TextBoxMesesPagar.Text
            Dim precioPagar As Double = MontoEmpeño * (meses * 0.1)
            LabelPrecioApagar.Visible = True
            LabelPrecioApagar.Text = precioPagar.ToString("C")
            LabelPrecioPagar2.Text = precioPagar
        End If
    End Sub

    Private Sub Button9_Click_1(sender As Object, e As EventArgs) Handles Button9.Click
        Dim Style = vbYesNo + vbExclamation + vbDefaultButton2
        Dim msg = "Desea agregar un abono de " & LabelPrecioApagar.Text & " para el Empeño: " & TextBoxInfoEmp.Text & " ?"
        Dim Response = MsgBox(msg, Style, "Porfavor Confirme!")
        Dim id As Integer
        If Response = vbYes Then
            Dim cont As Object = AbonoTableAdapter.CALCULAR_CODIGO()
            If IsNothing(cont) Then
                id = 1
            Else
                id = AbonoTableAdapter.CALCULAR_CODIGO() + 1
            End If
            AbonoTableAdapter.INSERTARABONO(id, Now.Date, LabelPrecioPagar2.Text, TextBoxInfoEmp.Text)
            'Dim Nmeses = EmpeñoTableAdapter.NUMERO_MESESPAGADOS(BDMIDataSet.empeño, TextBoxInfoEmp.Text)
            EmpeñoTableAdapter.AGREGAR_MES(TextBoxMesesPagar.Text, TextBoxInfoEmp.Text)
            interesPorCodigo(TextBoxInfoEmp.Text)
            MovimientosTableAdapter.INSERTAR_MOVIMIENTO("abono", LabelPrecioPagar2.Text, Now.Date)
            MsgBox("El abono se realizo correctamente")
            TextBoxInfoEmp.Text = ""
            TextBoxMesesPagar.Text = ""
            ' Dim mensaje As String = "Usted ha realizado un abono, valor del abono $" + LabelPrecioPagar2.Text + " "
            ' If (ClientesTableAdapter.CORREO_CLIENTE(BDMIDataSet.clientes, LabelNombreInt.Text).ToString) Then
            'Dim dest As String = ClientesTableAdapter.CORREO_CLIENTE(BDMIDataSet.clientes, LabelNombreInt.Text)
            'NotificarAbono("remliysoftware@gmail.com", "remliy12", "ABONO EXITOSO - MILENIO", dest, LabelPrecioApagar.Text, Now, TextBoxInfoEmp.Text)

            'End If

        Else

        End If
    End Sub


    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles ButtonCompraOro.Click

        Try

            OroTableAdapter.AGREGAR_COMPRA(TextBoxGramosOro.Text, TextBoxPrecioCompra.Text, Now.Date)
            MovimientosTableAdapter.INSERTAR_MOVIMIENTO("CompraOro", TextBoxPrecioCompra.Text, Now.Date)
            MsgBox("Compra efectuada correctamente!")
            TextBoxGramosOro.Text = ""
            TextBoxPrecioCompra.Text = ""
        Catch ex As Exception
            MessageBox.Show("No se Guardo la compra!", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'End Using

    End Sub

    Private Sub TextBoxGramosOro_TextChanged(sender As Object, e As EventArgs) Handles TextBoxGramosOro.TextChanged

    End Sub

    Private Sub TextBoxPrecioCompra_TextChanged(sender As Object, e As EventArgs) Handles TextBoxPrecioCompra.TextChanged
        If (TextBoxPrecioCompra.Text <> "") Then
            Dim val As Double = TextBoxPrecioCompra.Text
            Label39.Text = val.ToString("C")
        End If
    End Sub

    Private Sub LabelPrecioApagar_Click(sender As Object, e As EventArgs) Handles LabelPrecioApagar.Click

    End Sub

    Private Sub TabPageOro_Click(sender As Object, e As EventArgs) Handles TabPageOro.Click

    End Sub

    Private Sub TextBoxGramosOro_LostFocus(sender As Object, e As EventArgs) Handles TextBoxGramosOro.LostFocus
        If (TextBoxGramosOro.Text <> "") Then
            Dim content As String = TextBoxGramosOro.Text
            TextBoxGramosOro.Text = content.ToString.Replace(".", ",")
        End If
    End Sub



    Private Sub TabPage4_Paint(sender As Object, e As PaintEventArgs) Handles TabPage4.Paint
        'ComboBoxC.SelectedIndex = 0
    End Sub

    Private Sub ProductoDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductoDataGridView.CellContentClick

    End Sub

    Private Sub Button10_Click_1(sender As Object, e As EventArgs) Handles ButtonListarProductos.Click
        llenarDatagridProductosDisponibles()
    End Sub
    Sub llenarDatagridProductosDisponibles()
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim i As Double = 0
        Dim consulta As String
        Dim lista As Double
        Dim fechaIni As Date = Now

        consulta = "SELECT * FROM producto AS P WHERE estado_producto like 'activo' and codigo_empeño = (SELECT codigo FROM empeño as E WHERE E.estado_producto like 'historico' and codigo = P.codigo_empeño)"
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla")
        lista = registro.Tables("TuTabla").Rows.Count

        If lista <> 0 Then
            'DataGridViewRemates.Rows.Clear()
            Dim dt As New DataTable("ProductosEnVenta")

            dt.Columns.Add("id")
            dt.Columns.Add("tipo")
            dt.Columns.Add("descripcion")
            dt.Columns.Add("peso")
            dt.Columns.Add("valor")
            dt.Columns.Add("codigo_empeño")

            While i < lista
                'DataGridViewRemates.Rows.Add()
                Dim id = registro.Tables("TuTabla").Rows(i).Item("id_producto")
                Dim tipo = registro.Tables("TuTabla").Rows(i).Item("Tipo")
                Dim des = registro.Tables("TuTabla").Rows(i).Item("descripcion")
                Dim peso = registro.Tables("TuTabla").Rows(i).Item("peso")
                Dim valor = registro.Tables("TuTabla").Rows(i).Item("valor")
                'Dim cedula = registro.Tables("TuTabla").Rows(i).Item("cedula_cliente")
                Dim codigoE = registro.Tables("TuTabla").Rows(i).Item("codigo_empeño")

                Dim dr As DataRow
                dr = dt.NewRow()

                dr("id") = id
                dr("tipo") = tipo
                dr("descripcion") = des
                dr("peso") = peso
                dr("valor") = valor
                dr("codigo_empeño") = codigoE
                dt.Rows.Add(dr)

                i += 1
            End While
            Dim ds As New DataSet()
            ds.Tables.Add(dt)
            DataGridViewProductosDisponibles.DataSource = ds.Tables("ProductosEnVenta")

        End If
    End Sub
    Private Sub Button10_Click_2(sender As Object, e As EventArgs) Handles ButtonRealizarArqueo.Click
        Dim result = MessageBox.Show("Esta Seguro Que Desea Terminar el arqueo de caja para el dia de hoy?", "Confirme.", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Dim faltan As Double = 0
            Dim sobran As Double = 0
            If (SobraFaltante > 0) Then
                sobran = SobraFaltante
            Else
                faltan = SobraFaltante
            End If
            Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
            Dim valorVenta As Double = 0
            Try
                CONEXION.Open()
                Dim CONSULTA As String = "INSERT INTO arqueo(saldoReal,saldo,total,sobrante,faltante,fecha) VALUES(" & SaldoReal & "," & saldoCaja & "," & totalingresos & "," & sobran & "," & faltan & ",'" & Now.Date & "') "
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                Dim DR As OleDbDataReader = COMANDO.ExecuteReader
                DR.Close()
                CONEXION.Close()
                Dim mens = "Se realizo un arqueo de caja con los siguientes DATOS: SaldoReal en caja: " & SaldoReal.ToString("C") & " SaldoEnCaja: " & saldoCaja.ToString("C") & " Sobrantes: " & sobran.ToString("C") & " Faltantes: " & faltan.ToString("C")
                Me.MensajesTableAdapter.ENVIAR_MENSAJE("invitado", mens, Now, "msj")
                'copia de restauración'
                If Not Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\BDMI-RESTAURACION") Then
                    Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\BDMI-RESTAURACION")
                End If
                Dim t As String = "BDMI-" & Now.Date & ".mdb"
                Dim PathName As String = t.Replace("/", "-")
                My.Computer.FileSystem.CopyFile(path, Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Documents\BDMI-RESTAURACION\" & PathName)
                MsgBox("Arqueo exitoso!")
                'Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else

        End If
    End Sub

    Private Sub TextBox1_TextChanged_2(sender As Object, e As EventArgs) Handles TextBoxSaldoEnCaja.TextChanged

        Dim ingresos As Double
        Dim egresos As Double

    End Sub


    Private Sub DataGridViewProductosDisponibles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProductosDisponibles.CellClick
        If (e.ColumnIndex >= 0) Then

            If (DataGridViewProductosDisponibles.Columns(e.ColumnIndex).Name = "Vender") Then
                Dim result = MessageBox.Show("Esta Seguro Que Desea Vender Este producto?", "Confirme.", MessageBoxButtons.YesNo)
                If (result = DialogResult.Yes) Then
                    Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                    Dim valorVenta As Double = DataGridViewProductosDisponibles.Rows(e.RowIndex).Cells(5).Value
                    Try
                        CONEXION.Open()
                        Dim CONSULTA As String = "INSERT INTO venta (idProducto,fecha,valor)VALUES('" & DataGridViewProductosDisponibles.Rows(e.RowIndex).Cells(1).Value & "','" & Now.Date.ToShortDateString & "','" & valorVenta & "')"
                        Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                        Dim DR As OleDbDataReader = COMANDO.ExecuteReader
                        DR.Close()
                        CONEXION.Close()
                        ProductoTableAdapter.VENDER_PRODUCTO("vendido", DataGridViewProductosDisponibles.Rows(e.RowIndex).Cells(1).Value)
                        MsgBox("Venta Finalizada, el Producto ha sido Vendido")

                        llenarDatagridProductosDisponibles()
                    Catch ex As Exception

                        MsgBox(ex.Message)
                    End Try
                    ' MsgBox("EL producto ha sido Vendido")
                Else

                End If
            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ButtonModificarEmpeño_Click(sender As Object, e As EventArgs) Handles ButtonModificarEmpeño.Click
        Dim pass As String = InputBox("Para esta accion Debe tener permisos de administrador, Porfavor introduzca la contraseña administrador", "Validacion!", "")

        If String.IsNullOrEmpty(pass) Then
            MessageBox.Show("No ingreso ninguna Contraseña")
            Return
        Else
            If (UsuariosTableAdapter.VALIDARUSUARIO(BDMIDataSet.usuarios, "admin", pass)) Then
                Try
                    Me.Validate()
                    Me.EmpeñoBindingSource.EndEdit()
                    Me.EmpeñoTableAdapter.Update(Me.BDMIDataSet.empeño)
                    Me.MensajesTableAdapter.ENVIAR_MENSAJE("invitado", "Aviso! se detecto una modificacion a la tabla empeño desde la ventana invitado.", Now.ToShortTimeString, "system")

                    MsgBox("Update successful")

                Catch ex As Exception
                    MsgBox("Update failed")
                End Try
            End If
        End If
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Panel7Abono.Enabled = True
    End Sub

    Private Sub PictureBox5_Click_2(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Panel8Buscar.Enabled = True
        ToolStripComboBox1.SelectedIndex = 0
    End Sub

    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs) Handles ToolStripComboBox1.Click

    End Sub

    Private Sub ToolStripComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ToolStripComboBox1.SelectedIndexChanged
        If (ToolStripTextBoxDato.Text <> "") Then

            If (ToolStripComboBox1.SelectedIndex = 0) Then
                Try
                    Dim comando As New OleDb.OleDbCommand
                    Dim adaptador As New OleDb.OleDbDataAdapter
                    Dim registro As New DataSet
                    Dim i As Double = 0
                    Dim consulta As String
                    Dim lista As Double
                    consulta = "SELECT * FROM abono WHERE id_abono =" & ToolStripTextBoxDato.Text
                    adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
                    registro = New DataSet
                    adaptador.Fill(registro, "TuTabla")
                    lista = registro.Tables("TuTabla").Rows.Count
                    If lista <> 0 Then
                        DataGridViewResultadoAb.DataSource = registro.Tables("TuTabla")
                        Dim total As Double = AbonoTableAdapter.CANTIDAD_ID(ToolStripTextBoxDato.Text)
                        LabelNumEmpeños.Text = "Cantidad Actual Abonada: " & total.ToString("C")

                    End If
                Catch ex As Exception
                    ' Show the exception's message.
                    MessageBox.Show(ex.Message)
                End Try
            End If

            If (ToolStripComboBox1.SelectedIndex = 1) Then
                Try
                    Dim comando As New OleDb.OleDbCommand
                    Dim adaptador As New OleDb.OleDbDataAdapter
                    Dim registro As New DataSet
                    Dim i As Integer = 0
                    Dim consulta As String
                    Dim lista As Byte
                    consulta = "SELECT * FROM abono as a WHERE codigo_empeño = (SELECT codigo FROM empeño where codigo = a.codigo_empeño and cedula_cliente = " & ToolStripTextBoxDato.Text & ")"
                    adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
                    registro = New DataSet
                    adaptador.Fill(registro, "TuTabla")
                    lista = registro.Tables("TuTabla").Rows.Count
                    If lista <> 0 Then
                        DataGridViewResultadoAb.DataSource = registro.Tables("TuTabla")
                    End If
                    LabelNumEmpeños.Text = " Numero de Empeños Encontrados: " & EmpeñoTableAdapter.CONTAR_EMPEÑOS_CED(ToolStripTextBoxDato.Text)
                Catch ex As Exception
                    ' Show the exception's message.
                    MessageBox.Show(ex.Message)
                End Try
            End If

            If (ToolStripComboBox1.SelectedIndex = 2) Then
                Try
                    Dim comando As New OleDb.OleDbCommand
                    Dim adaptador As New OleDb.OleDbDataAdapter
                    Dim registro As New DataSet
                    Dim i As Integer = 0
                    Dim consulta As String
                    Dim lista As Byte
                    consulta = "SELECT * FROM abono WHERE codigo_empeño =" & ToolStripTextBoxDato.Text
                    adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
                    registro = New DataSet
                    adaptador.Fill(registro, "TuTabla")
                    lista = registro.Tables("TuTabla").Rows.Count
                    If lista <> 0 Then
                        DataGridViewResultadoAb.DataSource = registro.Tables("TuTabla")
                        Dim total As Double = AbonoTableAdapter.CANTIDAD_CODEMP(ToolStripTextBoxDato.Text)
                        LabelNumEmpeños.Text = "Cantidad Actual Abonada: " & total.ToString("C")
                    End If
                Catch ex As Exception
                    ' Show the exception's message.
                    MessageBox.Show(ex.Message)
                End Try
            End If

        Else
            MsgBox("Debe ingresar un dato a buscar!")
        End If
    End Sub

    Private Sub Panel7_Paint(sender As Object, e As PaintEventArgs) Handles Panel7.Paint

    End Sub

    Private Sub PictureModificarProducto_Click(sender As Object, e As EventArgs) Handles PictureModificarProducto.Click
        Panel1Agregar.Visible = False
        Panel1ModificarProducto.Visible = True
    End Sub


    Private Sub ToolStripTextBoxBuscarProd_TextChanged(sender As Object, e As EventArgs) Handles ToolStripTextBoxBuscarProd.TextChanged
        If (ToolStripTextBoxBuscarProd.Text <> "") Then

            Try
                Dim comando As New OleDb.OleDbCommand
                Dim adaptador As New OleDb.OleDbDataAdapter
                Dim registro As New DataSet
                Dim i As Integer = 0
                Dim consulta As String
                Dim lista As Byte
                consulta = "SELECT * FROM producto WHERE id_producto =" & ToolStripTextBoxBuscarProd.Text & "or codigo_empeño = " & ToolStripTextBoxBuscarProd.Text
                adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
                registro = New DataSet
                adaptador.Fill(registro, "TuTabla")
                lista = registro.Tables("TuTabla").Rows.Count
                If lista <> 0 Then
                    ProductoDataGridView.DataSource = registro.Tables("TuTabla")

                End If
            Catch ex As Exception
                ' Show the exception's message.
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click

        ProductoDataGridView.DataSource = ProductoBindingSource
        ProductoDataGridView.Refresh()

    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        Dim pass As String = InputBox("Para esta accion Debe tener permisos de administrador, Porfavor introduzca la contraseña administrador", "Validacion!", "")

        If String.IsNullOrEmpty(pass) Then
            MessageBox.Show("No ingreso ninguna Contraseña")
            Return
        Else
            If (UsuariosTableAdapter.VALIDARUSUARIO(BDMIDataSet.usuarios, "admin", pass)) Then
                Try
                    Me.Validate()
                    Me.ProductoBindingSource.EndEdit()
                    Me.ProductoTableAdapter.Update(Me.BDMIDataSet.producto)
                    Me.MensajesTableAdapter.ENVIAR_MENSAJE("invitado", "Se ha detectado una modificacion a la tabla productos, desde la ventana Invitado", Now.ToShortTimeString, "system")
                    MsgBox("Update successful")

                Catch ex As Exception
                    MsgBox("Update failed")
                End Try
            End If
        End If
    End Sub

    Private Sub TabPageArqueo_Paint(sender As Object, e As PaintEventArgs) Handles TabPageArqueo.Paint

    End Sub

    Private Sub TabPageArqueo_Click(sender As Object, e As EventArgs) Handles TabPageArqueo.Click

        Dim res As Double = InputBox("Digite el Saldo Real en Caja", "Arqueo", 0)

        If String.IsNullOrEmpty(res) Then
            MessageBox.Show("Debe digitar EL saldo real en caja")
            Return
        Else
            SaldoReal = res
            vent = Ventas()
            pagosInt = pagosIntereses()
            Desempe = Desempeños()
            Otro = 0
            emp = -empeños()
            compOro = -CompraOro()
            gasto = -gastos()
            devoluciones = 0
            prestamos = 0
            totalingresos = 0
            If (verificarSiHayArqueos() = True) Then
                Dim SC As Double = ArqueoTableAdapter.SaldoUltimoArqueo(BDMIDataSet.arqueo, ArqueoTableAdapter.ULTIMO_ARQUEO())
                LabelSaldoUltimoArq.Text = "Saldo Caja de Ultimo Arqueo: " & SC.ToString("C")
                LabelFechaUltimoArq.Text = ArqueoTableAdapter.ULTIMO_ARQUEO()
                saldoCaja = SC + vent + pagosInt + Desempe + Otro + emp + compOro + gasto
            Else
                LabelSaldoUltimoArq.Text = "No encontrado"
                LabelFechaUltimoArq.Text = "No encontrado"
                saldoCaja = vent + pagosInt + Desempe + Otro + emp + compOro + gasto
            End If
            totalesEgresos = 0
            SobraFaltante = 0
            TextBoxSaldoReal.Text = SaldoReal.ToString("C")
            TextBoxVentas.Text = vent.ToString("C")
            TextBoxInteresesPagos.Text = pagosInt.ToString("C")
            TextBoxDesempeños.Text = Desempe.ToString("C")
            TextBoxSaldoEnCaja.Text = saldoCaja.ToString("C")
            TextBoxEmpeño.Text = emp.ToString("C")
            TextBoxCompraOro.Text = compOro.ToString("C")
            TextBoxGastos.Text = gasto.ToString("C")
            TextBoxOtroIngreso.Text = Otro.ToString("C")
            TextBoxPrestamos.Text = prestamos.ToString("C")
            'TextBoxTotalesEgresos.Text = SaldoReal + (emp + compOro + gasto)
            totalingresos = ((vent + pagosInt + Desempe + Otro) + (emp + compOro + gasto)) + SaldoReal
            'totalesEgresos = SaldoReal + emp + compOro + gasto
            TextBoxTotalArqueo.Text = totalingresos.ToString("C")
            'TextBoxTotalesEgresos.Text = totalesEgresos
            'TextBoxFaltantes.Text = saldoCaja - totalesEgresos
            SobraFaltante = SaldoReal - saldoCaja
            If (SobraFaltante > 0) Then
                TextBoxSobrantes.Text = SobraFaltante.ToString("C")
                TextBoxFaltantes.Text = 0
            Else
                TextBoxFaltantes.Text = SobraFaltante.ToString("C")
                TextBoxSobrantes.Text = 0
            End If
            LabelFechaActual.Text = Now.ToShortDateString
        End If

    End Sub

    'detalles del arqueo '

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        PanelArqueo.Visible = False
        PanelDetallesArq.Visible = True
        LabelFechaActual.Text = Now.Date

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PanelDetallesArq.Visible = False
        PanelArqueo.Visible = True
    End Sub

    Private Sub TabPageArqueo_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles TabPageArqueo.MouseDoubleClick

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBoxArqueo.Click
        Try
            Dim res As Double = InputBox("Digite el Saldo Real en Caja", "Arqueo", 0)

            If String.IsNullOrEmpty(res) Then
                MessageBox.Show("Debe digitar EL saldo real en caja")
                Return
            Else
                SaldoReal = res
                vent = Ventas()
                pagosInt = pagosIntereses()
                Desempe = Desempeños()
                Otro = 0
                emp = -empeños()
                compOro = -CompraOro()
                gasto = -gastos()
                devoluciones = 0
                prestamos = 0
                totalingresos = 0
                If (verificarSiHayArqueos() = True) Then
                    Dim SC As Double = ArqueoTableAdapter.SaldoUltimoArqueo(BDMIDataSet.arqueo, ArqueoTableAdapter.ULTIMO_ARQUEO())
                    LabelSaldoUltimoArq.Text = "Saldo Caja de Ultimo Arqueo: " & SC.ToString("C")
                    LabelFechaUltimoArq.Text = ArqueoTableAdapter.ULTIMO_ARQUEO()
                    saldoCaja = SC + vent + pagosInt + Desempe + Otro + emp + compOro + gasto
                Else
                    LabelSaldoUltimoArq.Text = "No encontrado"
                    LabelFechaUltimoArq.Text = "No encontrado"
                    saldoCaja = vent + pagosInt + Desempe + Otro + emp + compOro + gasto
                End If
                totalesEgresos = 0
                SobraFaltante = 0
                TextBoxSaldoReal.Text = SaldoReal.ToString("C")
                TextBoxVentas.Text = vent.ToString("C")
                TextBoxInteresesPagos.Text = pagosInt.ToString("C")
                TextBoxDesempeños.Text = Desempe.ToString("C")
                TextBoxSaldoEnCaja.Text = saldoCaja.ToString("C")
                TextBoxEmpeño.Text = emp.ToString("C")
                TextBoxCompraOro.Text = compOro.ToString("C")
                TextBoxGastos.Text = gasto.ToString("C")
                TextBoxOtroIngreso.Text = Otro.ToString("C")
                TextBoxPrestamos.Text = prestamos.ToString("C")
                'TextBoxTotalesEgresos.Text = SaldoReal + (emp + compOro + gasto)
                totalingresos = ((vent + pagosInt + Desempe + Otro) + (emp + compOro + gasto)) + SaldoReal
                'totalesEgresos = SaldoReal + emp + compOro + gasto
                TextBoxTotalArqueo.Text = totalingresos.ToString("C")
                'TextBoxTotalesEgresos.Text = totalesEgresos
                'TextBoxFaltantes.Text = saldoCaja - totalesEgresos
                SobraFaltante = SaldoReal - saldoCaja
                If (SobraFaltante > 0) Then
                    TextBoxSobrantes.Text = SobraFaltante.ToString("C")
                    TextBoxFaltantes.Text = 0
                Else
                    TextBoxFaltantes.Text = SobraFaltante.ToString("C")
                    TextBoxSobrantes.Text = 0
                End If
                LabelFechaActual.Text = Now.ToShortDateString
            End If
        Catch ex As Exception
            MsgBox("Error mientras se mostraba el arqueo, recuerde ingresar un Valor valido para el saldo Real en caja")
        End Try
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub TextBoxGramosOro_GotFocus(sender As Object, e As EventArgs) Handles TextBoxGramosOro.GotFocus

    End Sub

    Private Sub TabPageNotificaciones_Click(sender As Object, e As EventArgs) Handles TabPageNotificaciones.Click

    End Sub
    'Chat de Notificaciones'
    Public Sub ActualizarChat()
        'RichTextBoxMensajes
        'listar mensajes'
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim i As Double = 0
        Dim consulta As String
        Dim lista As Double
        consulta = "SELECT * FROM mensajes"
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla2")
        lista = registro.Tables("TuTabla2").Rows.Count

        If lista <> 0 Then
            Me.RichTextBox1.Clear()
            While i < lista
                Dim usuario As String = registro.Tables("TuTabla2").Rows(i).Item("usuario")
                Dim mensaje As String = registro.Tables("TuTabla2").Rows(i).Item("mensaje")
                Dim tipo As String = registro.Tables("TuTabla2").Rows(i).Item("tipo")
                Dim hora As Date = registro.Tables("TuTabla2").Rows(i).Item("hora")
                If (usuario.Equals("invitado") And tipo.Equals("msj")) Then
                    Me.RichTextBox1.AppendText("[" & hora & "]  " & "<" & usuario & ">: " & mensaje & vbNewLine)
                End If

                If (usuario.Equals("administrador") And tipo.Equals("msj")) Then
                    Me.RichTextBox1.AppendText("[" & hora & "]  " & "<" & usuario & ">: " & mensaje & vbNewLine)
                End If
                i += 1
            End While
        End If
    End Sub

    Private Sub RichTextBox1_Paint(sender As Object, e As PaintEventArgs) Handles RichTextBox1.Paint

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If (RichTextBoxMessage.Text <> "") Then
            enviarMensajeInvitado("invitado", "msj", RichTextBoxMessage.Text)
            RichTextBoxMessage.Text = ""
        Else
            MsgBox("debe escribir un mensaje")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBoxBuscar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBuscar.TextChanged
        If (TextBoxBuscar.Text = "") Then
            Me.EmpeñoTableAdapter.Fill(Me.BDMIDataSet.empeño)
        End If
    End Sub

    Private Sub ComboBox123_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox123.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles ButtonDesempeñar.Click
        Dim result = MessageBox.Show("Esta Seguro Que Desea Desempeñar el o los articulos?", "Confirme.", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
            Dim valorVenta As Double = 0
            Try
                CONEXION.Open()
                Dim CONSULTA As String = "UPDATE empeño SET estado_producto = 'retirado', fecha_salida = '" & Now.Date.ToShortDateString & "', valor_total=" & TotalConDescuentoDes & ", interes=0 WHERE codigo = " & TextBoxBuscarDesempeño.Text & ""
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                Dim DR As OleDbDataReader = COMANDO.ExecuteReader
                DR.Close()
                CONEXION.Close()
                DetallesEmpeño.ProductoTableAdapter.RETIRAR_PRODUCTO_EMP("retirado", TextBoxBuscarDesempeño.Text)
                RetiroTableAdapter.AGREGAR_RETIRO(Now.ToShortDateString, Now.ToString("hh:mm:ss"), cedulaClienteDes, TextBoxBuscarDesempeño.Text, TotalConDescuentoDes)
                MovimientosTableAdapter.INSERTAR_MOVIMIENTO("retiro", TotalConDescuentoDes, Now.Date)
                MsgBox("Retiro exitoso!")
                'Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged_3(sender As Object, e As EventArgs) Handles TextBoxBuscarDesempeño.TextChanged
        Try
            Dim comando As New OleDb.OleDbCommand
            Dim adaptador As New OleDb.OleDbDataAdapter
            Dim registro As New DataSet
            Dim i As Integer = 0
            Dim consulta As String
            Dim lista As Double

            Dim fechaIni As Date

            consulta = "SELECT * FROM empeño WHERE codigo = " & TextBoxBuscarDesempeño.Text
            adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
            registro = New DataSet
            adaptador.Fill(registro, "TuTabla")
            lista = registro.Tables("TuTabla").Rows.Count
            If lista <> 0 Then
                LabelAviso.Text = "Empeño Encontrado!"
                DeudaTotalDes = registro.Tables("TuTabla").Rows(0).Item("valor_total")
                cedulaClienteDes = registro.Tables("TuTabla").Rows(0).Item("cedula_cliente")
                codDes = registro.Tables("TuTabla").Rows(0).Item("codigo")
                TextBoxDescuento.Text = 0
                If (registro.Tables("TuTabla").Rows(0).Item("estado_producto") = "retirado") Then
                    ButtonDesempeñar.Enabled = False
                    LabelAviso.Text = "Aviso: El empeño ya se encuentra en estado 'retirado'."
                Else
                    ButtonDesempeñar.Enabled = True
                End If

            Else
                ButtonDesempeñar.Enabled = False
                LabelAviso.Text = "Aviso: No Se Encontro Ningun Empeño Asociado"
            End If
            consulta = "SELECT descripcion FROM producto WHERE codigo_empeño =" & Principal.codigoEmpeñoPrincipal
            adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
            registro = New DataSet
            adaptador.Fill(registro, "TuTabla")
            lista = registro.Tables("TuTabla").Rows.Count
            If lista <> 0 Then
                ' DataGridViewP.DataSource = registro.Tables("TuTabla")

            End If
            LabelDeudaDes.Text = DeudaTotalDes.ToString("C")
            TotalConDescuentoDes = DeudaTotalDes - TextBoxDescuento.Text
            LabelTotalDes.Text = TotalConDescuentoDes.ToString("C")
            LabelCedDes.Text = cedulaClienteDes

        Catch
            ButtonDesempeñar.Enabled = False
            LabelAviso.Text = "Error: Ha Introducido un Caracter No Valido"
        End Try
    End Sub

    Private Sub TextBoxDescuento_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDescuento.TextChanged
        TotalConDescuentoDes = DeudaTotalDes - Val(TextBoxDescuento.Text)
        LabelTotalDes.Text = TotalConDescuentoDes.ToString("C")
    End Sub

    Private Sub LabelAviso_Click(sender As Object, e As EventArgs) Handles LabelAviso.Click

    End Sub

    Private Sub PanelArqueo_Paint(sender As Object, e As PaintEventArgs) Handles PanelArqueo.Paint

    End Sub

    Private Sub Hora_Tick(sender As Object, e As EventArgs) Handles Hora.Tick
        Labelhora.Text = Now.ToLongTimeString
        LabelFecha2.Text = Now.ToLongDateString
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub PanelArqueo_Click(sender As Object, e As EventArgs) Handles PanelArqueo.Click
        Dim res As Double = InputBox("Digite el Saldo Real en Caja", "Arqueo", 0)
        Dim pagos As Double = pagosIntereses()
        Dim ventass As Double = Ventas()
        Dim retir As Double = Desempeños()
        Dim em As Double = empeños()
        Dim oro As Double = CompraOro()
        Dim gast As Double = gastos()
        LabelNumeroAbonos.Text = pagos.ToString("C")
        LabelNumeroVentas.Text = ventass.ToString("C")
        LabelNumeroRetiros.Text = retir.ToString("C")
        LabelNumeroEmpeños.Text = em.ToString("C")
        LabelNumeroOro.Text = oro.ToString("C")
        LabelNumeroGastos.Text = gast.ToString("C")
        If String.IsNullOrEmpty(res) Then
            MessageBox.Show("Debe digitar EL saldo real en caja")
            Return
        Else
            SaldoReal = res
            vent = Ventas()
            pagosInt = pagosIntereses()
            Desempe = Desempeños()
            Otro = 0
            emp = -empeños()
            compOro = -CompraOro()
            gasto = -gastos()
            devoluciones = 0
            prestamos = 0
            totalingresos = 0
            If (verificarSiHayArqueos() = True) Then
                Dim ultimo As Date = ArqueoTableAdapter.ULTIMO_ARQUEO()
                Dim SC As Integer = ArqueoTableAdapter.SaldoUltimoArq()
                LabelSaldoUltimoArq.Text = "Saldo Caja de Ultimo Arqueo: " & SC
                LabelFechaUltimoArq.Text = ArqueoTableAdapter.ULTIMO_ARQUEO()
                saldoCaja = SC + vent + pagosInt + Desempe + Otro + emp + compOro + gasto
            Else
                LabelSaldoUltimoArq.Text = "No encontrado"
                LabelFechaUltimoArq.Text = "No encontrado"
                saldoCaja = vent + pagosInt + Desempe + Otro + (emp + compOro + gasto)
            End If
            totalesEgresos = 0
            SobraFaltante = 0
            TextBoxSaldoReal.Text = SaldoReal.ToString("C")
            TextBoxVentas.Text = vent.ToString("C")
            TextBoxInteresesPagos.Text = pagosInt.ToString("C")
            TextBoxDesempeños.Text = Desempe.ToString("C")
            TextBoxSaldoEnCaja.Text = saldoCaja.ToString("C")
            TextBoxEmpeño.Text = emp.ToString("C")
            TextBoxCompraOro.Text = compOro.ToString("C")
            TextBoxGastos.Text = gasto.ToString("C")
            TextBoxOtroIngreso.Text = Otro.ToString("C")
            TextBoxPrestamos.Text = prestamos.ToString("C")
            'TextBoxTotalesEgresos.Text = SaldoReal + (emp + compOro + gasto)
            totalingresos = ((vent + pagosInt + Desempe + Otro) + (emp + compOro + gasto)) + SaldoReal
            'totalesEgresos = SaldoReal + emp + compOro + gasto
            TextBoxTotalArqueo.Text = totalingresos.ToString("C")
            'TextBoxTotalesEgresos.Text = totalesEgresos
            'TextBoxFaltantes.Text = saldoCaja - totalesEgresos
            SobraFaltante = SaldoReal - saldoCaja
            If (SobraFaltante > 0) Then
                TextBoxSobrantes.Text = SobraFaltante.ToString("C")
                TextBoxFaltantes.Text = 0
            Else
                TextBoxFaltantes.Text = SobraFaltante.ToString("C")
                TextBoxSobrantes.Text = 0
            End If
            LabelFechaActual.Text = Now.ToShortDateString
        End If
    End Sub

    Private Sub Button3_Click_3(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result = MessageBox.Show("Esta Seguro Que Desea Deseas añadir un nuevo gasto?", "Confirme.", MessageBoxButtons.YesNo)
        If (result = DialogResult.Yes) Then
            Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
            Dim valorVenta As Double = 0
            Try
                CONEXION.Open()
                Dim CONSULTA As String = "INSERT INTO gasto(fecha,valor,Descripcion) VALUES ('" & Now.Date & "'," & TextBoxAñadirGasto.Text & ",'" & RichTextBoxGastoDescripcion.Text & "') "
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                Dim DR As OleDbDataReader = COMANDO.ExecuteReader
                DR.Close()
                CONEXION.Close()
                MovimientosTableAdapter.INSERTAR_MOVIMIENTO("gasto", TextBoxAñadirGasto.Text, Now.Date)
                MsgBox("Gasto añadido con exito!")
                'Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Me.Close()
        End If
    End Sub

    Private Sub TextBox1_TextChanged_4(sender As Object, e As EventArgs) Handles TextBoxAñadirGasto.TextChanged
        Try
            Dim gast As Double = TextBoxAñadirGasto.Text
            Label83.Text = gast.ToString("C")
            Button3.Enabled = True
        Catch ex As Exception
            Button3.Enabled = False
        End Try
    End Sub

    Private Sub Principal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim f As Date = ArqueoTableAdapter.ULTIMO_ARQUEO
        If (f.ToShortDateString < Now.ToShortDateString) Then

            If MessageBox.Show("No ha realizado arqueo de caja hoy, ¿seguro que quiere Cerrar la aplicación?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                My.Computer.FileSystem.DeleteFile(fileEnUso)
                End

            Else

                e.Cancel = True

            End If
        Else
            My.Computer.FileSystem.DeleteFile(fileEnUso)
            End
        End If
    End Sub

    Private Sub LabelFechaActual_Click(sender As Object, e As EventArgs) Handles LabelFechaActual.Click

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged


        If (CheckedListBox1.GetItemChecked(0)) Then
            Label42.Text = "Retiros"
            Panel13Abono.Visible = False
            Panel13Ventas.Visible = False
            Panel13Empeño.Visible = False
            Panel13Gasto.Visible = False
            Panel13Oro.Visible = False
            Panel13Retiro.Visible = True
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT * FROM retiro WHERE fecha_retiro = @fecha"
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now.Date)
                Dim ultimoarqueo As Date = ArqueoTableAdapter.ULTIMO_ARQUEO()
                COMANDO.Parameters.AddWithValue("@UltimoArqueo", ultimoarqueo)
                Dim Adapter As New OleDbDataAdapter(COMANDO)
                Dim dt As New DataTable
                Adapter.Fill(dt)
                DGVretiro.DataSource = dt
                CONEXION.Close()
                LabelNretiro.Text = dt.Rows.Count
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        If (CheckedListBox1.GetItemChecked(1)) Then
            Label42.Text = "Abonos"
            Panel13Ventas.Visible = False
            Panel13Empeño.Visible = False
            Panel13Gasto.Visible = False
            Panel13Oro.Visible = False
            Panel13Retiro.Visible = False
            Panel13Abono.Visible = True
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT * FROM abono WHERE fecha_abono = @fecha"
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now.Date)
                Dim ultimoarqueo As Date = ArqueoTableAdapter.ULTIMO_ARQUEO()
                COMANDO.Parameters.AddWithValue("@UltimoArqueo", ultimoarqueo)
                Dim Adapter As New OleDbDataAdapter(COMANDO)
                Dim dt As New DataTable
                Adapter.Fill(dt)
                DGVabono.DataSource = dt
                CONEXION.Close()
                LabelNabono.Text = dt.Rows.Count
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        If (CheckedListBox1.GetItemChecked(2)) Then
            Label42.Text = "Ventas"
            Panel13Empeño.Visible = False
            Panel13Gasto.Visible = False
            Panel13Oro.Visible = False
            Panel13Retiro.Visible = False
            Panel13Abono.Visible = False
            Panel13Ventas.Visible = True
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT * FROM venta WHERE fecha = @fecha"
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now.Date)
                Dim ultimoarqueo As Date = ArqueoTableAdapter.ULTIMO_ARQUEO()
                COMANDO.Parameters.AddWithValue("@UltimoArqueo", ultimoarqueo)
                Dim Adapter As New OleDbDataAdapter(COMANDO)
                Dim dt As New DataTable
                Adapter.Fill(dt)
                DGVVenta.DataSource = dt
                CONEXION.Close()
                LabelNventas.Text = dt.Rows.Count
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        If (CheckedListBox1.GetItemChecked(3)) Then
            Label42.Text = "Empeños"
            Panel13Gasto.Visible = False
            Panel13Oro.Visible = False
            Panel13Retiro.Visible = False
            Panel13Abono.Visible = False
            Panel13Ventas.Visible = False
            Panel13Empeño.Visible = True
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT * FROM empeño WHERE fecha_llegada = @fecha"
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now.Date)
                Dim ultimoarqueo As Date = ArqueoTableAdapter.ULTIMO_ARQUEO()
                COMANDO.Parameters.AddWithValue("@UltimoArqueo", ultimoarqueo)
                Dim Adapter As New OleDbDataAdapter(COMANDO)
                Dim dt As New DataTable
                Adapter.Fill(dt)
                DGVEmp.DataSource = dt
                CONEXION.Close()
                LabelNemp.Text = dt.Rows.Count
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        If (CheckedListBox1.GetItemChecked(4)) Then
            Label42.Text = "Gastos"
            Panel13Ventas.Visible = False
            Panel13Empeño.Visible = False
            Panel13Oro.Visible = False
            Panel13Retiro.Visible = False
            Panel13Abono.Visible = False
            Panel13Gasto.Visible = True
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT * FROM gasto WHERE fecha = @fecha"
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now.Date)
                Dim ultimoarqueo As Date = ArqueoTableAdapter.ULTIMO_ARQUEO()
                COMANDO.Parameters.AddWithValue("@UltimoArqueo", ultimoarqueo)
                Dim Adapter As New OleDbDataAdapter(COMANDO)
                Dim dt As New DataTable
                Adapter.Fill(dt)
                DGVgasto.DataSource = dt
                CONEXION.Close()
                LabelN.Text = dt.Rows.Count
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        If (CheckedListBox1.GetItemChecked(5)) Then
            Label42.Text = "Compras de Oro"
            Panel13Ventas.Visible = False
            Panel13Empeño.Visible = False
            Panel13Gasto.Visible = False
            Panel13Retiro.Visible = False
            Panel13Abono.Visible = False
            Panel13Oro.Visible = True
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT * FROM oro WHERE fecha = @fecha"
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now.Date)
                Dim ultimoarqueo As Date = ArqueoTableAdapter.ULTIMO_ARQUEO()
                COMANDO.Parameters.AddWithValue("@UltimoArqueo", ultimoarqueo)
                Dim Adapter As New OleDbDataAdapter(COMANDO)
                Dim dt As New DataTable
                Adapter.Fill(dt)
                DGVOro.DataSource = dt
                CONEXION.Close()
                LabelNoro.Text = dt.Rows.Count
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        For I As Integer = 0 To CheckedListBox1.Items.Count - 1

            CheckedListBox1.SetItemChecked(I, False)

        Next

    End Sub

    Private Sub DataGridViewProductosDisponibles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProductosDisponibles.CellContentClick

    End Sub

    Private Sub EmpeñoDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles EmpeñoDataGridView.CellContentClick

    End Sub

    Private Sub TabPage4_Click(sender As Object, e As EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        If (Panel13.Visible = True) Then
            Panel13.Visible = False
        Else
            Panel13.Visible = True
            Dim comando As New OleDb.OleDbCommand
            Dim adaptador As New OleDb.OleDbDataAdapter
            Dim registro As New DataSet
            Dim i As Integer = 0
            Dim consulta As String
            Dim lista As Integer
            Dim EmpeñomesActual As Integer = 0
            Dim InteresMesActual As Integer = 0
            Dim retiroMesActual As Integer = 0
            Dim OroMesActual As Integer = 0
            Dim GastoMesActual As Integer = 0
            Dim VentaMesActual As Integer = 0
            Dim EmpeñomesAnterior As Integer = 0
            Dim InteresMesAnterior As Integer = 100000
            Dim retiroMesAnterior As Integer = 0
            Dim OroMesAnterior As Integer = 0
            Dim GastoMesAnterior As Integer = 0
            Dim VentaMesAnterior As Integer = 0
            consulta = "SELECT * FROM empeño WHERE YEAR(fecha_llegada) = '" & Now.Year & "' and MONTH(fecha_llegada)='" & Now.Month & "'"
            adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
            registro = New DataSet
            adaptador.Fill(registro, "TuTabla2")
            lista = registro.Tables("TuTabla2").Rows.Count
            If lista <> 0 Then

                While i < lista
                    EmpeñomesActual += registro.Tables("TuTabla2").Rows(i).Item("valor_empeño")
                    i += 1
                End While
            End If
            consulta = "SELECT * FROM empeño WHERE YEAR(fecha_llegada) = '" & Now.Year & "' and MONTH(fecha_llegada)='" & Now.Month - 1 & "'"
            adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
            registro = New DataSet
            adaptador.Fill(registro, "TuTabla2")
            lista = registro.Tables("TuTabla2").Rows.Count
            If lista <> 0 Then

                While i < lista
                    EmpeñomesAnterior += registro.Tables("TuTabla2").Rows(i).Item("valor_empeño")
                    i += 1
                End While
            End If
            '----'
            consulta = "SELECT * FROM abono WHERE YEAR(fecha_abono) = '" & Now.Year & "' and MONTH(fecha_abono)='" & Now.Month & "'"
            adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
            registro = New DataSet
            adaptador.Fill(registro, "TuTabla2")
            lista = registro.Tables("TuTabla2").Rows.Count
            If lista <> 0 Then

                While i < lista
                    InteresMesActual += registro.Tables("TuTabla2").Rows(i).Item("valor_abono")
                    i += 1
                End While
            End If
            consulta = "SELECT * FROM abono WHERE YEAR(fecha_abono) = '" & Now.Year & "' and MONTH(fecha_abono) = '" & Now.Month - 1 & "'"
            adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
            registro = New DataSet
            adaptador.Fill(registro, "TuTabla2")
            lista = registro.Tables("TuTabla2").Rows.Count
            If lista <> 0 Then

                While i < lista
                    InteresMesAnterior += registro.Tables("TuTabla2").Rows(i).Item("valor_abono")
                    i += 1
                End While
            End If


            Me.GraficoReporteMes.Series("MesActual").Points.Clear()
            Me.GraficoReporteMes.Series("MesAnterior").Points.Clear()
            Me.GraficoReporteMes.Series("MesActual").Points.AddXY("Empeños", EmpeñomesActual)
            Me.GraficoReporteMes.Series("MesAnterior").Points.AddXY("Empeños", EmpeñomesAnterior)
            Me.GraficoReporteMes.Series("MesActual").Points.AddXY("Intereses", InteresMesActual)
            Me.GraficoReporteMes.Series("MesAnterior").Points.AddXY("Intereses", InteresMesAnterior)
            Me.GraficoReporteMes.Series("MesActual").Points.AddXY("Retiro", retiroMesActual)
            Me.GraficoReporteMes.Series("MesAnterior").Points.AddXY("Retiro", retiroMesAnterior)
            Me.GraficoReporteMes.Series("MesActual").Points.AddXY("venta", VentaMesActual)
            Me.GraficoReporteMes.Series("MesAnterior").Points.AddXY("venta", VentaMesAnterior)
            Me.GraficoReporteMes.Series("MesActual").Points.AddXY("Oro", OroMesActual)
            Me.GraficoReporteMes.Series("MesAnterior").Points.AddXY("Oro", OroMesAnterior)
            Me.GraficoReporteMes.Series("MesActual").Points.AddXY("Gasto", GastoMesActual)
            Me.GraficoReporteMes.Series("MesAnterior").Points.AddXY("Gasto", GastoMesAnterior)
        End If
    End Sub

    Private Sub BunifuCards1_Paint(sender As Object, e As PaintEventArgs) Handles BunifuCards1.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBoxMeses.SelectedIndexChanged
        Label96.Text = ComboBoxMeses.SelectedIndex + 1
        txtAñoBalance.Text = Now.Year
    End Sub

    Private Sub BunifuCustomTextbox1_TextChanged(sender As Object, e As EventArgs) Handles txtAñoBalance.TextChanged

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Try

            'MsgBox(EmpeñoTableAdapter.SumaEmpeñosAño(Label96.Text, txtAñoBalance.Text))
            Dim emp As Double = 0
            Dim abonos As Double = 0
            Dim ventass As Double = 0
            Dim gasto As Double = 0
            Dim oro As Double = 0
            Dim egr As Double = 0
            Dim ingr As Double = 0
            'emp = EmpeñoTableAdapter.SumaEmpeñosAño(txtAñoBalance.Text, Label96.Text)
            If (IsDBNull(EmpeñoTableAdapter.SumaEmpeñosAño(txtAñoBalance.Text, Label96.Text)) = True Or IsNothing(EmpeñoTableAdapter.SumaEmpeñosAño(txtAñoBalance.Text, Label96.Text)) = True) Then
                emp = 0
            Else
                emp = EmpeñoTableAdapter.SumaEmpeñosAño(txtAñoBalance.Text, Label96.Text)
            End If
            DataGridViewBalance.Rows(0).Cells(0).Value = emp.ToString("C")
            'abonos = AbonoTableAdapter.SumaAbonoAño(txtAñoBalance.Text, Label96.Text)
            If (IsDBNull(AbonoTableAdapter.SumaAbonoAño(txtAñoBalance.Text, Label96.Text)) = True Or IsNothing(AbonoTableAdapter.SumaAbonoAño(txtAñoBalance.Text, Label96.Text)) = True) Then
                abonos = 0
            Else
                abonos = AbonoTableAdapter.SumaAbonoAño(txtAñoBalance.Text, Label96.Text)
            End If
            DataGridViewBalance.Rows(0).Cells(1).Value = abonos.ToString("C")
            ' venta = VentaTableAdapter.SumaVentaAño(txtAñoBalance.Text, Label96.Text)
            If (IsDBNull(VentaTableAdapter.SumaVentaAño(txtAñoBalance.Text, Label96.Text)) = True Or IsNothing(VentaTableAdapter.SumaVentaAño(txtAñoBalance.Text, Label96.Text)) = True) Then
                ventass = 0
            Else
                ventass = VentaTableAdapter.SumaVentaAño(txtAñoBalance.Text, Label96.Text)
            End If
            DataGridViewBalance.Rows(0).Cells(2).Value = ventass.ToString("C")
            'gasto = GastoTableAdapter.SumaGastoAño(txtAñoBalance.Text, Label96.Text)
            If (IsDBNull(GastoTableAdapter.SumaGastoAño(txtAñoBalance.Text, Label96.Text)) = True Or IsNothing(GastoTableAdapter.SumaGastoAño(txtAñoBalance.Text, Label96.Text)) = True) Then
                gasto = 0
            Else
                gasto = GastoTableAdapter.SumaGastoAño(txtAñoBalance.Text, Label96.Text)
            End If
            DataGridViewBalance.Rows(0).Cells(3).Value = gasto.ToString("C")
            'oro = OroTableAdapter.SumaOroAño(txtAñoBalance.Text, Label96.Text)
            If (IsDBNull(OroTableAdapter.SumaOroAño(txtAñoBalance.Text, Label96.Text)) = True Or IsNothing(OroTableAdapter.SumaOroAño(txtAñoBalance.Text, Label96.Text)) = True) Then
                oro = 0
            Else
                oro = OroTableAdapter.SumaOroAño(txtAñoBalance.Text, Label96.Text)
            End If
            DataGridViewBalance.Rows(0).Cells(4).Value = oro.ToString("C")

            Dim interesestotal As Double = 0
            Dim interesNoPagos As Double = 0
            If (IsDBNull(EmpeñoTableAdapter.SumaInteresesMesAño(txtAñoBalance.Text, Label96.Text)) = True Or IsNothing(EmpeñoTableAdapter.SumaInteresesMesAño(txtAñoBalance.Text, Label96.Text)) = True) Then
                interesestotal = 0
            Else
                interesestotal = EmpeñoTableAdapter.SumaInteresesMesAño(txtAñoBalance.Text, Label96.Text)
            End If

            interesNoPagos = interesestotal - abonos
            DataGridViewBalance.Rows(0).Cells(5).Value = interesNoPagos.ToString("C")

            egr = emp + gasto + oro
            ingr = abonos + ventass
            Dim ganancias As Double = ingr - egr
            DataGridViewBalance.Rows(0).Cells(6).Value = ganancias.ToString("C")
        Catch ex As Exception

        End Try
    End Sub
End Class