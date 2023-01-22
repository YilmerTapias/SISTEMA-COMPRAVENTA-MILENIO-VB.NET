<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim Valor_empeñoLabel As System.Windows.Forms.Label
        Dim Fecha_llegadaLabel As System.Windows.Forms.Label
        Dim Fecha_salidaLabel As System.Windows.Forms.Label
        Dim Dia_empeñoLabel As System.Windows.Forms.Label
        Dim InteresLabel As System.Windows.Forms.Label
        Dim Valor_totalLabel As System.Windows.Forms.Label
        Dim Estado_productoLabel As System.Windows.Forms.Label
        Dim Cedula_clienteLabel As System.Windows.Forms.Label
        Dim Id_productoLabel As System.Windows.Forms.Label
        Dim TipoLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim PesoLabel As System.Windows.Forms.Label
        Dim ValorLabel As System.Windows.Forms.Label
        Dim Codigo_empeñoLabel1 As System.Windows.Forms.Label
        Dim Estado_productoLabel1 As System.Windows.Forms.Label
        Dim Cedula_clienteLabel1 As System.Windows.Forms.Label
        Dim Lugar_expedicionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim CorreoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.TabControlPrincipal = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBoxApellidoVale = New System.Windows.Forms.TextBox()
        Me.TextBoxCorreoVale = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBoxValorTotalVale = New System.Windows.Forms.TextBox()
        Me.TextBoxInteresVale = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.FechaSalidaVale = New System.Windows.Forms.DateTimePicker()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ListViewProductos = New System.Windows.Forms.ListView()
        Me.ColumnTipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnPeso = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnPrecio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnDescripcion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TextBoxTelVale = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TextBoxResideVale = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TextBoxExpedidaVale = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBoxCCVale = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBoxNombreVale = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBoxPrecioEntregado = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.FechaIniVale = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TextBoxCodigoVale = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.ComboBox123 = New System.Windows.Forms.ComboBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.EmpeñoDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ButtonModificarEmpeño = New System.Windows.Forms.Button()
        Me.Cedula_clienteTextBox = New System.Windows.Forms.TextBox()
        Me.Estado_productoTextBox = New System.Windows.Forms.TextBox()
        Me.Valor_totalTextBox = New System.Windows.Forms.TextBox()
        Me.InteresTextBox = New System.Windows.Forms.TextBox()
        Me.Dia_empeñoTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_salidaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Fecha_llegadaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Valor_empeñoTextBox = New System.Windows.Forms.TextBox()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBoxActualizar = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxModificar = New System.Windows.Forms.PictureBox()
        Me.TabPageDesempeños = New System.Windows.Forms.TabPage()
        Me.RetiroDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelAviso = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.TextBoxDescuento = New System.Windows.Forms.TextBox()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label73 = New System.Windows.Forms.Label()
        Me.Label75 = New System.Windows.Forms.Label()
        Me.LabelCedDes = New System.Windows.Forms.Label()
        Me.LabelTotalDes = New System.Windows.Forms.Label()
        Me.LabelDeudaDes = New System.Windows.Forms.Label()
        Me.TextBoxBuscarDesempeño = New System.Windows.Forms.TextBox()
        Me.ButtonDesempeñar = New System.Windows.Forms.Button()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label74 = New System.Windows.Forms.Label()
        Me.TabPageIntereses = New System.Windows.Forms.TabPage()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel8Buscar = New System.Windows.Forms.Panel()
        Me.LabelNumEmpeños = New System.Windows.Forms.Label()
        Me.DataGridViewResultadoAb = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripTextBoxDato = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.Panel7Abono = New System.Windows.Forms.Panel()
        Me.LabelNombreInt = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.LabelMesesFaltantes = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.LabelCorreo = New System.Windows.Forms.Label()
        Me.LabelPrecioPagar2 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.LabelMontoEmpeño = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.LabelMesesPagados = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.LabelUltimoAbono = New System.Windows.Forms.Label()
        Me.LabelFechaEmp = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LabelPrecioApagar = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.TextBoxMesesPagar = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TextBoxInfoEmp = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TabPageOro = New System.Windows.Forms.TabPage()
        Me.OroDataGridView = New System.Windows.Forms.DataGridView()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox15 = New System.Windows.Forms.PictureBox()
        Me.TextBoxGramosOro = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.ButtonCompraOro = New System.Windows.Forms.Button()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.TextBoxPrecioCompra = New System.Windows.Forms.TextBox()
        Me.TabPageGastos = New System.Windows.Forms.TabPage()
        Me.Label85 = New System.Windows.Forms.Label()
        Me.GastoDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.RichTextBoxGastoDescripcion = New System.Windows.Forms.RichTextBox()
        Me.Label83 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBoxAñadirGasto = New System.Windows.Forms.TextBox()
        Me.Label81 = New System.Windows.Forms.Label()
        Me.Label86 = New System.Windows.Forms.Label()
        Me.TabPageVentas = New System.Windows.Forms.TabPage()
        Me.DataGridViewProductosDisponibles = New System.Windows.Forms.DataGridView()
        Me.Vender = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ButtonListarProductos = New System.Windows.Forms.Button()
        Me.TabPageArqueo = New System.Windows.Forms.TabPage()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.GraficoReporteMes = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label95 = New System.Windows.Forms.Label()
        Me.Label93 = New System.Windows.Forms.Label()
        Me.Label88 = New System.Windows.Forms.Label()
        Me.Label89 = New System.Windows.Forms.Label()
        Me.Label90 = New System.Windows.Forms.Label()
        Me.Label91 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Label92 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label87 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.PanelDetallesArq = New System.Windows.Forms.Panel()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Panel13Oro = New System.Windows.Forms.Panel()
        Me.DGVOro = New System.Windows.Forms.DataGridView()
        Me.LabelNoro = New System.Windows.Forms.Label()
        Me.Panel13Gasto = New System.Windows.Forms.Panel()
        Me.LabelN = New System.Windows.Forms.Label()
        Me.DGVgasto = New System.Windows.Forms.DataGridView()
        Me.Panel13Abono = New System.Windows.Forms.Panel()
        Me.LabelNabono = New System.Windows.Forms.Label()
        Me.DGVabono = New System.Windows.Forms.DataGridView()
        Me.Panel13Retiro = New System.Windows.Forms.Panel()
        Me.DGVretiro = New System.Windows.Forms.DataGridView()
        Me.LabelNretiro = New System.Windows.Forms.Label()
        Me.Panel13Empeño = New System.Windows.Forms.Panel()
        Me.LabelNemp = New System.Windows.Forms.Label()
        Me.DGVEmp = New System.Windows.Forms.DataGridView()
        Me.Panel13Ventas = New System.Windows.Forms.Panel()
        Me.LabelNventas = New System.Windows.Forms.Label()
        Me.DGVVenta = New System.Windows.Forms.DataGridView()
        Me.LabelFechaUltimoArq = New System.Windows.Forms.Label()
        Me.LabelSaldoUltimoArq = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.LabelNumeroAbonos = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        Me.LabelNumeroOro = New System.Windows.Forms.Label()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.PictureBox16 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxArqueo = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.LabelNumeroEmpeños = New System.Windows.Forms.Label()
        Me.Label77 = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.LabelNumeroVentas = New System.Windows.Forms.Label()
        Me.PanelArqueo = New System.Windows.Forms.Panel()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox13 = New System.Windows.Forms.PictureBox()
        Me.LabelNumeroRetiros = New System.Windows.Forms.Label()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.Label84 = New System.Windows.Forms.Label()
        Me.LabelNumeroGastos = New System.Windows.Forms.Label()
        Me.ButtonRealizarArqueo = New System.Windows.Forms.Button()
        Me.PictureBox14 = New System.Windows.Forms.PictureBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.TextBoxFaltantes = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.TextBoxPrestamos = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.TextBoxSaldoReal = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.TextBoxGastos = New System.Windows.Forms.TextBox()
        Me.TextBoxEmpeño = New System.Windows.Forms.TextBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.TextBoxCompraOro = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.TextBoxVentas = New System.Windows.Forms.TextBox()
        Me.TextBoxDesempeños = New System.Windows.Forms.TextBox()
        Me.TextBoxOtroIngreso = New System.Windows.Forms.TextBox()
        Me.TextBoxSobrantes = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.TextBoxTotalArqueo = New System.Windows.Forms.TextBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.TextBoxInteresesPagos = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TextBoxSaldoEnCaja = New System.Windows.Forms.TextBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.LabelFechaActual = New System.Windows.Forms.Label()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.TabPageEmpeños = New System.Windows.Forms.TabPage()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Panel1Agregar = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxCodigoEmp = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxValor = New System.Windows.Forms.TextBox()
        Me.TextBoxPeso = New System.Windows.Forms.TextBox()
        Me.TextBoxDescripcion = New System.Windows.Forms.TextBox()
        Me.TextBoxTipoProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnInsertarProducto = New System.Windows.Forms.Button()
        Me.TextBoxIdProducto = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Panel1ModificarProducto = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Estado_productoTextBox1 = New System.Windows.Forms.TextBox()
        Me.Codigo_empeñoTextBox1 = New System.Windows.Forms.TextBox()
        Me.ValorTextBox = New System.Windows.Forms.TextBox()
        Me.PesoTextBox = New System.Windows.Forms.TextBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.TipoTextBox = New System.Windows.Forms.TextBox()
        Me.Id_productoTextBox = New System.Windows.Forms.TextBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBoxBuscarProd = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.PictureModificarProducto = New System.Windows.Forms.PictureBox()
        Me.PictureAgregarProducto = New System.Windows.Forms.PictureBox()
        Me.TabPageClientes = New System.Windows.Forms.TabPage()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.CorreoTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.Lugar_expedicionTextBox = New System.Windows.Forms.TextBox()
        Me.Cedula_clienteTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.btnAgregarCliente = New System.Windows.Forms.Button()
        Me.TabPageNotificaciones = New System.Windows.Forms.TabPage()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.RichTextBoxMessage = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.TabPageBalances = New System.Windows.Forms.TabPage()
        Me.BunifuCards2 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtAñoBalance = New Bunifu.Framework.BunifuCustomTextbox()
        Me.BunifuFlatButton2 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ComboBoxMeses = New System.Windows.Forms.ComboBox()
        Me.StatusStripEstado = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuDlesplegable = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimePickerActual = New System.Windows.Forms.DateTimePicker()
        Me.Labelhora = New System.Windows.Forms.Label()
        Me.LabelFecha2 = New System.Windows.Forms.Label()
        Me.Hora = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProductoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label96 = New System.Windows.Forms.Label()
        Me.DataGridViewBalance = New System.Windows.Forms.DataGridView()
        Me.Empeños1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Abonos1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ventas1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gastos1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Oro1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InteresesNoPagos1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ganancias1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpeñoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDMIDataSet = New MILENIO.BDMIDataSet()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetiroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GastoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbonoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoTableAdapter = New MILENIO.BDMIDataSetTableAdapters.productoTableAdapter()
        Me.TableAdapterManager = New MILENIO.BDMIDataSetTableAdapters.TableAdapterManager()
        Me.EmpeñoTableAdapter = New MILENIO.BDMIDataSetTableAdapters.empeñoTableAdapter()
        Me.ClientesTableAdapter = New MILENIO.BDMIDataSetTableAdapters.clientesTableAdapter()
        Me.AbonoTableAdapter = New MILENIO.BDMIDataSetTableAdapters.abonoTableAdapter()
        Me.EmpeñoTableAdapter1 = New MILENIO.BDMIDataSetTableAdapters.empeñoTableAdapter()
        Me.EmpeñoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.OroTableAdapter = New MILENIO.BDMIDataSetTableAdapters.OroTableAdapter()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentaTableAdapter = New MILENIO.BDMIDataSetTableAdapters.ventaTableAdapter()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New MILENIO.BDMIDataSetTableAdapters.usuariosTableAdapter()
        Me.ArqueoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArqueoTableAdapter = New MILENIO.BDMIDataSetTableAdapters.arqueoTableAdapter()
        Me.MensajesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MensajesTableAdapter = New MILENIO.BDMIDataSetTableAdapters.mensajesTableAdapter()
        Me.RetiroTableAdapter = New MILENIO.BDMIDataSetTableAdapters.retiroTableAdapter()
        Me.GastoTableAdapter = New MILENIO.BDMIDataSetTableAdapters.gastoTableAdapter()
        Me.MovimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MovimientosTableAdapter = New MILENIO.BDMIDataSetTableAdapters.movimientosTableAdapter()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.Label98 = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        Valor_empeñoLabel = New System.Windows.Forms.Label()
        Fecha_llegadaLabel = New System.Windows.Forms.Label()
        Fecha_salidaLabel = New System.Windows.Forms.Label()
        Dia_empeñoLabel = New System.Windows.Forms.Label()
        InteresLabel = New System.Windows.Forms.Label()
        Valor_totalLabel = New System.Windows.Forms.Label()
        Estado_productoLabel = New System.Windows.Forms.Label()
        Cedula_clienteLabel = New System.Windows.Forms.Label()
        Id_productoLabel = New System.Windows.Forms.Label()
        TipoLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        PesoLabel = New System.Windows.Forms.Label()
        ValorLabel = New System.Windows.Forms.Label()
        Codigo_empeñoLabel1 = New System.Windows.Forms.Label()
        Estado_productoLabel1 = New System.Windows.Forms.Label()
        Cedula_clienteLabel1 = New System.Windows.Forms.Label()
        Lugar_expedicionLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        CorreoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        Me.TabControlPrincipal.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.EmpeñoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxActualizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxModificar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageDesempeños.SuspendLayout()
        CType(Me.RetiroDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.TabPageIntereses.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8Buscar.SuspendLayout()
        CType(Me.DataGridViewResultadoAb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel7Abono.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPageOro.SuspendLayout()
        CType(Me.OroDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageGastos.SuspendLayout()
        CType(Me.GastoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel12.SuspendLayout()
        Me.TabPageVentas.SuspendLayout()
        CType(Me.DataGridViewProductosDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageArqueo.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.GraficoReporteMes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.PanelDetallesArq.SuspendLayout()
        Me.Panel13Oro.SuspendLayout()
        CType(Me.DGVOro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13Gasto.SuspendLayout()
        CType(Me.DGVgasto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13Abono.SuspendLayout()
        CType(Me.DGVabono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13Retiro.SuspendLayout()
        CType(Me.DGVretiro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13Empeño.SuspendLayout()
        CType(Me.DGVEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel13Ventas.SuspendLayout()
        CType(Me.DGVVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxArqueo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelArqueo.SuspendLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageEmpeños.SuspendLayout()
        Me.Panel1Agregar.SuspendLayout()
        Me.Panel1ModificarProducto.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureModificarProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureAgregarProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageClientes.SuspendLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageNotificaciones.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageBalances.SuspendLayout()
        Me.BunifuCards2.SuspendLayout()
        Me.BunifuCards1.SuspendLayout()
        Me.StatusStripEstado.SuspendLayout()
        Me.MenuDlesplegable.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpeñoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDMIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetiroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GastoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbonoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpeñoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArqueoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MensajesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodigoLabel.Location = New System.Drawing.Point(59, 38)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(47, 15)
        CodigoLabel.TabIndex = 0
        CodigoLabel.Text = "codigo:"
        '
        'Valor_empeñoLabel
        '
        Valor_empeñoLabel.AutoSize = True
        Valor_empeñoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Valor_empeñoLabel.Location = New System.Drawing.Point(25, 100)
        Valor_empeñoLabel.Name = "Valor_empeñoLabel"
        Valor_empeñoLabel.Size = New System.Drawing.Size(85, 15)
        Valor_empeñoLabel.TabIndex = 2
        Valor_empeñoLabel.Text = "valor empeño:"
        '
        'Fecha_llegadaLabel
        '
        Fecha_llegadaLabel.AutoSize = True
        Fecha_llegadaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_llegadaLabel.Location = New System.Drawing.Point(26, 158)
        Fecha_llegadaLabel.Name = "Fecha_llegadaLabel"
        Fecha_llegadaLabel.Size = New System.Drawing.Size(84, 15)
        Fecha_llegadaLabel.TabIndex = 4
        Fecha_llegadaLabel.Text = "fecha llegada:"
        '
        'Fecha_salidaLabel
        '
        Fecha_salidaLabel.AutoSize = True
        Fecha_salidaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Fecha_salidaLabel.Location = New System.Drawing.Point(34, 213)
        Fecha_salidaLabel.Name = "Fecha_salidaLabel"
        Fecha_salidaLabel.Size = New System.Drawing.Size(76, 15)
        Fecha_salidaLabel.TabIndex = 6
        Fecha_salidaLabel.Text = "fecha salida:"
        '
        'Dia_empeñoLabel
        '
        Dia_empeñoLabel.AutoSize = True
        Dia_empeñoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Dia_empeñoLabel.Location = New System.Drawing.Point(34, 72)
        Dia_empeñoLabel.Name = "Dia_empeñoLabel"
        Dia_empeñoLabel.Size = New System.Drawing.Size(76, 15)
        Dia_empeñoLabel.TabIndex = 8
        Dia_empeñoLabel.Text = "dia empeño:"
        '
        'InteresLabel
        '
        InteresLabel.AutoSize = True
        InteresLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        InteresLabel.Location = New System.Drawing.Point(60, 130)
        InteresLabel.Name = "InteresLabel"
        InteresLabel.Size = New System.Drawing.Size(47, 15)
        InteresLabel.TabIndex = 10
        InteresLabel.Text = "interes:"
        '
        'Valor_totalLabel
        '
        Valor_totalLabel.AutoSize = True
        Valor_totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Valor_totalLabel.Location = New System.Drawing.Point(47, 187)
        Valor_totalLabel.Name = "Valor_totalLabel"
        Valor_totalLabel.Size = New System.Drawing.Size(62, 15)
        Valor_totalLabel.TabIndex = 12
        Valor_totalLabel.Text = "valor total:"
        '
        'Estado_productoLabel
        '
        Estado_productoLabel.AutoSize = True
        Estado_productoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Estado_productoLabel.Location = New System.Drawing.Point(12, 239)
        Estado_productoLabel.Name = "Estado_productoLabel"
        Estado_productoLabel.Size = New System.Drawing.Size(98, 15)
        Estado_productoLabel.TabIndex = 14
        Estado_productoLabel.Text = "estado producto:"
        '
        'Cedula_clienteLabel
        '
        Cedula_clienteLabel.AutoSize = True
        Cedula_clienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cedula_clienteLabel.Location = New System.Drawing.Point(23, 265)
        Cedula_clienteLabel.Name = "Cedula_clienteLabel"
        Cedula_clienteLabel.Size = New System.Drawing.Size(86, 15)
        Cedula_clienteLabel.TabIndex = 16
        Cedula_clienteLabel.Text = "cedula cliente:"
        '
        'Id_productoLabel
        '
        Id_productoLabel.AutoSize = True
        Id_productoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Id_productoLabel.Location = New System.Drawing.Point(161, 41)
        Id_productoLabel.Name = "Id_productoLabel"
        Id_productoLabel.Size = New System.Drawing.Size(78, 16)
        Id_productoLabel.TabIndex = 0
        Id_productoLabel.Text = "id producto:"
        '
        'TipoLabel
        '
        TipoLabel.AutoSize = True
        TipoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TipoLabel.Location = New System.Drawing.Point(355, 41)
        TipoLabel.Name = "TipoLabel"
        TipoLabel.Size = New System.Drawing.Size(39, 16)
        TipoLabel.TabIndex = 2
        TipoLabel.Text = "Tipo:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescripcionLabel.Location = New System.Drawing.Point(515, 41)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(81, 16)
        DescripcionLabel.TabIndex = 4
        DescripcionLabel.Text = "descripcion:"
        '
        'PesoLabel
        '
        PesoLabel.AutoSize = True
        PesoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PesoLabel.Location = New System.Drawing.Point(712, 41)
        PesoLabel.Name = "PesoLabel"
        PesoLabel.Size = New System.Drawing.Size(42, 16)
        PesoLabel.TabIndex = 6
        PesoLabel.Text = "peso:"
        '
        'ValorLabel
        '
        ValorLabel.AutoSize = True
        ValorLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ValorLabel.Location = New System.Drawing.Point(651, 96)
        ValorLabel.Name = "ValorLabel"
        ValorLabel.Size = New System.Drawing.Size(41, 16)
        ValorLabel.TabIndex = 8
        ValorLabel.Text = "valor:"
        '
        'Codigo_empeñoLabel1
        '
        Codigo_empeñoLabel1.AutoSize = True
        Codigo_empeñoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Codigo_empeñoLabel1.Location = New System.Drawing.Point(152, 95)
        Codigo_empeñoLabel1.Name = "Codigo_empeñoLabel1"
        Codigo_empeñoLabel1.Size = New System.Drawing.Size(106, 16)
        Codigo_empeñoLabel1.TabIndex = 10
        Codigo_empeñoLabel1.Text = "codigo empeño:"
        '
        'Estado_productoLabel1
        '
        Estado_productoLabel1.AutoSize = True
        Estado_productoLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Estado_productoLabel1.Location = New System.Drawing.Point(393, 95)
        Estado_productoLabel1.Name = "Estado_productoLabel1"
        Estado_productoLabel1.Size = New System.Drawing.Size(109, 16)
        Estado_productoLabel1.TabIndex = 12
        Estado_productoLabel1.Text = "estado producto:"
        '
        'Cedula_clienteLabel1
        '
        Cedula_clienteLabel1.AutoSize = True
        Cedula_clienteLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cedula_clienteLabel1.Location = New System.Drawing.Point(814, 152)
        Cedula_clienteLabel1.Name = "Cedula_clienteLabel1"
        Cedula_clienteLabel1.Size = New System.Drawing.Size(101, 18)
        Cedula_clienteLabel1.TabIndex = 3
        Cedula_clienteLabel1.Text = "cedula cliente:"
        '
        'Lugar_expedicionLabel
        '
        Lugar_expedicionLabel.AutoSize = True
        Lugar_expedicionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Lugar_expedicionLabel.Location = New System.Drawing.Point(801, 189)
        Lugar_expedicionLabel.Name = "Lugar_expedicionLabel"
        Lugar_expedicionLabel.Size = New System.Drawing.Size(118, 18)
        Lugar_expedicionLabel.TabIndex = 5
        Lugar_expedicionLabel.Text = "lugar expedicion:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefonoLabel.Location = New System.Drawing.Point(840, 224)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(65, 18)
        TelefonoLabel.TabIndex = 7
        TelefonoLabel.Text = "telefono:"
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DireccionLabel.Location = New System.Drawing.Point(835, 262)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(72, 18)
        DireccionLabel.TabIndex = 9
        DireccionLabel.Text = "direccion:"
        '
        'CorreoLabel
        '
        CorreoLabel.AutoSize = True
        CorreoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CorreoLabel.Location = New System.Drawing.Point(848, 301)
        CorreoLabel.Name = "CorreoLabel"
        CorreoLabel.Size = New System.Drawing.Size(56, 18)
        CorreoLabel.TabIndex = 11
        CorreoLabel.Text = "correo:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NombreLabel.Location = New System.Drawing.Point(843, 340)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(63, 18)
        NombreLabel.TabIndex = 13
        NombreLabel.Text = "nombre:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ApellidosLabel.Location = New System.Drawing.Point(837, 381)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(70, 18)
        ApellidosLabel.TabIndex = 15
        ApellidosLabel.Text = "apellidos:"
        '
        'TabControlPrincipal
        '
        Me.TabControlPrincipal.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControlPrincipal.Controls.Add(Me.TabPage5)
        Me.TabControlPrincipal.Controls.Add(Me.TabPage4)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageDesempeños)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageIntereses)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageOro)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageGastos)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageVentas)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageArqueo)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageEmpeños)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageClientes)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageNotificaciones)
        Me.TabControlPrincipal.Controls.Add(Me.TabPageBalances)
        Me.TabControlPrincipal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlPrincipal.Location = New System.Drawing.Point(3, 82)
        Me.TabControlPrincipal.Name = "TabControlPrincipal"
        Me.TabControlPrincipal.SelectedIndex = 0
        Me.TabControlPrincipal.Size = New System.Drawing.Size(1340, 613)
        Me.TabControlPrincipal.TabIndex = 3
        Me.TabControlPrincipal.Tag = ""
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TabPage5.Controls.Add(Me.Panel5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 28)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(1332, 581)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "NUEVO EMPEÑO"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Khaki
        Me.Panel5.Controls.Add(Me.Label23)
        Me.Panel5.Controls.Add(Me.Button8)
        Me.Panel5.Controls.Add(Me.Button7)
        Me.Panel5.Controls.Add(Me.TextBoxApellidoVale)
        Me.Panel5.Controls.Add(Me.TextBoxCorreoVale)
        Me.Panel5.Controls.Add(Me.Label29)
        Me.Panel5.Controls.Add(Me.GroupBox2)
        Me.Panel5.Controls.Add(Me.GroupBox1)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Controls.Add(Me.TextBoxTelVale)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.TextBoxResideVale)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.TextBoxExpedidaVale)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.TextBoxCCVale)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.TextBoxNombreVale)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.TextBoxPrecioEntregado)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.FechaIniVale)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.TextBoxCodigoVale)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Location = New System.Drawing.Point(219, 18)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(806, 580)
        Me.Panel5.TabIndex = 0
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(66, 38)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 16)
        Me.Label23.TabIndex = 27
        Me.Label23.Text = "CODIGO:"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button8.Location = New System.Drawing.Point(418, 523)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(141, 44)
        Me.Button8.TabIndex = 26
        Me.Button8.Text = "CANCELAR"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button7.Location = New System.Drawing.Point(248, 523)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(141, 44)
        Me.Button7.TabIndex = 25
        Me.Button7.Text = "TODO LISTO"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'TextBoxApellidoVale
        '
        Me.TextBoxApellidoVale.Location = New System.Drawing.Point(226, 187)
        Me.TextBoxApellidoVale.Name = "TextBoxApellidoVale"
        Me.TextBoxApellidoVale.Size = New System.Drawing.Size(119, 22)
        Me.TextBoxApellidoVale.TabIndex = 24
        Me.TextBoxApellidoVale.Tag = "valida"
        Me.TextBoxApellidoVale.Text = "Apellido"
        '
        'TextBoxCorreoVale
        '
        Me.TextBoxCorreoVale.AutoCompleteCustomSource.AddRange(New String() {"@gmail.com", "@hotmail.com"})
        Me.TextBoxCorreoVale.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.TextBoxCorreoVale.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxCorreoVale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCorreoVale.Location = New System.Drawing.Point(226, 258)
        Me.TextBoxCorreoVale.Name = "TextBoxCorreoVale"
        Me.TextBoxCorreoVale.Size = New System.Drawing.Size(231, 22)
        Me.TextBoxCorreoVale.TabIndex = 23
        Me.TextBoxCorreoVale.Tag = ""
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(29, 261)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(191, 16)
        Me.Label29.TabIndex = 22
        Me.Label29.Text = "Correo Electronico (opcional ) : "
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.TextBoxValorTotalVale)
        Me.GroupBox2.Controls.Add(Me.TextBoxInteresVale)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.FechaSalidaVale)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Location = New System.Drawing.Point(418, 327)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(367, 179)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(192, 86)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(128, 16)
        Me.Label28.TabIndex = 27
        Me.Label28.Text = "Valor total Empeño: "
        '
        'TextBoxValorTotalVale
        '
        Me.TextBoxValorTotalVale.Enabled = False
        Me.TextBoxValorTotalVale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxValorTotalVale.Location = New System.Drawing.Point(180, 102)
        Me.TextBoxValorTotalVale.Name = "TextBoxValorTotalVale"
        Me.TextBoxValorTotalVale.Size = New System.Drawing.Size(149, 24)
        Me.TextBoxValorTotalVale.TabIndex = 26
        Me.TextBoxValorTotalVale.Tag = "valida"
        '
        'TextBoxInteresVale
        '
        Me.TextBoxInteresVale.Enabled = False
        Me.TextBoxInteresVale.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxInteresVale.Location = New System.Drawing.Point(31, 102)
        Me.TextBoxInteresVale.Name = "TextBoxInteresVale"
        Me.TextBoxInteresVale.Size = New System.Drawing.Size(110, 24)
        Me.TextBoxInteresVale.TabIndex = 25
        Me.TextBoxInteresVale.Tag = "valida"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(44, 86)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(91, 16)
        Me.Label27.TabIndex = 24
        Me.Label27.Text = "Interes Inicial: "
        '
        'FechaSalidaVale
        '
        Me.FechaSalidaVale.Location = New System.Drawing.Point(129, 43)
        Me.FechaSalidaVale.Name = "FechaSalidaVale"
        Me.FechaSalidaVale.Size = New System.Drawing.Size(200, 22)
        Me.FechaSalidaVale.TabIndex = 23
        Me.FechaSalidaVale.Tag = "valida"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(28, 47)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(91, 16)
        Me.Label26.TabIndex = 22
        Me.Label26.Text = "FechaSalida: "
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.ListViewProductos)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 327)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 179)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(208, 13)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(109, 25)
        Me.Button6.TabIndex = 26
        Me.Button6.Text = "Quitar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ListViewProductos
        '
        Me.ListViewProductos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnTipo, Me.ColumnPeso, Me.ColumnPrecio, Me.ColumnDescripcion})
        Me.ListViewProductos.HideSelection = False
        Me.ListViewProductos.Location = New System.Drawing.Point(1, 43)
        Me.ListViewProductos.Name = "ListViewProductos"
        Me.ListViewProductos.Size = New System.Drawing.Size(370, 130)
        Me.ListViewProductos.TabIndex = 25
        Me.ListViewProductos.UseCompatibleStateImageBehavior = False
        Me.ListViewProductos.View = System.Windows.Forms.View.Details
        '
        'ColumnTipo
        '
        Me.ColumnTipo.Text = "Tipo"
        Me.ColumnTipo.Width = 80
        '
        'ColumnPeso
        '
        Me.ColumnPeso.Text = "Peso (g)"
        Me.ColumnPeso.Width = 80
        '
        'ColumnPrecio
        '
        Me.ColumnPrecio.Tag = "precio aproximado de venta"
        Me.ColumnPrecio.Text = "Precio Venta"
        Me.ColumnPrecio.Width = 100
        '
        'ColumnDescripcion
        '
        Me.ColumnDescripcion.Tag = "Descripcion del producto"
        Me.ColumnDescripcion.Text = "Descripcion"
        Me.ColumnDescripcion.Width = 100
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(86, 13)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(109, 25)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Agregar Producto"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(40, 293)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(735, 32)
        Me.Label22.TabIndex = 19
        Me.Label22.Text = "Expresamente manifiesto que he vendido a la ""COMPRAVENTA EL MILENIO"" con pacto de" &
    " retroventa segun Art.1939 de C.C." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "los siguientes bienes que son de mi propieda" &
    "d."
        '
        'TextBoxTelVale
        '
        Me.TextBoxTelVale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTelVale.Location = New System.Drawing.Point(576, 223)
        Me.TextBoxTelVale.Name = "TextBoxTelVale"
        Me.TextBoxTelVale.Size = New System.Drawing.Size(147, 21)
        Me.TextBoxTelVale.TabIndex = 18
        Me.TextBoxTelVale.Tag = "valida"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(533, 226)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 16)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Tel : "
        '
        'TextBoxResideVale
        '
        Me.TextBoxResideVale.AutoCompleteCustomSource.AddRange(New String() {"San Carlos Córdoba", "Cereté Córdoba", "Montería Córdoba", "Lorica Córdoba", "Medellín Antioquia", "Ayapel Córdoba", "Chinú Córdoba", "Ciénaga de Oro Córdoba", "Cotorra Córdoba", "La Apartada Córdoba", "Planeta Rica Córdoba", "Sahagún Córdoba", "Montelíbano Córdoba", "Bogotá", "Valencia Córdoba", "Caucasia Antioquia", "Tierra alta Córdoba", "San Pelayo Córdoba", "Bijao Córdoba"})
        Me.TextBoxResideVale.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBoxResideVale.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxResideVale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxResideVale.Location = New System.Drawing.Point(368, 223)
        Me.TextBoxResideVale.Name = "TextBoxResideVale"
        Me.TextBoxResideVale.Size = New System.Drawing.Size(147, 21)
        Me.TextBoxResideVale.TabIndex = 16
        Me.TextBoxResideVale.Tag = "valida"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(280, 227)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 16)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "residente en"
        '
        'TextBoxExpedidaVale
        '
        Me.TextBoxExpedidaVale.AutoCompleteCustomSource.AddRange(New String() {"San Carlos Córdoba", "Cereté Córdoba", "Montería Córdoba", "Lorica Córdoba", "Medellín Antioquita", "Ayapel Córdoba", "Chinú Córdoba", "Ciénaga de Oro Córdoba", "Cotorra Córdoba", "La Apartada Córdoba", "Planeta Rica Córdoba", "Sahagún Córdoba", "Montelíbano Córdoba", "Bogotá", "Valencia Córdoba", "Caucasia Antioquia", "Tierra Alta Córdoba", "San Pelayo Córdoba"})
        Me.TextBoxExpedidaVale.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TextBoxExpedidaVale.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TextBoxExpedidaVale.Location = New System.Drawing.Point(119, 224)
        Me.TextBoxExpedidaVale.Name = "TextBoxExpedidaVale"
        Me.TextBoxExpedidaVale.Size = New System.Drawing.Size(149, 22)
        Me.TextBoxExpedidaVale.TabIndex = 14
        Me.TextBoxExpedidaVale.Tag = "valida"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(29, 226)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 16)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Expedida en"
        '
        'TextBoxCCVale
        '
        Me.TextBoxCCVale.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCCVale.Location = New System.Drawing.Point(536, 188)
        Me.TextBoxCCVale.Name = "TextBoxCCVale"
        Me.TextBoxCCVale.Size = New System.Drawing.Size(167, 21)
        Me.TextBoxCCVale.TabIndex = 12
        Me.TextBoxCCVale.Tag = "valida"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(356, 190)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(175, 16)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "con Cédula de ciudadania N°"
        '
        'TextBoxNombreVale
        '
        Me.TextBoxNombreVale.Location = New System.Drawing.Point(98, 187)
        Me.TextBoxNombreVale.Name = "TextBoxNombreVale"
        Me.TextBoxNombreVale.Size = New System.Drawing.Size(122, 22)
        Me.TextBoxNombreVale.TabIndex = 10
        Me.TextBoxNombreVale.Tag = "valida"
        Me.TextBoxNombreVale.Text = "Nombre"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(27, 190)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 16)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Art 1°.  yo,"
        '
        'TextBoxPrecioEntregado
        '
        Me.TextBoxPrecioEntregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrecioEntregado.Location = New System.Drawing.Point(465, 146)
        Me.TextBoxPrecioEntregado.Multiline = True
        Me.TextBoxPrecioEntregado.Name = "TextBoxPrecioEntregado"
        Me.TextBoxPrecioEntregado.Size = New System.Drawing.Size(206, 28)
        Me.TextBoxPrecioEntregado.TabIndex = 8
        Me.TextBoxPrecioEntregado.Tag = "valida"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(420, 154)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 16)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Por : $"
        '
        'FechaIniVale
        '
        Me.FechaIniVale.Location = New System.Drawing.Point(99, 144)
        Me.FechaIniVale.Name = "FechaIniVale"
        Me.FechaIniVale.Size = New System.Drawing.Size(200, 22)
        Me.FechaIniVale.TabIndex = 6
        Me.FechaIniVale.Tag = "valida"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(41, 149)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 16)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Fecha: "
        '
        'TextBoxCodigoVale
        '
        Me.TextBoxCodigoVale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCodigoVale.Location = New System.Drawing.Point(66, 54)
        Me.TextBoxCodigoVale.Multiline = True
        Me.TextBoxCodigoVale.Name = "TextBoxCodigoVale"
        Me.TextBoxCodigoVale.Size = New System.Drawing.Size(169, 34)
        Me.TextBoxCodigoVale.TabIndex = 4
        Me.TextBoxCodigoVale.Tag = "valida"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(421, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(196, 30)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Calle Principal - Cel. 314 803 5473" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dir : San Carlos - Córdoba " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(421, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(262, 15)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Hernando Martinez C.  C.C.6.889.098 Monteria" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(421, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(282, 15)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "contrato de compra - venta con pacto de retroventa"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(421, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(268, 20)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "COMPRA -  VENTA EL MILENIO"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.LemonChiffon
        Me.PictureBox3.Location = New System.Drawing.Point(412, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(300, 136)
        Me.PictureBox3.TabIndex = 28
        Me.PictureBox3.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TabPage4.Controls.Add(Me.ComboBox123)
        Me.TabPage4.Controls.Add(Me.Label68)
        Me.TabPage4.Controls.Add(Me.EmpeñoDataGridView)
        Me.TabPage4.Controls.Add(Me.Label9)
        Me.TabPage4.Controls.Add(Me.TextBoxBuscar)
        Me.TabPage4.Controls.Add(Me.Panel2)
        Me.TabPage4.Controls.Add(Me.PictureBoxActualizar)
        Me.TabPage4.Controls.Add(Me.PictureBox4)
        Me.TabPage4.Controls.Add(Me.PictureBoxModificar)
        Me.TabPage4.Location = New System.Drawing.Point(4, 28)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1332, 581)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "LISTA DE EMPEÑOS"
        '
        'ComboBox123
        '
        Me.ComboBox123.FormattingEnabled = True
        Me.ComboBox123.Items.AddRange(New Object() {"Cedula", "Codigo"})
        Me.ComboBox123.Location = New System.Drawing.Point(167, 17)
        Me.ComboBox123.Name = "ComboBox123"
        Me.ComboBox123.Size = New System.Drawing.Size(60, 24)
        Me.ComboBox123.TabIndex = 12
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(581, 9)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(154, 36)
        Me.Label68.TabIndex = 11
        Me.Label68.Text = "Actualizar Informacion" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Recalcular Intereses"
        '
        'EmpeñoDataGridView
        '
        Me.EmpeñoDataGridView.AutoGenerateColumns = False
        Me.EmpeñoDataGridView.BackgroundColor = System.Drawing.Color.CadetBlue
        Me.EmpeñoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpeñoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn27})
        Me.EmpeñoDataGridView.DataSource = Me.EmpeñoBindingSource
        Me.EmpeñoDataGridView.Location = New System.Drawing.Point(5, 65)
        Me.EmpeñoDataGridView.Name = "EmpeñoDataGridView"
        Me.EmpeñoDataGridView.Size = New System.Drawing.Size(1122, 506)
        Me.EmpeñoDataGridView.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(807, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Modificar campo"
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Location = New System.Drawing.Point(23, 17)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(138, 22)
        Me.TextBoxBuscar.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ButtonModificarEmpeño)
        Me.Panel2.Controls.Add(Cedula_clienteLabel)
        Me.Panel2.Controls.Add(Me.Cedula_clienteTextBox)
        Me.Panel2.Controls.Add(Estado_productoLabel)
        Me.Panel2.Controls.Add(Me.Estado_productoTextBox)
        Me.Panel2.Controls.Add(Valor_totalLabel)
        Me.Panel2.Controls.Add(Me.Valor_totalTextBox)
        Me.Panel2.Controls.Add(InteresLabel)
        Me.Panel2.Controls.Add(Me.InteresTextBox)
        Me.Panel2.Controls.Add(Dia_empeñoLabel)
        Me.Panel2.Controls.Add(Me.Dia_empeñoTextBox)
        Me.Panel2.Controls.Add(Fecha_salidaLabel)
        Me.Panel2.Controls.Add(Me.Fecha_salidaDateTimePicker)
        Me.Panel2.Controls.Add(Fecha_llegadaLabel)
        Me.Panel2.Controls.Add(Me.Fecha_llegadaDateTimePicker)
        Me.Panel2.Controls.Add(Valor_empeñoLabel)
        Me.Panel2.Controls.Add(Me.Valor_empeñoTextBox)
        Me.Panel2.Controls.Add(CodigoLabel)
        Me.Panel2.Controls.Add(Me.CodigoTextBox)
        Me.Panel2.Location = New System.Drawing.Point(1116, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(313, 508)
        Me.Panel2.TabIndex = 4
        '
        'ButtonModificarEmpeño
        '
        Me.ButtonModificarEmpeño.Enabled = False
        Me.ButtonModificarEmpeño.Location = New System.Drawing.Point(81, 327)
        Me.ButtonModificarEmpeño.Name = "ButtonModificarEmpeño"
        Me.ButtonModificarEmpeño.Size = New System.Drawing.Size(100, 38)
        Me.ButtonModificarEmpeño.TabIndex = 18
        Me.ButtonModificarEmpeño.Text = "Modificar"
        Me.ButtonModificarEmpeño.UseVisualStyleBackColor = True
        '
        'Cedula_clienteTextBox
        '
        Me.Cedula_clienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpeñoBindingSource, "cedula_cliente", True))
        Me.Cedula_clienteTextBox.Enabled = False
        Me.Cedula_clienteTextBox.Location = New System.Drawing.Point(110, 263)
        Me.Cedula_clienteTextBox.Name = "Cedula_clienteTextBox"
        Me.Cedula_clienteTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Cedula_clienteTextBox.TabIndex = 17
        '
        'Estado_productoTextBox
        '
        Me.Estado_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpeñoBindingSource, "estado_producto", True))
        Me.Estado_productoTextBox.Enabled = False
        Me.Estado_productoTextBox.Location = New System.Drawing.Point(110, 237)
        Me.Estado_productoTextBox.Name = "Estado_productoTextBox"
        Me.Estado_productoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Estado_productoTextBox.TabIndex = 15
        '
        'Valor_totalTextBox
        '
        Me.Valor_totalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpeñoBindingSource, "valor_total", True))
        Me.Valor_totalTextBox.Enabled = False
        Me.Valor_totalTextBox.Location = New System.Drawing.Point(110, 185)
        Me.Valor_totalTextBox.Name = "Valor_totalTextBox"
        Me.Valor_totalTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Valor_totalTextBox.TabIndex = 13
        '
        'InteresTextBox
        '
        Me.InteresTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpeñoBindingSource, "interes", True))
        Me.InteresTextBox.Enabled = False
        Me.InteresTextBox.Location = New System.Drawing.Point(110, 127)
        Me.InteresTextBox.Name = "InteresTextBox"
        Me.InteresTextBox.Size = New System.Drawing.Size(100, 22)
        Me.InteresTextBox.TabIndex = 11
        '
        'Dia_empeñoTextBox
        '
        Me.Dia_empeñoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpeñoBindingSource, "dia_empeño", True))
        Me.Dia_empeñoTextBox.Enabled = False
        Me.Dia_empeñoTextBox.Location = New System.Drawing.Point(110, 66)
        Me.Dia_empeñoTextBox.Name = "Dia_empeñoTextBox"
        Me.Dia_empeñoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Dia_empeñoTextBox.TabIndex = 9
        '
        'Fecha_salidaDateTimePicker
        '
        Me.Fecha_salidaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpeñoBindingSource, "fecha_salida", True))
        Me.Fecha_salidaDateTimePicker.Enabled = False
        Me.Fecha_salidaDateTimePicker.Location = New System.Drawing.Point(110, 211)
        Me.Fecha_salidaDateTimePicker.Name = "Fecha_salidaDateTimePicker"
        Me.Fecha_salidaDateTimePicker.Size = New System.Drawing.Size(100, 22)
        Me.Fecha_salidaDateTimePicker.TabIndex = 7
        '
        'Fecha_llegadaDateTimePicker
        '
        Me.Fecha_llegadaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpeñoBindingSource, "fecha_llegada", True))
        Me.Fecha_llegadaDateTimePicker.Enabled = False
        Me.Fecha_llegadaDateTimePicker.Location = New System.Drawing.Point(110, 156)
        Me.Fecha_llegadaDateTimePicker.Name = "Fecha_llegadaDateTimePicker"
        Me.Fecha_llegadaDateTimePicker.Size = New System.Drawing.Size(100, 22)
        Me.Fecha_llegadaDateTimePicker.TabIndex = 5
        '
        'Valor_empeñoTextBox
        '
        Me.Valor_empeñoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpeñoBindingSource, "valor_empeño", True))
        Me.Valor_empeñoTextBox.Enabled = False
        Me.Valor_empeñoTextBox.Location = New System.Drawing.Point(110, 97)
        Me.Valor_empeñoTextBox.Name = "Valor_empeñoTextBox"
        Me.Valor_empeñoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Valor_empeñoTextBox.TabIndex = 3
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpeñoBindingSource, "codigo", True))
        Me.CodigoTextBox.Enabled = False
        Me.CodigoTextBox.Location = New System.Drawing.Point(110, 35)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.CodigoTextBox.TabIndex = 1
        '
        'PictureBoxActualizar
        '
        Me.PictureBoxActualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxActualizar.Image = CType(resources.GetObject("PictureBoxActualizar.Image"), System.Drawing.Image)
        Me.PictureBoxActualizar.Location = New System.Drawing.Point(517, 6)
        Me.PictureBoxActualizar.Name = "PictureBoxActualizar"
        Me.PictureBoxActualizar.Size = New System.Drawing.Size(61, 43)
        Me.PictureBoxActualizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxActualizar.TabIndex = 10
        Me.PictureBoxActualizar.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(233, 11)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(47, 36)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 8
        Me.PictureBox4.TabStop = False
        '
        'PictureBoxModificar
        '
        Me.PictureBoxModificar.Image = CType(resources.GetObject("PictureBoxModificar.Image"), System.Drawing.Image)
        Me.PictureBoxModificar.Location = New System.Drawing.Point(830, 0)
        Me.PictureBoxModificar.Name = "PictureBoxModificar"
        Me.PictureBoxModificar.Size = New System.Drawing.Size(32, 32)
        Me.PictureBoxModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxModificar.TabIndex = 6
        Me.PictureBoxModificar.TabStop = False
        '
        'TabPageDesempeños
        '
        Me.TabPageDesempeños.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TabPageDesempeños.Controls.Add(Me.RetiroDataGridView)
        Me.TabPageDesempeños.Controls.Add(Me.Panel3)
        Me.TabPageDesempeños.Controls.Add(Me.Panel10)
        Me.TabPageDesempeños.Controls.Add(Me.Panel11)
        Me.TabPageDesempeños.Location = New System.Drawing.Point(4, 28)
        Me.TabPageDesempeños.Name = "TabPageDesempeños"
        Me.TabPageDesempeños.Size = New System.Drawing.Size(1332, 581)
        Me.TabPageDesempeños.TabIndex = 11
        Me.TabPageDesempeños.Text = "DESEMPEÑOS"
        '
        'RetiroDataGridView
        '
        Me.RetiroDataGridView.AutoGenerateColumns = False
        Me.RetiroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RetiroDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32})
        Me.RetiroDataGridView.DataSource = Me.RetiroBindingSource
        Me.RetiroDataGridView.Location = New System.Drawing.Point(18, 89)
        Me.RetiroDataGridView.Name = "RetiroDataGridView"
        Me.RetiroDataGridView.Size = New System.Drawing.Size(642, 420)
        Me.RetiroDataGridView.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel3.Controls.Add(Me.LabelAviso)
        Me.Panel3.Controls.Add(Me.Label72)
        Me.Panel3.Controls.Add(Me.TextBoxDescuento)
        Me.Panel3.Controls.Add(Me.Label70)
        Me.Panel3.Controls.Add(Me.Label71)
        Me.Panel3.Controls.Add(Me.Label73)
        Me.Panel3.Controls.Add(Me.Label75)
        Me.Panel3.Controls.Add(Me.LabelCedDes)
        Me.Panel3.Controls.Add(Me.LabelTotalDes)
        Me.Panel3.Controls.Add(Me.LabelDeudaDes)
        Me.Panel3.Controls.Add(Me.TextBoxBuscarDesempeño)
        Me.Panel3.Controls.Add(Me.ButtonDesempeñar)
        Me.Panel3.Location = New System.Drawing.Point(739, 89)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(532, 420)
        Me.Panel3.TabIndex = 3
        '
        'LabelAviso
        '
        Me.LabelAviso.AutoSize = True
        Me.LabelAviso.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAviso.Location = New System.Drawing.Point(80, 393)
        Me.LabelAviso.Name = "LabelAviso"
        Me.LabelAviso.Size = New System.Drawing.Size(12, 18)
        Me.LabelAviso.TabIndex = 13
        Me.LabelAviso.Text = "."
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(200, 38)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(150, 20)
        Me.Label72.TabIndex = 12
        Me.Label72.Text = "CODIGO EMPEÑO:"
        '
        'TextBoxDescuento
        '
        Me.TextBoxDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDescuento.Location = New System.Drawing.Point(171, 225)
        Me.TextBoxDescuento.Name = "TextBoxDescuento"
        Me.TextBoxDescuento.Size = New System.Drawing.Size(201, 29)
        Me.TextBoxDescuento.TabIndex = 11
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(89, 232)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(88, 18)
        Me.Label70.TabIndex = 10
        Me.Label70.Text = "Descuento: "
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(36, 192)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(111, 18)
        Me.Label71.TabIndex = 9
        Me.Label71.Text = "Cedula Cliente: "
        '
        'Label73
        '
        Me.Label73.AutoSize = True
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(107, 285)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(49, 18)
        Me.Label73.TabIndex = 8
        Me.Label73.Text = "Total: "
        '
        'Label75
        '
        Me.Label75.AutoSize = True
        Me.Label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(28, 144)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(179, 18)
        Me.Label75.TabIndex = 7
        Me.Label75.Text = "Deuda Total del Empeño: "
        '
        'LabelCedDes
        '
        Me.LabelCedDes.AutoSize = True
        Me.LabelCedDes.Location = New System.Drawing.Point(150, 192)
        Me.LabelCedDes.Name = "LabelCedDes"
        Me.LabelCedDes.Size = New System.Drawing.Size(38, 16)
        Me.LabelCedDes.TabIndex = 5
        Me.LabelCedDes.Text = "None"
        '
        'LabelTotalDes
        '
        Me.LabelTotalDes.AutoSize = True
        Me.LabelTotalDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalDes.Location = New System.Drawing.Point(162, 281)
        Me.LabelTotalDes.Name = "LabelTotalDes"
        Me.LabelTotalDes.Size = New System.Drawing.Size(45, 24)
        Me.LabelTotalDes.TabIndex = 3
        Me.LabelTotalDes.Text = "$0.0"
        '
        'LabelDeudaDes
        '
        Me.LabelDeudaDes.AutoSize = True
        Me.LabelDeudaDes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDeudaDes.Location = New System.Drawing.Point(213, 144)
        Me.LabelDeudaDes.Name = "LabelDeudaDes"
        Me.LabelDeudaDes.Size = New System.Drawing.Size(45, 24)
        Me.LabelDeudaDes.TabIndex = 2
        Me.LabelDeudaDes.Text = "$0.0"
        '
        'TextBoxBuscarDesempeño
        '
        Me.TextBoxBuscarDesempeño.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxBuscarDesempeño.Location = New System.Drawing.Point(171, 72)
        Me.TextBoxBuscarDesempeño.Name = "TextBoxBuscarDesempeño"
        Me.TextBoxBuscarDesempeño.Size = New System.Drawing.Size(201, 35)
        Me.TextBoxBuscarDesempeño.TabIndex = 1
        '
        'ButtonDesempeñar
        '
        Me.ButtonDesempeñar.BackColor = System.Drawing.Color.YellowGreen
        Me.ButtonDesempeñar.Enabled = False
        Me.ButtonDesempeñar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDesempeñar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDesempeñar.Location = New System.Drawing.Point(197, 326)
        Me.ButtonDesempeñar.Name = "ButtonDesempeñar"
        Me.ButtonDesempeñar.Size = New System.Drawing.Size(153, 62)
        Me.ButtonDesempeñar.TabIndex = 0
        Me.ButtonDesempeñar.Text = "Desempeñar"
        Me.ButtonDesempeñar.UseVisualStyleBackColor = False
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel10.Controls.Add(Me.Label76)
        Me.Panel10.Location = New System.Drawing.Point(739, 42)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(532, 49)
        Me.Panel10.TabIndex = 16
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.White
        Me.Label76.Location = New System.Drawing.Point(210, 12)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(132, 20)
        Me.Label76.TabIndex = 15
        Me.Label76.Text = "DESEMPEÑAR"
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel11.Controls.Add(Me.Label74)
        Me.Panel11.Location = New System.Drawing.Point(18, 42)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(642, 49)
        Me.Panel11.TabIndex = 17
        '
        'Label74
        '
        Me.Label74.AutoSize = True
        Me.Label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.White
        Me.Label74.Location = New System.Drawing.Point(209, 12)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(238, 20)
        Me.Label74.TabIndex = 14
        Me.Label74.Text = "TODOS LOS DESEMPEÑOS"
        '
        'TabPageIntereses
        '
        Me.TabPageIntereses.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TabPageIntereses.Controls.Add(Me.Panel9)
        Me.TabPageIntereses.Controls.Add(Me.Panel8Buscar)
        Me.TabPageIntereses.Controls.Add(Me.Panel7Abono)
        Me.TabPageIntereses.Location = New System.Drawing.Point(4, 28)
        Me.TabPageIntereses.Name = "TabPageIntereses"
        Me.TabPageIntereses.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageIntereses.Size = New System.Drawing.Size(1332, 581)
        Me.TabPageIntereses.TabIndex = 6
        Me.TabPageIntereses.Text = "INTERESES"
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel9.Controls.Add(Me.Label54)
        Me.Panel9.Controls.Add(Me.Label53)
        Me.Panel9.Controls.Add(Me.PictureBox5)
        Me.Panel9.Controls.Add(Me.PictureBox2)
        Me.Panel9.Location = New System.Drawing.Point(7, 30)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(200, 481)
        Me.Panel9.TabIndex = 11
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.White
        Me.Label54.Location = New System.Drawing.Point(16, 254)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(143, 18)
        Me.Label54.TabIndex = 3
        Me.Label54.Text = "Consultar Abonos"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.White
        Me.Label53.Location = New System.Drawing.Point(24, 43)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(135, 18)
        Me.Label53.TabIndex = 2
        Me.Label53.Text = "Abonar Intereses"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.MILENIO.My.Resources.Resources.search_48px
        Me.PictureBox5.Location = New System.Drawing.Point(27, 275)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(125, 108)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox5.TabIndex = 1
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, "Consulta los Abonos realizados " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "para un Empeño o cliente especifico.")
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.MILENIO.My.Resources.Resources.receive_cash_64px
        Me.PictureBox2.Location = New System.Drawing.Point(27, 61)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(125, 103)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel8Buscar
        '
        Me.Panel8Buscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel8Buscar.Controls.Add(Me.LabelNumEmpeños)
        Me.Panel8Buscar.Controls.Add(Me.DataGridViewResultadoAb)
        Me.Panel8Buscar.Controls.Add(Me.ToolStrip1)
        Me.Panel8Buscar.Enabled = False
        Me.Panel8Buscar.Location = New System.Drawing.Point(233, 256)
        Me.Panel8Buscar.Name = "Panel8Buscar"
        Me.Panel8Buscar.Size = New System.Drawing.Size(918, 255)
        Me.Panel8Buscar.TabIndex = 10
        '
        'LabelNumEmpeños
        '
        Me.LabelNumEmpeños.AutoSize = True
        Me.LabelNumEmpeños.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.LabelNumEmpeños.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumEmpeños.Location = New System.Drawing.Point(427, 8)
        Me.LabelNumEmpeños.Name = "LabelNumEmpeños"
        Me.LabelNumEmpeños.Size = New System.Drawing.Size(139, 20)
        Me.LabelNumEmpeños.TabIndex = 2
        Me.LabelNumEmpeños.Text = "Info De Busqueda"
        '
        'DataGridViewResultadoAb
        '
        Me.DataGridViewResultadoAb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewResultadoAb.Location = New System.Drawing.Point(9, 49)
        Me.DataGridViewResultadoAb.Name = "DataGridViewResultadoAb"
        Me.DataGridViewResultadoAb.Size = New System.Drawing.Size(765, 196)
        Me.DataGridViewResultadoAb.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBoxDato, Me.ToolStripComboBox1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(918, 37)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripTextBoxDato
        '
        Me.ToolStripTextBoxDato.AutoToolTip = True
        Me.ToolStripTextBoxDato.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStripTextBoxDato.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBoxDato.Name = "ToolStripTextBoxDato"
        Me.ToolStripTextBoxDato.Size = New System.Drawing.Size(160, 37)
        Me.ToolStripTextBoxDato.ToolTipText = "Digite " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* ID del abono" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Cod empeño " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Cedula del cliente"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.AutoToolTip = True
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"ID", "Cedula Cliente", "Codigo Empeño"})
        Me.ToolStripComboBox1.Margin = New System.Windows.Forms.Padding(4, 0, 1, 0)
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 37)
        Me.ToolStripComboBox1.ToolTipText = "Seleccione para empezar la busqueda"
        '
        'Panel7Abono
        '
        Me.Panel7Abono.BackColor = System.Drawing.Color.FromArgb(CType(CType(82, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Panel7Abono.Controls.Add(Me.LabelNombreInt)
        Me.Panel7Abono.Controls.Add(Me.Panel4)
        Me.Panel7Abono.Controls.Add(Me.Label33)
        Me.Panel7Abono.Controls.Add(Me.GroupBox3)
        Me.Panel7Abono.Enabled = False
        Me.Panel7Abono.Location = New System.Drawing.Point(233, 30)
        Me.Panel7Abono.Name = "Panel7Abono"
        Me.Panel7Abono.Size = New System.Drawing.Size(918, 211)
        Me.Panel7Abono.TabIndex = 9
        '
        'LabelNombreInt
        '
        Me.LabelNombreInt.AutoSize = True
        Me.LabelNombreInt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreInt.Location = New System.Drawing.Point(433, 10)
        Me.LabelNombreInt.Name = "LabelNombreInt"
        Me.LabelNombreInt.Size = New System.Drawing.Size(48, 18)
        Me.LabelNombreInt.TabIndex = 8
        Me.LabelNombreInt.Text = "None"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label63)
        Me.Panel4.Controls.Add(Me.LabelMesesFaltantes)
        Me.Panel4.Controls.Add(Me.Label60)
        Me.Panel4.Controls.Add(Me.LabelCorreo)
        Me.Panel4.Controls.Add(Me.LabelPrecioPagar2)
        Me.Panel4.Controls.Add(Me.Label32)
        Me.Panel4.Controls.Add(Me.LabelMontoEmpeño)
        Me.Panel4.Controls.Add(Me.Label36)
        Me.Panel4.Controls.Add(Me.LabelMesesPagados)
        Me.Panel4.Controls.Add(Me.Label34)
        Me.Panel4.Controls.Add(Me.LabelUltimoAbono)
        Me.Panel4.Controls.Add(Me.LabelFechaEmp)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Location = New System.Drawing.Point(308, 30)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(510, 164)
        Me.Panel4.TabIndex = 1
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(434, 137)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(49, 16)
        Me.Label63.TabIndex = 13
        Me.Label63.Text = "Meses"
        '
        'LabelMesesFaltantes
        '
        Me.LabelMesesFaltantes.AutoSize = True
        Me.LabelMesesFaltantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMesesFaltantes.Location = New System.Drawing.Point(401, 137)
        Me.LabelMesesFaltantes.Name = "LabelMesesFaltantes"
        Me.LabelMesesFaltantes.Size = New System.Drawing.Size(16, 18)
        Me.LabelMesesFaltantes.TabIndex = 12
        Me.LabelMesesFaltantes.Text = "n"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(340, 137)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(42, 16)
        Me.Label60.TabIndex = 11
        Me.Label60.Text = "Debe"
        '
        'LabelCorreo
        '
        Me.LabelCorreo.AutoSize = True
        Me.LabelCorreo.Location = New System.Drawing.Point(302, 57)
        Me.LabelCorreo.Name = "LabelCorreo"
        Me.LabelCorreo.Size = New System.Drawing.Size(38, 16)
        Me.LabelCorreo.TabIndex = 10
        Me.LabelCorreo.Text = "None"
        Me.LabelCorreo.Visible = False
        '
        'LabelPrecioPagar2
        '
        Me.LabelPrecioPagar2.AutoSize = True
        Me.LabelPrecioPagar2.Location = New System.Drawing.Point(301, 17)
        Me.LabelPrecioPagar2.Name = "LabelPrecioPagar2"
        Me.LabelPrecioPagar2.Size = New System.Drawing.Size(38, 16)
        Me.LabelPrecioPagar2.TabIndex = 9
        Me.LabelPrecioPagar2.Text = "None"
        Me.LabelPrecioPagar2.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(16, 96)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(121, 16)
        Me.Label32.TabIndex = 8
        Me.Label32.Text = "Valor del Empeño $"
        '
        'LabelMontoEmpeño
        '
        Me.LabelMontoEmpeño.AutoSize = True
        Me.LabelMontoEmpeño.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMontoEmpeño.Location = New System.Drawing.Point(142, 94)
        Me.LabelMontoEmpeño.Name = "LabelMontoEmpeño"
        Me.LabelMontoEmpeño.Size = New System.Drawing.Size(48, 18)
        Me.LabelMontoEmpeño.TabIndex = 7
        Me.LabelMontoEmpeño.Text = "None"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(240, 137)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(49, 16)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "Meses"
        '
        'LabelMesesPagados
        '
        Me.LabelMesesPagados.AutoSize = True
        Me.LabelMesesPagados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMesesPagados.Location = New System.Drawing.Point(212, 134)
        Me.LabelMesesPagados.Name = "LabelMesesPagados"
        Me.LabelMesesPagados.Size = New System.Drawing.Size(16, 18)
        Me.LabelMesesPagados.TabIndex = 5
        Me.LabelMesesPagados.Text = "n"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(49, 137)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(153, 16)
        Me.Label34.TabIndex = 4
        Me.Label34.Text = "Hasta Ahora ha Pagado"
        '
        'LabelUltimoAbono
        '
        Me.LabelUltimoAbono.AutoSize = True
        Me.LabelUltimoAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUltimoAbono.Location = New System.Drawing.Point(142, 52)
        Me.LabelUltimoAbono.Name = "LabelUltimoAbono"
        Me.LabelUltimoAbono.Size = New System.Drawing.Size(48, 18)
        Me.LabelUltimoAbono.TabIndex = 3
        Me.LabelUltimoAbono.Text = "None"
        '
        'LabelFechaEmp
        '
        Me.LabelFechaEmp.AutoSize = True
        Me.LabelFechaEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaEmp.Location = New System.Drawing.Point(140, 16)
        Me.LabelFechaEmp.Name = "LabelFechaEmp"
        Me.LabelFechaEmp.Size = New System.Drawing.Size(48, 18)
        Me.LabelFechaEmp.TabIndex = 2
        Me.LabelFechaEmp.Text = "None"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(13, 55)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(129, 16)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Fecha ultimo abono:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(13, 18)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(121, 16)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Fecha de empeño:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(320, 14)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(98, 16)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "Cedula Cliente:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LabelPrecioApagar)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.TextBoxMesesPagar)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.TextBoxInfoEmp)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 23)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(259, 171)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos"
        '
        'LabelPrecioApagar
        '
        Me.LabelPrecioApagar.AutoSize = True
        Me.LabelPrecioApagar.Location = New System.Drawing.Point(98, 91)
        Me.LabelPrecioApagar.Name = "LabelPrecioApagar"
        Me.LabelPrecioApagar.Size = New System.Drawing.Size(35, 16)
        Me.LabelPrecioApagar.TabIndex = 5
        Me.LabelPrecioApagar.Text = "label"
        Me.LabelPrecioApagar.Visible = False
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(86, 125)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 35)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "Abonar"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TextBoxMesesPagar
        '
        Me.TextBoxMesesPagar.Location = New System.Drawing.Point(131, 54)
        Me.TextBoxMesesPagar.Name = "TextBoxMesesPagar"
        Me.TextBoxMesesPagar.Size = New System.Drawing.Size(44, 22)
        Me.TextBoxMesesPagar.TabIndex = 3
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(16, 54)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(98, 16)
        Me.Label31.TabIndex = 2
        Me.Label31.Text = "Meses a pagar:"
        '
        'TextBoxInfoEmp
        '
        Me.TextBoxInfoEmp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxInfoEmp.Location = New System.Drawing.Point(131, 21)
        Me.TextBoxInfoEmp.Name = "TextBoxInfoEmp"
        Me.TextBoxInfoEmp.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxInfoEmp.TabIndex = 1
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(16, 24)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(104, 16)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Codigo Empeño:"
        '
        'TabPageOro
        '
        Me.TabPageOro.AutoScroll = True
        Me.TabPageOro.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TabPageOro.Controls.Add(Me.OroDataGridView)
        Me.TabPageOro.Controls.Add(Me.Label12)
        Me.TabPageOro.Controls.Add(Me.Panel6)
        Me.TabPageOro.Location = New System.Drawing.Point(4, 28)
        Me.TabPageOro.Name = "TabPageOro"
        Me.TabPageOro.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageOro.Size = New System.Drawing.Size(1332, 581)
        Me.TabPageOro.TabIndex = 7
        Me.TabPageOro.Text = "COMPRA ORO"
        '
        'OroDataGridView
        '
        Me.OroDataGridView.AutoGenerateColumns = False
        Me.OroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OroDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn33})
        Me.OroDataGridView.DataSource = Me.OroBindingSource
        Me.OroDataGridView.Location = New System.Drawing.Point(830, 78)
        Me.OroDataGridView.Name = "OroDataGridView"
        Me.OroDataGridView.Size = New System.Drawing.Size(428, 316)
        Me.OroDataGridView.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(830, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(428, 34)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Compras de Oro"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Khaki
        Me.Panel6.Controls.Add(Me.PictureBox15)
        Me.Panel6.Controls.Add(Me.TextBoxGramosOro)
        Me.Panel6.Controls.Add(Me.Label35)
        Me.Panel6.Controls.Add(Me.Label40)
        Me.Panel6.Controls.Add(Me.Label37)
        Me.Panel6.Controls.Add(Me.ButtonCompraOro)
        Me.Panel6.Controls.Add(Me.Label38)
        Me.Panel6.Controls.Add(Me.Label39)
        Me.Panel6.Controls.Add(Me.TextBoxPrecioCompra)
        Me.Panel6.Location = New System.Drawing.Point(203, 44)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(600, 339)
        Me.Panel6.TabIndex = 8
        '
        'PictureBox15
        '
        Me.PictureBox15.Image = Global.MILENIO.My.Resources.Resources.icons8_barras_de_oro_48
        Me.PictureBox15.Location = New System.Drawing.Point(381, 21)
        Me.PictureBox15.Name = "PictureBox15"
        Me.PictureBox15.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox15.TabIndex = 8
        Me.PictureBox15.TabStop = False
        '
        'TextBoxGramosOro
        '
        Me.TextBoxGramosOro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGramosOro.Location = New System.Drawing.Point(241, 126)
        Me.TextBoxGramosOro.Name = "TextBoxGramosOro"
        Me.TextBoxGramosOro.Size = New System.Drawing.Size(122, 26)
        Me.TextBoxGramosOro.TabIndex = 1
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(202, 37)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(176, 24)
        Me.Label35.TabIndex = 0
        Me.Label35.Text = "COMPRA DE ORO "
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(378, 72)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(55, 16)
        Me.Label40.TabIndex = 7
        Me.Label40.Text = "Oro 18K"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(68, 126)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(167, 18)
        Me.Label37.TabIndex = 2
        Me.Label37.Text = "Cantidad en Gramos (g)"
        '
        'ButtonCompraOro
        '
        Me.ButtonCompraOro.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ButtonCompraOro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCompraOro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCompraOro.Location = New System.Drawing.Point(408, 134)
        Me.ButtonCompraOro.Name = "ButtonCompraOro"
        Me.ButtonCompraOro.Size = New System.Drawing.Size(128, 60)
        Me.ButtonCompraOro.TabIndex = 6
        Me.ButtonCompraOro.Text = "Efectuar Compra"
        Me.ButtonCompraOro.UseVisualStyleBackColor = False
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(97, 180)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(129, 18)
        Me.Label38.TabIndex = 3
        Me.Label38.Text = "Precio De compra"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(235, 213)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(30, 24)
        Me.Label39.TabIndex = 5
        Me.Label39.Text = "$0"
        '
        'TextBoxPrecioCompra
        '
        Me.TextBoxPrecioCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrecioCompra.Location = New System.Drawing.Point(232, 176)
        Me.TextBoxPrecioCompra.Name = "TextBoxPrecioCompra"
        Me.TextBoxPrecioCompra.Size = New System.Drawing.Size(149, 26)
        Me.TextBoxPrecioCompra.TabIndex = 4
        '
        'TabPageGastos
        '
        Me.TabPageGastos.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TabPageGastos.Controls.Add(Me.Label85)
        Me.TabPageGastos.Controls.Add(Me.GastoDataGridView)
        Me.TabPageGastos.Controls.Add(Me.Panel12)
        Me.TabPageGastos.Location = New System.Drawing.Point(4, 28)
        Me.TabPageGastos.Name = "TabPageGastos"
        Me.TabPageGastos.Size = New System.Drawing.Size(1332, 581)
        Me.TabPageGastos.TabIndex = 12
        Me.TabPageGastos.Text = "GASTOS"
        '
        'Label85
        '
        Me.Label85.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label85.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.ForeColor = System.Drawing.Color.White
        Me.Label85.Location = New System.Drawing.Point(69, 57)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(399, 34)
        Me.Label85.TabIndex = 5
        Me.Label85.Text = "Añadir Gastos"
        Me.Label85.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GastoDataGridView
        '
        Me.GastoDataGridView.AutoGenerateColumns = False
        Me.GastoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.GastoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GastoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GastoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37})
        Me.GastoDataGridView.DataSource = Me.GastoBindingSource
        Me.GastoDataGridView.Location = New System.Drawing.Point(598, 87)
        Me.GastoDataGridView.Name = "GastoDataGridView"
        Me.GastoDataGridView.Size = New System.Drawing.Size(543, 238)
        Me.GastoDataGridView.TabIndex = 0
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.SlateBlue
        Me.Panel12.Controls.Add(Me.RichTextBoxGastoDescripcion)
        Me.Panel12.Controls.Add(Me.Label83)
        Me.Panel12.Controls.Add(Me.Button3)
        Me.Panel12.Controls.Add(Me.TextBoxAñadirGasto)
        Me.Panel12.Controls.Add(Me.Label81)
        Me.Panel12.Controls.Add(Me.Label86)
        Me.Panel12.Location = New System.Drawing.Point(69, 90)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(399, 267)
        Me.Panel12.TabIndex = 4
        '
        'RichTextBoxGastoDescripcion
        '
        Me.RichTextBoxGastoDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxGastoDescripcion.Location = New System.Drawing.Point(106, 101)
        Me.RichTextBoxGastoDescripcion.Name = "RichTextBoxGastoDescripcion"
        Me.RichTextBoxGastoDescripcion.Size = New System.Drawing.Size(232, 60)
        Me.RichTextBoxGastoDescripcion.TabIndex = 5
        Me.RichTextBoxGastoDescripcion.Text = ""
        '
        'Label83
        '
        Me.Label83.AutoSize = True
        Me.Label83.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(102, 64)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(29, 20)
        Me.Label83.TabIndex = 4
        Me.Label83.Text = "$0"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(138, 198)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 54)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Añadir"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBoxAñadirGasto
        '
        Me.TextBoxAñadirGasto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxAñadirGasto.Location = New System.Drawing.Point(106, 32)
        Me.TextBoxAñadirGasto.Name = "TextBoxAñadirGasto"
        Me.TextBoxAñadirGasto.Size = New System.Drawing.Size(232, 29)
        Me.TextBoxAñadirGasto.TabIndex = 1
        '
        'Label81
        '
        Me.Label81.AutoSize = True
        Me.Label81.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(36, 36)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(77, 20)
        Me.Label81.TabIndex = 2
        Me.Label81.Text = "Gastos: "
        '
        'Label86
        '
        Me.Label86.AutoSize = True
        Me.Label86.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(4, 101)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(113, 20)
        Me.Label86.TabIndex = 6
        Me.Label86.Text = "Descripcion: "
        '
        'TabPageVentas
        '
        Me.TabPageVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TabPageVentas.Controls.Add(Me.DataGridViewProductosDisponibles)
        Me.TabPageVentas.Controls.Add(Me.ButtonListarProductos)
        Me.TabPageVentas.Location = New System.Drawing.Point(4, 28)
        Me.TabPageVentas.Name = "TabPageVentas"
        Me.TabPageVentas.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageVentas.Size = New System.Drawing.Size(1332, 581)
        Me.TabPageVentas.TabIndex = 8
        Me.TabPageVentas.Text = "VENTAS"
        '
        'DataGridViewProductosDisponibles
        '
        Me.DataGridViewProductosDisponibles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewProductosDisponibles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.DataGridViewProductosDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductosDisponibles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Vender})
        Me.DataGridViewProductosDisponibles.Location = New System.Drawing.Point(62, 105)
        Me.DataGridViewProductosDisponibles.Name = "DataGridViewProductosDisponibles"
        Me.DataGridViewProductosDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewProductosDisponibles.Size = New System.Drawing.Size(788, 451)
        Me.DataGridViewProductosDisponibles.TabIndex = 1
        '
        'Vender
        '
        Me.Vender.FillWeight = 120.0!
        Me.Vender.HeaderText = "Vender"
        Me.Vender.Image = Global.MILENIO.My.Resources.Resources.icons8_pagado_48
        Me.Vender.MinimumWidth = 48
        Me.Vender.Name = "Vender"
        '
        'ButtonListarProductos
        '
        Me.ButtonListarProductos.Location = New System.Drawing.Point(62, 39)
        Me.ButtonListarProductos.Name = "ButtonListarProductos"
        Me.ButtonListarProductos.Size = New System.Drawing.Size(146, 60)
        Me.ButtonListarProductos.TabIndex = 0
        Me.ButtonListarProductos.Text = "Listar Productos en Venta"
        Me.ButtonListarProductos.UseVisualStyleBackColor = True
        '
        'TabPageArqueo
        '
        Me.TabPageArqueo.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TabPageArqueo.Controls.Add(Me.Panel13)
        Me.TabPageArqueo.Controls.Add(Me.PanelDetallesArq)
        Me.TabPageArqueo.Controls.Add(Me.LabelNumeroAbonos)
        Me.TabPageArqueo.Controls.Add(Me.Label82)
        Me.TabPageArqueo.Controls.Add(Me.LabelNumeroOro)
        Me.TabPageArqueo.Controls.Add(Me.Label80)
        Me.TabPageArqueo.Controls.Add(Me.Panel8)
        Me.TabPageArqueo.Controls.Add(Me.LabelNumeroEmpeños)
        Me.TabPageArqueo.Controls.Add(Me.Label77)
        Me.TabPageArqueo.Controls.Add(Me.Label79)
        Me.TabPageArqueo.Controls.Add(Me.Label78)
        Me.TabPageArqueo.Controls.Add(Me.LabelNumeroVentas)
        Me.TabPageArqueo.Controls.Add(Me.PanelArqueo)
        Me.TabPageArqueo.Location = New System.Drawing.Point(4, 28)
        Me.TabPageArqueo.Name = "TabPageArqueo"
        Me.TabPageArqueo.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageArqueo.Size = New System.Drawing.Size(1332, 581)
        Me.TabPageArqueo.TabIndex = 9
        Me.TabPageArqueo.Text = "ARQUEO"
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel13.Controls.Add(Me.GraficoReporteMes)
        Me.Panel13.Controls.Add(Me.GroupBox7)
        Me.Panel13.Controls.Add(Me.Label64)
        Me.Panel13.Controls.Add(Me.GroupBox6)
        Me.Panel13.Location = New System.Drawing.Point(55, 71)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1223, 470)
        Me.Panel13.TabIndex = 44
        Me.Panel13.Visible = False
        '
        'GraficoReporteMes
        '
        ChartArea3.Name = "ChartArea1"
        Me.GraficoReporteMes.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.GraficoReporteMes.Legends.Add(Legend3)
        Me.GraficoReporteMes.Location = New System.Drawing.Point(56, 265)
        Me.GraficoReporteMes.Name = "GraficoReporteMes"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Legend = "Legend1"
        Series5.Name = "MesAnterior"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Legend = "Legend1"
        Series6.Name = "MesActual"
        Me.GraficoReporteMes.Series.Add(Series5)
        Me.GraficoReporteMes.Series.Add(Series6)
        Me.GraficoReporteMes.Size = New System.Drawing.Size(502, 197)
        Me.GraficoReporteMes.TabIndex = 7
        Me.GraficoReporteMes.Text = "Chart1"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label95)
        Me.GroupBox7.Controls.Add(Me.Label93)
        Me.GroupBox7.Controls.Add(Me.Label88)
        Me.GroupBox7.Controls.Add(Me.Label89)
        Me.GroupBox7.Controls.Add(Me.Label90)
        Me.GroupBox7.Controls.Add(Me.Label91)
        Me.GroupBox7.Location = New System.Drawing.Point(619, 69)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(545, 183)
        Me.GroupBox7.TabIndex = 6
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "GroupBox7"
        '
        'Label95
        '
        Me.Label95.AutoSize = True
        Me.Label95.Location = New System.Drawing.Point(245, 57)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(15, 16)
        Me.Label95.TabIndex = 7
        Me.Label95.Text = "0"
        '
        'Label93
        '
        Me.Label93.AutoSize = True
        Me.Label93.Location = New System.Drawing.Point(245, 32)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(50, 16)
        Me.Label93.TabIndex = 6
        Me.Label93.Text = "Gastos"
        '
        'Label88
        '
        Me.Label88.AutoSize = True
        Me.Label88.Location = New System.Drawing.Point(30, 136)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(15, 16)
        Me.Label88.TabIndex = 4
        Me.Label88.Text = "0"
        '
        'Label89
        '
        Me.Label89.AutoSize = True
        Me.Label89.Location = New System.Drawing.Point(30, 31)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(95, 16)
        Me.Label89.TabIndex = 1
        Me.Label89.Text = "Compra De oro"
        '
        'Label90
        '
        Me.Label90.AutoSize = True
        Me.Label90.Location = New System.Drawing.Point(30, 107)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(63, 16)
        Me.Label90.TabIndex = 3
        Me.Label90.Text = "Empeños"
        '
        'Label91
        '
        Me.Label91.AutoSize = True
        Me.Label91.Location = New System.Drawing.Point(30, 54)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(15, 16)
        Me.Label91.TabIndex = 2
        Me.Label91.Text = "0"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(517, 30)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(129, 20)
        Me.Label64.TabIndex = 0
        Me.Label64.Text = "Reporte Del Mes"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label94)
        Me.GroupBox6.Controls.Add(Me.Label92)
        Me.GroupBox6.Controls.Add(Me.Label67)
        Me.GroupBox6.Controls.Add(Me.Label65)
        Me.GroupBox6.Controls.Add(Me.Label87)
        Me.GroupBox6.Controls.Add(Me.Label66)
        Me.GroupBox6.Location = New System.Drawing.Point(56, 67)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(502, 183)
        Me.GroupBox6.TabIndex = 5
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "GroupBox6"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.Location = New System.Drawing.Point(228, 59)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(15, 16)
        Me.Label94.TabIndex = 6
        Me.Label94.Text = "0"
        '
        'Label92
        '
        Me.Label92.AutoSize = True
        Me.Label92.Location = New System.Drawing.Point(228, 31)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(49, 16)
        Me.Label92.TabIndex = 5
        Me.Label92.Text = "Retiros"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(30, 136)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(15, 16)
        Me.Label67.TabIndex = 4
        Me.Label67.Text = "0"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(30, 31)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(48, 16)
        Me.Label65.TabIndex = 1
        Me.Label65.Text = "Ventas"
        '
        'Label87
        '
        Me.Label87.AutoSize = True
        Me.Label87.Location = New System.Drawing.Point(30, 107)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(47, 16)
        Me.Label87.TabIndex = 3
        Me.Label87.Text = "Interes"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(30, 54)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(15, 16)
        Me.Label66.TabIndex = 2
        Me.Label66.Text = "0"
        '
        'PanelDetallesArq
        '
        Me.PanelDetallesArq.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PanelDetallesArq.Controls.Add(Me.Label42)
        Me.PanelDetallesArq.Controls.Add(Me.CheckedListBox1)
        Me.PanelDetallesArq.Controls.Add(Me.Panel13Oro)
        Me.PanelDetallesArq.Controls.Add(Me.Panel13Gasto)
        Me.PanelDetallesArq.Controls.Add(Me.Panel13Abono)
        Me.PanelDetallesArq.Controls.Add(Me.Panel13Retiro)
        Me.PanelDetallesArq.Controls.Add(Me.Panel13Empeño)
        Me.PanelDetallesArq.Controls.Add(Me.Panel13Ventas)
        Me.PanelDetallesArq.Controls.Add(Me.LabelFechaUltimoArq)
        Me.PanelDetallesArq.Controls.Add(Me.LabelSaldoUltimoArq)
        Me.PanelDetallesArq.Controls.Add(Me.PictureBox7)
        Me.PanelDetallesArq.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelDetallesArq.Location = New System.Drawing.Point(55, 71)
        Me.PanelDetallesArq.Name = "PanelDetallesArq"
        Me.PanelDetallesArq.Size = New System.Drawing.Size(1223, 470)
        Me.PanelDetallesArq.TabIndex = 34
        Me.PanelDetallesArq.Visible = False
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.BackColor = System.Drawing.Color.White
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Blue
        Me.Label42.Location = New System.Drawing.Point(765, 100)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(165, 20)
        Me.Label42.TabIndex = 43
        Me.Label42.Text = "Ninguno seleccionado"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.ColumnWidth = 100
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Retiros", "Abonos", "Ventas", "Empeños", "Gastos", "Oro"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(570, 84)
        Me.CheckedListBox1.MultiColumn = True
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(394, 55)
        Me.CheckedListBox1.TabIndex = 38
        Me.CheckedListBox1.ThreeDCheckBoxes = True
        '
        'Panel13Oro
        '
        Me.Panel13Oro.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(111, Byte), Integer))
        Me.Panel13Oro.Controls.Add(Me.DGVOro)
        Me.Panel13Oro.Controls.Add(Me.LabelNoro)
        Me.Panel13Oro.Location = New System.Drawing.Point(56, 145)
        Me.Panel13Oro.Name = "Panel13Oro"
        Me.Panel13Oro.Size = New System.Drawing.Size(908, 284)
        Me.Panel13Oro.TabIndex = 42
        '
        'DGVOro
        '
        Me.DGVOro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVOro.Location = New System.Drawing.Point(47, 27)
        Me.DGVOro.Name = "DGVOro"
        Me.DGVOro.Size = New System.Drawing.Size(823, 206)
        Me.DGVOro.TabIndex = 1
        '
        'LabelNoro
        '
        Me.LabelNoro.AutoSize = True
        Me.LabelNoro.Location = New System.Drawing.Point(43, 242)
        Me.LabelNoro.Name = "LabelNoro"
        Me.LabelNoro.Size = New System.Drawing.Size(15, 16)
        Me.LabelNoro.TabIndex = 0
        Me.LabelNoro.Text = "0"
        '
        'Panel13Gasto
        '
        Me.Panel13Gasto.BackColor = System.Drawing.Color.FromArgb(CType(CType(86, Byte), Integer), CType(CType(101, Byte), Integer), CType(CType(115, Byte), Integer))
        Me.Panel13Gasto.Controls.Add(Me.LabelN)
        Me.Panel13Gasto.Controls.Add(Me.DGVgasto)
        Me.Panel13Gasto.Location = New System.Drawing.Point(56, 145)
        Me.Panel13Gasto.Name = "Panel13Gasto"
        Me.Panel13Gasto.Size = New System.Drawing.Size(908, 284)
        Me.Panel13Gasto.TabIndex = 41
        '
        'LabelN
        '
        Me.LabelN.AutoSize = True
        Me.LabelN.Location = New System.Drawing.Point(44, 249)
        Me.LabelN.Name = "LabelN"
        Me.LabelN.Size = New System.Drawing.Size(56, 16)
        Me.LabelN.TabIndex = 1
        Me.LabelN.Text = "Label42"
        '
        'DGVgasto
        '
        Me.DGVgasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVgasto.Location = New System.Drawing.Point(46, 26)
        Me.DGVgasto.Name = "DGVgasto"
        Me.DGVgasto.Size = New System.Drawing.Size(828, 213)
        Me.DGVgasto.TabIndex = 0
        '
        'Panel13Abono
        '
        Me.Panel13Abono.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.Panel13Abono.Controls.Add(Me.LabelNabono)
        Me.Panel13Abono.Controls.Add(Me.DGVabono)
        Me.Panel13Abono.Location = New System.Drawing.Point(56, 145)
        Me.Panel13Abono.Name = "Panel13Abono"
        Me.Panel13Abono.Size = New System.Drawing.Size(908, 284)
        Me.Panel13Abono.TabIndex = 38
        '
        'LabelNabono
        '
        Me.LabelNabono.AutoSize = True
        Me.LabelNabono.Location = New System.Drawing.Point(43, 242)
        Me.LabelNabono.Name = "LabelNabono"
        Me.LabelNabono.Size = New System.Drawing.Size(15, 16)
        Me.LabelNabono.TabIndex = 1
        Me.LabelNabono.Text = "0"
        '
        'DGVabono
        '
        Me.DGVabono.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVabono.Location = New System.Drawing.Point(44, 31)
        Me.DGVabono.Name = "DGVabono"
        Me.DGVabono.Size = New System.Drawing.Size(830, 206)
        Me.DGVabono.TabIndex = 0
        '
        'Panel13Retiro
        '
        Me.Panel13Retiro.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel13Retiro.Controls.Add(Me.DGVretiro)
        Me.Panel13Retiro.Controls.Add(Me.LabelNretiro)
        Me.Panel13Retiro.Location = New System.Drawing.Point(56, 145)
        Me.Panel13Retiro.Name = "Panel13Retiro"
        Me.Panel13Retiro.Size = New System.Drawing.Size(908, 284)
        Me.Panel13Retiro.TabIndex = 37
        '
        'DGVretiro
        '
        Me.DGVretiro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVretiro.Location = New System.Drawing.Point(43, 31)
        Me.DGVretiro.Name = "DGVretiro"
        Me.DGVretiro.Size = New System.Drawing.Size(827, 197)
        Me.DGVretiro.TabIndex = 1
        '
        'LabelNretiro
        '
        Me.LabelNretiro.AutoSize = True
        Me.LabelNretiro.Location = New System.Drawing.Point(41, 239)
        Me.LabelNretiro.Name = "LabelNretiro"
        Me.LabelNretiro.Size = New System.Drawing.Size(15, 16)
        Me.LabelNretiro.TabIndex = 0
        Me.LabelNretiro.Text = "0"
        '
        'Panel13Empeño
        '
        Me.Panel13Empeño.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.Panel13Empeño.Controls.Add(Me.LabelNemp)
        Me.Panel13Empeño.Controls.Add(Me.DGVEmp)
        Me.Panel13Empeño.Location = New System.Drawing.Point(56, 145)
        Me.Panel13Empeño.Name = "Panel13Empeño"
        Me.Panel13Empeño.Size = New System.Drawing.Size(908, 284)
        Me.Panel13Empeño.TabIndex = 40
        '
        'LabelNemp
        '
        Me.LabelNemp.AutoSize = True
        Me.LabelNemp.Location = New System.Drawing.Point(30, 254)
        Me.LabelNemp.Name = "LabelNemp"
        Me.LabelNemp.Size = New System.Drawing.Size(15, 16)
        Me.LabelNemp.TabIndex = 1
        Me.LabelNemp.Text = "0"
        '
        'DGVEmp
        '
        Me.DGVEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEmp.Location = New System.Drawing.Point(29, 26)
        Me.DGVEmp.Name = "DGVEmp"
        Me.DGVEmp.Size = New System.Drawing.Size(841, 225)
        Me.DGVEmp.TabIndex = 0
        '
        'Panel13Ventas
        '
        Me.Panel13Ventas.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Panel13Ventas.Controls.Add(Me.LabelNventas)
        Me.Panel13Ventas.Controls.Add(Me.DGVVenta)
        Me.Panel13Ventas.Location = New System.Drawing.Point(56, 145)
        Me.Panel13Ventas.Name = "Panel13Ventas"
        Me.Panel13Ventas.Size = New System.Drawing.Size(908, 284)
        Me.Panel13Ventas.TabIndex = 39
        '
        'LabelNventas
        '
        Me.LabelNventas.AutoSize = True
        Me.LabelNventas.Location = New System.Drawing.Point(40, 259)
        Me.LabelNventas.Name = "LabelNventas"
        Me.LabelNventas.Size = New System.Drawing.Size(15, 16)
        Me.LabelNventas.TabIndex = 1
        Me.LabelNventas.Text = "0"
        '
        'DGVVenta
        '
        Me.DGVVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVenta.Location = New System.Drawing.Point(43, 24)
        Me.DGVVenta.Name = "DGVVenta"
        Me.DGVVenta.Size = New System.Drawing.Size(815, 232)
        Me.DGVVenta.TabIndex = 0
        '
        'LabelFechaUltimoArq
        '
        Me.LabelFechaUltimoArq.AutoSize = True
        Me.LabelFechaUltimoArq.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaUltimoArq.ForeColor = System.Drawing.Color.White
        Me.LabelFechaUltimoArq.Location = New System.Drawing.Point(25, 60)
        Me.LabelFechaUltimoArq.Name = "LabelFechaUltimoArq"
        Me.LabelFechaUltimoArq.Size = New System.Drawing.Size(159, 20)
        Me.LabelFechaUltimoArq.TabIndex = 35
        Me.LabelFechaUltimoArq.Text = "Fecha Ultimo Arqueo"
        '
        'LabelSaldoUltimoArq
        '
        Me.LabelSaldoUltimoArq.AutoSize = True
        Me.LabelSaldoUltimoArq.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSaldoUltimoArq.ForeColor = System.Drawing.Color.White
        Me.LabelSaldoUltimoArq.Location = New System.Drawing.Point(25, 28)
        Me.LabelSaldoUltimoArq.Name = "LabelSaldoUltimoArq"
        Me.LabelSaldoUltimoArq.Size = New System.Drawing.Size(191, 20)
        Me.LabelSaldoUltimoArq.TabIndex = 34
        Me.LabelSaldoUltimoArq.Text = "SaldoCaja Ultimo Arqueo:"
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Silver
        Me.PictureBox7.Image = Global.MILENIO.My.Resources.Resources.icons8_desplegar_50
        Me.PictureBox7.Location = New System.Drawing.Point(1170, 204)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox7.TabIndex = 36
        Me.PictureBox7.TabStop = False
        '
        'LabelNumeroAbonos
        '
        Me.LabelNumeroAbonos.AutoSize = True
        Me.LabelNumeroAbonos.BackColor = System.Drawing.Color.DimGray
        Me.LabelNumeroAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumeroAbonos.ForeColor = System.Drawing.Color.Lime
        Me.LabelNumeroAbonos.Location = New System.Drawing.Point(173, 111)
        Me.LabelNumeroAbonos.Name = "LabelNumeroAbonos"
        Me.LabelNumeroAbonos.Size = New System.Drawing.Size(24, 18)
        Me.LabelNumeroAbonos.TabIndex = 46
        Me.LabelNumeroAbonos.Text = "$0"
        '
        'Label82
        '
        Me.Label82.BackColor = System.Drawing.Color.Black
        Me.Label82.ForeColor = System.Drawing.Color.White
        Me.Label82.Location = New System.Drawing.Point(731, 21)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(122, 25)
        Me.Label82.TabIndex = 58
        Me.Label82.Text = "CompraOro"
        Me.Label82.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelNumeroOro
        '
        Me.LabelNumeroOro.AutoSize = True
        Me.LabelNumeroOro.BackColor = System.Drawing.Color.DimGray
        Me.LabelNumeroOro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumeroOro.ForeColor = System.Drawing.Color.Lime
        Me.LabelNumeroOro.Location = New System.Drawing.Point(732, 113)
        Me.LabelNumeroOro.Name = "LabelNumeroOro"
        Me.LabelNumeroOro.Size = New System.Drawing.Size(24, 18)
        Me.LabelNumeroOro.TabIndex = 57
        Me.LabelNumeroOro.Text = "$0"
        '
        'Label80
        '
        Me.Label80.BackColor = System.Drawing.Color.Black
        Me.Label80.ForeColor = System.Drawing.Color.White
        Me.Label80.Location = New System.Drawing.Point(594, 21)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(122, 25)
        Me.Label80.TabIndex = 55
        Me.Label80.Text = "Empeños"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel8.Controls.Add(Me.PictureBox16)
        Me.Panel8.Controls.Add(Me.PictureBoxArqueo)
        Me.Panel8.Controls.Add(Me.PictureBox6)
        Me.Panel8.Location = New System.Drawing.Point(0, 71)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(65, 470)
        Me.Panel8.TabIndex = 32
        '
        'PictureBox16
        '
        Me.PictureBox16.Image = Global.MILENIO.My.Resources.Resources.bill_64px
        Me.PictureBox16.Location = New System.Drawing.Point(1, 217)
        Me.PictureBox16.Name = "PictureBox16"
        Me.PictureBox16.Size = New System.Drawing.Size(49, 52)
        Me.PictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox16.TabIndex = 2
        Me.PictureBox16.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox16, "Reporte Mensual")
        '
        'PictureBoxArqueo
        '
        Me.PictureBoxArqueo.Enabled = False
        Me.PictureBoxArqueo.Image = Global.MILENIO.My.Resources.Resources.icons8_mostrar_propiedad_128
        Me.PictureBoxArqueo.Location = New System.Drawing.Point(3, 30)
        Me.PictureBoxArqueo.Name = "PictureBoxArqueo"
        Me.PictureBoxArqueo.Size = New System.Drawing.Size(49, 52)
        Me.PictureBoxArqueo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxArqueo.TabIndex = 1
        Me.PictureBoxArqueo.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.MILENIO.My.Resources.Resources.icons8_en_inventario_64
        Me.PictureBox6.Location = New System.Drawing.Point(0, 119)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(49, 52)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'LabelNumeroEmpeños
        '
        Me.LabelNumeroEmpeños.AutoSize = True
        Me.LabelNumeroEmpeños.BackColor = System.Drawing.Color.DimGray
        Me.LabelNumeroEmpeños.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumeroEmpeños.ForeColor = System.Drawing.Color.Lime
        Me.LabelNumeroEmpeños.Location = New System.Drawing.Point(595, 113)
        Me.LabelNumeroEmpeños.Name = "LabelNumeroEmpeños"
        Me.LabelNumeroEmpeños.Size = New System.Drawing.Size(24, 18)
        Me.LabelNumeroEmpeños.TabIndex = 54
        Me.LabelNumeroEmpeños.Text = "$0"
        '
        'Label77
        '
        Me.Label77.BackColor = System.Drawing.Color.Black
        Me.Label77.ForeColor = System.Drawing.Color.White
        Me.Label77.Location = New System.Drawing.Point(172, 21)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(122, 25)
        Me.Label77.TabIndex = 50
        Me.Label77.Text = "Abonos"
        Me.Label77.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label79
        '
        Me.Label79.BackColor = System.Drawing.Color.Black
        Me.Label79.ForeColor = System.Drawing.Color.White
        Me.Label79.Location = New System.Drawing.Point(455, 21)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(122, 25)
        Me.Label79.TabIndex = 52
        Me.Label79.Text = "Ventas"
        Me.Label79.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label78
        '
        Me.Label78.BackColor = System.Drawing.Color.Black
        Me.Label78.ForeColor = System.Drawing.Color.White
        Me.Label78.Location = New System.Drawing.Point(315, 21)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(122, 25)
        Me.Label78.TabIndex = 51
        Me.Label78.Text = "Retiros"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelNumeroVentas
        '
        Me.LabelNumeroVentas.AutoSize = True
        Me.LabelNumeroVentas.BackColor = System.Drawing.Color.DimGray
        Me.LabelNumeroVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumeroVentas.ForeColor = System.Drawing.Color.Lime
        Me.LabelNumeroVentas.Location = New System.Drawing.Point(456, 113)
        Me.LabelNumeroVentas.Name = "LabelNumeroVentas"
        Me.LabelNumeroVentas.Size = New System.Drawing.Size(24, 18)
        Me.LabelNumeroVentas.TabIndex = 49
        Me.LabelNumeroVentas.Text = "$0"
        '
        'PanelArqueo
        '
        Me.PanelArqueo.Controls.Add(Me.PictureBox11)
        Me.PanelArqueo.Controls.Add(Me.PictureBox12)
        Me.PanelArqueo.Controls.Add(Me.PictureBox13)
        Me.PanelArqueo.Controls.Add(Me.LabelNumeroRetiros)
        Me.PanelArqueo.Controls.Add(Me.PictureBox9)
        Me.PanelArqueo.Controls.Add(Me.Label84)
        Me.PanelArqueo.Controls.Add(Me.LabelNumeroGastos)
        Me.PanelArqueo.Controls.Add(Me.ButtonRealizarArqueo)
        Me.PanelArqueo.Controls.Add(Me.PictureBox14)
        Me.PanelArqueo.Controls.Add(Me.GroupBox5)
        Me.PanelArqueo.Controls.Add(Me.GroupBox4)
        Me.PanelArqueo.Controls.Add(Me.Label44)
        Me.PanelArqueo.Controls.Add(Me.LabelFechaActual)
        Me.PanelArqueo.Controls.Add(Me.PictureBox10)
        Me.PanelArqueo.Location = New System.Drawing.Point(0, 0)
        Me.PanelArqueo.Name = "PanelArqueo"
        Me.PanelArqueo.Size = New System.Drawing.Size(1312, 567)
        Me.PanelArqueo.TabIndex = 33
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.Color.Gray
        Me.PictureBox11.Image = Global.MILENIO.My.Resources.Resources.icons8_pagado_48
        Me.PictureBox11.Location = New System.Drawing.Point(455, 46)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(122, 86)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox11.TabIndex = 48
        Me.PictureBox11.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.Color.Gray
        Me.PictureBox12.Image = Global.MILENIO.My.Resources.Resources.receive_cash_64px
        Me.PictureBox12.Location = New System.Drawing.Point(594, 46)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(122, 86)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox12.TabIndex = 53
        Me.PictureBox12.TabStop = False
        '
        'PictureBox13
        '
        Me.PictureBox13.BackColor = System.Drawing.Color.Gray
        Me.PictureBox13.Image = Global.MILENIO.My.Resources.Resources.icons8_barras_de_oro_48
        Me.PictureBox13.Location = New System.Drawing.Point(731, 46)
        Me.PictureBox13.Name = "PictureBox13"
        Me.PictureBox13.Size = New System.Drawing.Size(122, 86)
        Me.PictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox13.TabIndex = 56
        Me.PictureBox13.TabStop = False
        '
        'LabelNumeroRetiros
        '
        Me.LabelNumeroRetiros.AutoSize = True
        Me.LabelNumeroRetiros.BackColor = System.Drawing.Color.DimGray
        Me.LabelNumeroRetiros.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumeroRetiros.ForeColor = System.Drawing.Color.Lime
        Me.LabelNumeroRetiros.Location = New System.Drawing.Point(316, 112)
        Me.LabelNumeroRetiros.Name = "LabelNumeroRetiros"
        Me.LabelNumeroRetiros.Size = New System.Drawing.Size(24, 18)
        Me.LabelNumeroRetiros.TabIndex = 47
        Me.LabelNumeroRetiros.Text = "$0"
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Gray
        Me.PictureBox9.Image = Global.MILENIO.My.Resources.Resources.bill_64px
        Me.PictureBox9.Location = New System.Drawing.Point(172, 44)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(122, 86)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox9.TabIndex = 44
        Me.PictureBox9.TabStop = False
        '
        'Label84
        '
        Me.Label84.BackColor = System.Drawing.Color.Black
        Me.Label84.ForeColor = System.Drawing.Color.White
        Me.Label84.Location = New System.Drawing.Point(863, 21)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(122, 25)
        Me.Label84.TabIndex = 61
        Me.Label84.Text = "Gastos"
        Me.Label84.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelNumeroGastos
        '
        Me.LabelNumeroGastos.AutoSize = True
        Me.LabelNumeroGastos.BackColor = System.Drawing.Color.DimGray
        Me.LabelNumeroGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumeroGastos.ForeColor = System.Drawing.Color.Lime
        Me.LabelNumeroGastos.Location = New System.Drawing.Point(864, 113)
        Me.LabelNumeroGastos.Name = "LabelNumeroGastos"
        Me.LabelNumeroGastos.Size = New System.Drawing.Size(24, 18)
        Me.LabelNumeroGastos.TabIndex = 60
        Me.LabelNumeroGastos.Text = "$0"
        '
        'ButtonRealizarArqueo
        '
        Me.ButtonRealizarArqueo.BackColor = System.Drawing.Color.MediumAquamarine
        Me.ButtonRealizarArqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRealizarArqueo.Location = New System.Drawing.Point(530, 506)
        Me.ButtonRealizarArqueo.Name = "ButtonRealizarArqueo"
        Me.ButtonRealizarArqueo.Size = New System.Drawing.Size(171, 58)
        Me.ButtonRealizarArqueo.TabIndex = 20
        Me.ButtonRealizarArqueo.Text = "Terminar Arqueo"
        Me.ButtonRealizarArqueo.UseVisualStyleBackColor = False
        '
        'PictureBox14
        '
        Me.PictureBox14.BackColor = System.Drawing.Color.Gray
        Me.PictureBox14.Image = Global.MILENIO.My.Resources.Resources.icons8_solicitud_de_dinero_48
        Me.PictureBox14.Location = New System.Drawing.Point(863, 46)
        Me.PictureBox14.Name = "PictureBox14"
        Me.PictureBox14.Size = New System.Drawing.Size(122, 86)
        Me.PictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox14.TabIndex = 59
        Me.PictureBox14.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox5.Controls.Add(Me.Label59)
        Me.GroupBox5.Controls.Add(Me.TextBoxFaltantes)
        Me.GroupBox5.Controls.Add(Me.Label61)
        Me.GroupBox5.Controls.Add(Me.TextBoxPrestamos)
        Me.GroupBox5.Controls.Add(Me.Label46)
        Me.GroupBox5.Controls.Add(Me.TextBoxSaldoReal)
        Me.GroupBox5.Controls.Add(Me.Label50)
        Me.GroupBox5.Controls.Add(Me.Label49)
        Me.GroupBox5.Controls.Add(Me.TextBoxGastos)
        Me.GroupBox5.Controls.Add(Me.TextBoxEmpeño)
        Me.GroupBox5.Controls.Add(Me.Label45)
        Me.GroupBox5.Controls.Add(Me.Label48)
        Me.GroupBox5.Controls.Add(Me.TextBoxCompraOro)
        Me.GroupBox5.Location = New System.Drawing.Point(635, 154)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(610, 346)
        Me.GroupBox5.TabIndex = 31
        Me.GroupBox5.TabStop = False
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.Location = New System.Drawing.Point(135, 19)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(174, 20)
        Me.Label59.TabIndex = 29
        Me.Label59.Text = "EGRESOS (SALIDAS)"
        '
        'TextBoxFaltantes
        '
        Me.TextBoxFaltantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFaltantes.Location = New System.Drawing.Point(403, 299)
        Me.TextBoxFaltantes.Name = "TextBoxFaltantes"
        Me.TextBoxFaltantes.Size = New System.Drawing.Size(156, 26)
        Me.TextBoxFaltantes.TabIndex = 35
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.Location = New System.Drawing.Point(321, 302)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(76, 20)
        Me.Label61.TabIndex = 34
        Me.Label61.Text = "Faltante :"
        '
        'TextBoxPrestamos
        '
        Me.TextBoxPrestamos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPrestamos.Location = New System.Drawing.Point(158, 169)
        Me.TextBoxPrestamos.Name = "TextBoxPrestamos"
        Me.TextBoxPrestamos.Size = New System.Drawing.Size(177, 26)
        Me.TextBoxPrestamos.TabIndex = 33
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(62, 172)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(89, 20)
        Me.Label46.TabIndex = 32
        Me.Label46.Text = "Prestamos:"
        '
        'TextBoxSaldoReal
        '
        Me.TextBoxSaldoReal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSaldoReal.Location = New System.Drawing.Point(403, 263)
        Me.TextBoxSaldoReal.Name = "TextBoxSaldoReal"
        Me.TextBoxSaldoReal.Size = New System.Drawing.Size(156, 26)
        Me.TextBoxSaldoReal.TabIndex = 22
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(249, 265)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(148, 20)
        Me.Label50.TabIndex = 21
        Me.Label50.Text = "Saldo Real En caja:"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(86, 136)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(65, 20)
        Me.Label49.TabIndex = 18
        Me.Label49.Text = "Gastos:"
        '
        'TextBoxGastos
        '
        Me.TextBoxGastos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxGastos.Location = New System.Drawing.Point(157, 134)
        Me.TextBoxGastos.Name = "TextBoxGastos"
        Me.TextBoxGastos.Size = New System.Drawing.Size(177, 26)
        Me.TextBoxGastos.TabIndex = 19
        '
        'TextBoxEmpeño
        '
        Me.TextBoxEmpeño.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmpeño.Location = New System.Drawing.Point(157, 62)
        Me.TextBoxEmpeño.Name = "TextBoxEmpeño"
        Me.TextBoxEmpeño.Size = New System.Drawing.Size(177, 26)
        Me.TextBoxEmpeño.TabIndex = 12
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.Location = New System.Drawing.Point(78, 66)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(73, 20)
        Me.Label45.TabIndex = 10
        Me.Label45.Text = "Empeño:"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(30, 99)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(121, 20)
        Me.Label48.TabIndex = 16
        Me.Label48.Text = "Compra de Oro:"
        '
        'TextBoxCompraOro
        '
        Me.TextBoxCompraOro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxCompraOro.Location = New System.Drawing.Point(157, 98)
        Me.TextBoxCompraOro.Name = "TextBoxCompraOro"
        Me.TextBoxCompraOro.Size = New System.Drawing.Size(177, 26)
        Me.TextBoxCompraOro.TabIndex = 17
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightGray
        Me.GroupBox4.Controls.Add(Me.Label58)
        Me.GroupBox4.Controls.Add(Me.TextBoxVentas)
        Me.GroupBox4.Controls.Add(Me.TextBoxDesempeños)
        Me.GroupBox4.Controls.Add(Me.TextBoxOtroIngreso)
        Me.GroupBox4.Controls.Add(Me.TextBoxSobrantes)
        Me.GroupBox4.Controls.Add(Me.Label62)
        Me.GroupBox4.Controls.Add(Me.TextBoxTotalArqueo)
        Me.GroupBox4.Controls.Add(Me.Label52)
        Me.GroupBox4.Controls.Add(Me.TextBoxInteresesPagos)
        Me.GroupBox4.Controls.Add(Me.Label51)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label41)
        Me.GroupBox4.Controls.Add(Me.TextBoxSaldoEnCaja)
        Me.GroupBox4.Controls.Add(Me.Label47)
        Me.GroupBox4.Controls.Add(Me.Label43)
        Me.GroupBox4.Location = New System.Drawing.Point(84, 154)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(535, 346)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(134, 16)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(197, 20)
        Me.Label58.TabIndex = 28
        Me.Label58.Text = "INGRESOS (ENTRADAS)"
        '
        'TextBoxVentas
        '
        Me.TextBoxVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxVentas.Location = New System.Drawing.Point(184, 107)
        Me.TextBoxVentas.Name = "TextBoxVentas"
        Me.TextBoxVentas.Size = New System.Drawing.Size(179, 26)
        Me.TextBoxVentas.TabIndex = 26
        Me.TextBoxVentas.Text = "0"
        '
        'TextBoxDesempeños
        '
        Me.TextBoxDesempeños.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDesempeños.Location = New System.Drawing.Point(184, 217)
        Me.TextBoxDesempeños.Name = "TextBoxDesempeños"
        Me.TextBoxDesempeños.Size = New System.Drawing.Size(179, 26)
        Me.TextBoxDesempeños.TabIndex = 15
        '
        'TextBoxOtroIngreso
        '
        Me.TextBoxOtroIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxOtroIngreso.Location = New System.Drawing.Point(184, 184)
        Me.TextBoxOtroIngreso.Name = "TextBoxOtroIngreso"
        Me.TextBoxOtroIngreso.Size = New System.Drawing.Size(179, 26)
        Me.TextBoxOtroIngreso.TabIndex = 7
        '
        'TextBoxSobrantes
        '
        Me.TextBoxSobrantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSobrantes.Location = New System.Drawing.Point(347, 296)
        Me.TextBoxSobrantes.Name = "TextBoxSobrantes"
        Me.TextBoxSobrantes.Size = New System.Drawing.Size(163, 26)
        Me.TextBoxSobrantes.TabIndex = 33
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(254, 298)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(87, 20)
        Me.Label62.TabIndex = 32
        Me.Label62.Text = "Sobrantes:"
        '
        'TextBoxTotalArqueo
        '
        Me.TextBoxTotalArqueo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotalArqueo.Location = New System.Drawing.Point(347, 263)
        Me.TextBoxTotalArqueo.Name = "TextBoxTotalArqueo"
        Me.TextBoxTotalArqueo.Size = New System.Drawing.Size(163, 26)
        Me.TextBoxTotalArqueo.TabIndex = 24
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(23, 107)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(159, 20)
        Me.Label52.TabIndex = 25
        Me.Label52.Text = "Ventas de mercancia"
        '
        'TextBoxInteresesPagos
        '
        Me.TextBoxInteresesPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxInteresesPagos.Location = New System.Drawing.Point(184, 143)
        Me.TextBoxInteresesPagos.Name = "TextBoxInteresesPagos"
        Me.TextBoxInteresesPagos.Size = New System.Drawing.Size(179, 26)
        Me.TextBoxInteresesPagos.TabIndex = 5
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.Location = New System.Drawing.Point(298, 265)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(48, 20)
        Me.Label51.TabIndex = 23
        Me.Label51.Text = "Total:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(66, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Saldo en caja:"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(31, 143)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(147, 20)
        Me.Label41.TabIndex = 1
        Me.Label41.Text = "Pagos de Intereses"
        '
        'TextBoxSaldoEnCaja
        '
        Me.TextBoxSaldoEnCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxSaldoEnCaja.Location = New System.Drawing.Point(184, 71)
        Me.TextBoxSaldoEnCaja.Name = "TextBoxSaldoEnCaja"
        Me.TextBoxSaldoEnCaja.Size = New System.Drawing.Size(179, 26)
        Me.TextBoxSaldoEnCaja.TabIndex = 4
        Me.TextBoxSaldoEnCaja.Text = "0"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.Location = New System.Drawing.Point(80, 216)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(96, 20)
        Me.Label47.TabIndex = 14
        Me.Label47.Text = "Desempeño"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(80, 182)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(96, 20)
        Me.Label43.TabIndex = 3
        Me.Label43.Text = "Otro ingreso"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(1024, 26)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(268, 25)
        Me.Label44.TabIndex = 9
        Me.Label44.Text = "Arqueo de Caja para el dia"
        '
        'LabelFechaActual
        '
        Me.LabelFechaActual.AutoSize = True
        Me.LabelFechaActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFechaActual.Location = New System.Drawing.Point(1025, 62)
        Me.LabelFechaActual.Name = "LabelFechaActual"
        Me.LabelFechaActual.Size = New System.Drawing.Size(103, 20)
        Me.LabelFechaActual.TabIndex = 27
        Me.LabelFechaActual.Text = "Fecha Actual"
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Gray
        Me.PictureBox10.Image = Global.MILENIO.My.Resources.Resources.icons8_venta_filled_60
        Me.PictureBox10.Location = New System.Drawing.Point(315, 46)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(122, 86)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox10.TabIndex = 45
        Me.PictureBox10.TabStop = False
        '
        'TabPageEmpeños
        '
        Me.TabPageEmpeños.AutoScroll = True
        Me.TabPageEmpeños.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TabPageEmpeños.Controls.Add(Me.Label56)
        Me.TabPageEmpeños.Controls.Add(Me.Panel1Agregar)
        Me.TabPageEmpeños.Controls.Add(Me.Label55)
        Me.TabPageEmpeños.Controls.Add(Me.Panel1ModificarProducto)
        Me.TabPageEmpeños.Controls.Add(Me.Panel7)
        Me.TabPageEmpeños.Controls.Add(Me.Panel1)
        Me.TabPageEmpeños.Controls.Add(Me.PictureModificarProducto)
        Me.TabPageEmpeños.Controls.Add(Me.PictureAgregarProducto)
        Me.TabPageEmpeños.Location = New System.Drawing.Point(4, 28)
        Me.TabPageEmpeños.Name = "TabPageEmpeños"
        Me.TabPageEmpeños.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageEmpeños.Size = New System.Drawing.Size(1332, 581)
        Me.TabPageEmpeños.TabIndex = 0
        Me.TabPageEmpeños.Text = "Productos"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.BackColor = System.Drawing.Color.Transparent
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(578, 35)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(147, 18)
        Me.Label56.TabIndex = 6
        Me.Label56.Text = "ModificarProducto"
        '
        'Panel1Agregar
        '
        Me.Panel1Agregar.BackColor = System.Drawing.Color.LightGray
        Me.Panel1Agregar.Controls.Add(Me.Label7)
        Me.Panel1Agregar.Controls.Add(Me.TextBoxCodigoEmp)
        Me.Panel1Agregar.Controls.Add(Me.Label6)
        Me.Panel1Agregar.Controls.Add(Me.Label5)
        Me.Panel1Agregar.Controls.Add(Me.Label4)
        Me.Panel1Agregar.Controls.Add(Me.Label3)
        Me.Panel1Agregar.Controls.Add(Me.TextBoxValor)
        Me.Panel1Agregar.Controls.Add(Me.TextBoxPeso)
        Me.Panel1Agregar.Controls.Add(Me.TextBoxDescripcion)
        Me.Panel1Agregar.Controls.Add(Me.TextBoxTipoProducto)
        Me.Panel1Agregar.Controls.Add(Me.Label2)
        Me.Panel1Agregar.Controls.Add(Me.BtnInsertarProducto)
        Me.Panel1Agregar.Controls.Add(Me.TextBoxIdProducto)
        Me.Panel1Agregar.Location = New System.Drawing.Point(271, 78)
        Me.Panel1Agregar.Name = "Panel1Agregar"
        Me.Panel1Agregar.Size = New System.Drawing.Size(961, 165)
        Me.Panel1Agregar.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(505, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Codigo Empeño:"
        '
        'TextBoxCodigoEmp
        '
        Me.TextBoxCodigoEmp.Location = New System.Drawing.Point(633, 97)
        Me.TextBoxCodigoEmp.Name = "TextBoxCodigoEmp"
        Me.TextBoxCodigoEmp.Size = New System.Drawing.Size(138, 22)
        Me.TextBoxCodigoEmp.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(40, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Valor:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(272, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Peso:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(530, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Descripcion:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(272, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tipo"
        '
        'TextBoxValor
        '
        Me.TextBoxValor.Location = New System.Drawing.Point(103, 90)
        Me.TextBoxValor.Name = "TextBoxValor"
        Me.TextBoxValor.Size = New System.Drawing.Size(159, 22)
        Me.TextBoxValor.TabIndex = 6
        '
        'TextBoxPeso
        '
        Me.TextBoxPeso.Location = New System.Drawing.Point(335, 94)
        Me.TextBoxPeso.Name = "TextBoxPeso"
        Me.TextBoxPeso.Size = New System.Drawing.Size(152, 22)
        Me.TextBoxPeso.TabIndex = 5
        '
        'TextBoxDescripcion
        '
        Me.TextBoxDescripcion.Location = New System.Drawing.Point(633, 41)
        Me.TextBoxDescripcion.Multiline = True
        Me.TextBoxDescripcion.Name = "TextBoxDescripcion"
        Me.TextBoxDescripcion.Size = New System.Drawing.Size(138, 43)
        Me.TextBoxDescripcion.TabIndex = 4
        '
        'TextBoxTipoProducto
        '
        Me.TextBoxTipoProducto.Location = New System.Drawing.Point(328, 43)
        Me.TextBoxTipoProducto.Name = "TextBoxTipoProducto"
        Me.TextBoxTipoProducto.Size = New System.Drawing.Size(159, 22)
        Me.TextBoxTipoProducto.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ID:"
        '
        'BtnInsertarProducto
        '
        Me.BtnInsertarProducto.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.BtnInsertarProducto.Location = New System.Drawing.Point(819, 44)
        Me.BtnInsertarProducto.Name = "BtnInsertarProducto"
        Me.BtnInsertarProducto.Size = New System.Drawing.Size(132, 68)
        Me.BtnInsertarProducto.TabIndex = 1
        Me.BtnInsertarProducto.Text = "INSERTAR"
        Me.BtnInsertarProducto.UseVisualStyleBackColor = False
        '
        'TextBoxIdProducto
        '
        Me.TextBoxIdProducto.Location = New System.Drawing.Point(103, 43)
        Me.TextBoxIdProducto.Name = "TextBoxIdProducto"
        Me.TextBoxIdProducto.Size = New System.Drawing.Size(159, 22)
        Me.TextBoxIdProducto.TabIndex = 0
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.BackColor = System.Drawing.Color.Transparent
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(327, 35)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(135, 18)
        Me.Label55.TabIndex = 5
        Me.Label55.Text = "AgregarProducto"
        '
        'Panel1ModificarProducto
        '
        Me.Panel1ModificarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(179, Byte), Integer), CType(CType(213, Byte), Integer))
        Me.Panel1ModificarProducto.Controls.Add(Me.Button2)
        Me.Panel1ModificarProducto.Controls.Add(Estado_productoLabel1)
        Me.Panel1ModificarProducto.Controls.Add(Me.Estado_productoTextBox1)
        Me.Panel1ModificarProducto.Controls.Add(Codigo_empeñoLabel1)
        Me.Panel1ModificarProducto.Controls.Add(Me.Codigo_empeñoTextBox1)
        Me.Panel1ModificarProducto.Controls.Add(ValorLabel)
        Me.Panel1ModificarProducto.Controls.Add(Me.ValorTextBox)
        Me.Panel1ModificarProducto.Controls.Add(PesoLabel)
        Me.Panel1ModificarProducto.Controls.Add(Me.PesoTextBox)
        Me.Panel1ModificarProducto.Controls.Add(DescripcionLabel)
        Me.Panel1ModificarProducto.Controls.Add(Me.DescripcionTextBox)
        Me.Panel1ModificarProducto.Controls.Add(TipoLabel)
        Me.Panel1ModificarProducto.Controls.Add(Me.TipoTextBox)
        Me.Panel1ModificarProducto.Controls.Add(Id_productoLabel)
        Me.Panel1ModificarProducto.Controls.Add(Me.Id_productoTextBox)
        Me.Panel1ModificarProducto.Location = New System.Drawing.Point(271, 78)
        Me.Panel1ModificarProducto.Name = "Panel1ModificarProducto"
        Me.Panel1ModificarProducto.Size = New System.Drawing.Size(961, 165)
        Me.Panel1ModificarProducto.TabIndex = 13
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(36, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 63)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Estado_productoTextBox1
        '
        Me.Estado_productoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "estado_producto", True))
        Me.Estado_productoTextBox1.Location = New System.Drawing.Point(508, 94)
        Me.Estado_productoTextBox1.Name = "Estado_productoTextBox1"
        Me.Estado_productoTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.Estado_productoTextBox1.TabIndex = 13
        '
        'Codigo_empeñoTextBox1
        '
        Me.Codigo_empeñoTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "codigo_empeño", True))
        Me.Codigo_empeñoTextBox1.Location = New System.Drawing.Point(264, 94)
        Me.Codigo_empeñoTextBox1.Name = "Codigo_empeñoTextBox1"
        Me.Codigo_empeñoTextBox1.Size = New System.Drawing.Size(100, 22)
        Me.Codigo_empeñoTextBox1.TabIndex = 11
        '
        'ValorTextBox
        '
        Me.ValorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "valor", True))
        Me.ValorTextBox.Location = New System.Drawing.Point(700, 95)
        Me.ValorTextBox.Name = "ValorTextBox"
        Me.ValorTextBox.Size = New System.Drawing.Size(100, 22)
        Me.ValorTextBox.TabIndex = 9
        '
        'PesoTextBox
        '
        Me.PesoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "peso", True))
        Me.PesoTextBox.Location = New System.Drawing.Point(761, 40)
        Me.PesoTextBox.Name = "PesoTextBox"
        Me.PesoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.PesoTextBox.TabIndex = 7
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(595, 40)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(100, 22)
        Me.DescripcionTextBox.TabIndex = 5
        '
        'TipoTextBox
        '
        Me.TipoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "Tipo", True))
        Me.TipoTextBox.Location = New System.Drawing.Point(402, 40)
        Me.TipoTextBox.Name = "TipoTextBox"
        Me.TipoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.TipoTextBox.TabIndex = 3
        '
        'Id_productoTextBox
        '
        Me.Id_productoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductoBindingSource, "id_producto", True))
        Me.Id_productoTextBox.Location = New System.Drawing.Point(240, 40)
        Me.Id_productoTextBox.Name = "Id_productoTextBox"
        Me.Id_productoTextBox.Size = New System.Drawing.Size(100, 22)
        Me.Id_productoTextBox.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(3, 3)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(208, 563)
        Me.Panel7.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ToolStrip2)
        Me.Panel1.Controls.Add(Me.ProductoDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(271, 249)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 329)
        Me.Panel1.TabIndex = 7
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripTextBoxBuscarProd, Me.ToolStripButton4})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(951, 25)
        Me.ToolStrip2.TabIndex = 6
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.Color.Gold
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.MILENIO.My.Resources.Resources.search_48px
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "ToolStripButton3"
        '
        'ToolStripTextBoxBuscarProd
        '
        Me.ToolStripTextBoxBuscarProd.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripTextBoxBuscarProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ToolStripTextBoxBuscarProd.Name = "ToolStripTextBoxBuscarProd"
        Me.ToolStripTextBoxBuscarProd.Size = New System.Drawing.Size(130, 25)
        Me.ToolStripTextBoxBuscarProd.Tag = "Ingrese un ID o Cod"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.BackColor = System.Drawing.Color.Gainsboro
        Me.ToolStripButton4.Image = Global.MILENIO.My.Resources.Resources.synchronize_64px
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(63, 22)
        Me.ToolStripButton4.Text = "refresh"
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(156, 36)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.Size = New System.Drawing.Size(644, 279)
        Me.ProductoDataGridView.TabIndex = 5
        '
        'PictureModificarProducto
        '
        Me.PictureModificarProducto.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureModificarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureModificarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureModificarProducto.Image = CType(resources.GetObject("PictureModificarProducto.Image"), System.Drawing.Image)
        Me.PictureModificarProducto.Location = New System.Drawing.Point(511, 20)
        Me.PictureModificarProducto.Name = "PictureModificarProducto"
        Me.PictureModificarProducto.Size = New System.Drawing.Size(50, 50)
        Me.PictureModificarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureModificarProducto.TabIndex = 4
        Me.PictureModificarProducto.TabStop = False
        '
        'PictureAgregarProducto
        '
        Me.PictureAgregarProducto.BackColor = System.Drawing.Color.SteelBlue
        Me.PictureAgregarProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureAgregarProducto.Image = CType(resources.GetObject("PictureAgregarProducto.Image"), System.Drawing.Image)
        Me.PictureAgregarProducto.Location = New System.Drawing.Point(271, 23)
        Me.PictureAgregarProducto.Name = "PictureAgregarProducto"
        Me.PictureAgregarProducto.Size = New System.Drawing.Size(50, 50)
        Me.PictureAgregarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureAgregarProducto.TabIndex = 2
        Me.PictureAgregarProducto.TabStop = False
        '
        'TabPageClientes
        '
        Me.TabPageClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TabPageClientes.Controls.Add(ApellidosLabel)
        Me.TabPageClientes.Controls.Add(Me.ApellidosTextBox)
        Me.TabPageClientes.Controls.Add(NombreLabel)
        Me.TabPageClientes.Controls.Add(Me.NombreTextBox)
        Me.TabPageClientes.Controls.Add(CorreoLabel)
        Me.TabPageClientes.Controls.Add(Me.CorreoTextBox)
        Me.TabPageClientes.Controls.Add(DireccionLabel)
        Me.TabPageClientes.Controls.Add(Me.DireccionTextBox)
        Me.TabPageClientes.Controls.Add(TelefonoLabel)
        Me.TabPageClientes.Controls.Add(Me.TelefonoTextBox)
        Me.TabPageClientes.Controls.Add(Lugar_expedicionLabel)
        Me.TabPageClientes.Controls.Add(Me.Lugar_expedicionTextBox)
        Me.TabPageClientes.Controls.Add(Cedula_clienteLabel1)
        Me.TabPageClientes.Controls.Add(Me.Cedula_clienteTextBox1)
        Me.TabPageClientes.Controls.Add(Me.Label57)
        Me.TabPageClientes.Controls.Add(Me.ClientesDataGridView)
        Me.TabPageClientes.Controls.Add(Me.btnAgregarCliente)
        Me.TabPageClientes.Location = New System.Drawing.Point(4, 28)
        Me.TabPageClientes.Name = "TabPageClientes"
        Me.TabPageClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageClientes.Size = New System.Drawing.Size(1332, 581)
        Me.TabPageClientes.TabIndex = 1
        Me.TabPageClientes.Text = "Clientes"
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "apellidos", True))
        Me.ApellidosTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApellidosTextBox.Location = New System.Drawing.Point(925, 378)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(140, 24)
        Me.ApellidosTextBox.TabIndex = 16
        '
        'NombreTextBox
        '
        Me.NombreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nombre", True))
        Me.NombreTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreTextBox.Location = New System.Drawing.Point(925, 337)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(140, 24)
        Me.NombreTextBox.TabIndex = 14
        '
        'CorreoTextBox
        '
        Me.CorreoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "correo", True))
        Me.CorreoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorreoTextBox.Location = New System.Drawing.Point(925, 298)
        Me.CorreoTextBox.Name = "CorreoTextBox"
        Me.CorreoTextBox.Size = New System.Drawing.Size(140, 24)
        Me.CorreoTextBox.TabIndex = 12
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "direccion", True))
        Me.DireccionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionTextBox.Location = New System.Drawing.Point(925, 259)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(140, 24)
        Me.DireccionTextBox.TabIndex = 10
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "telefono", True))
        Me.TelefonoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(925, 221)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(140, 24)
        Me.TelefonoTextBox.TabIndex = 8
        '
        'Lugar_expedicionTextBox
        '
        Me.Lugar_expedicionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "lugar_expedicion", True))
        Me.Lugar_expedicionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lugar_expedicionTextBox.Location = New System.Drawing.Point(925, 186)
        Me.Lugar_expedicionTextBox.Name = "Lugar_expedicionTextBox"
        Me.Lugar_expedicionTextBox.Size = New System.Drawing.Size(140, 24)
        Me.Lugar_expedicionTextBox.TabIndex = 6
        '
        'Cedula_clienteTextBox1
        '
        Me.Cedula_clienteTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cedula_cliente", True))
        Me.Cedula_clienteTextBox1.Enabled = False
        Me.Cedula_clienteTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cedula_clienteTextBox1.Location = New System.Drawing.Point(927, 149)
        Me.Cedula_clienteTextBox1.Name = "Cedula_clienteTextBox1"
        Me.Cedula_clienteTextBox1.Size = New System.Drawing.Size(138, 24)
        Me.Cedula_clienteTextBox1.TabIndex = 4
        '
        'Label57
        '
        Me.Label57.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label57.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.White
        Me.Label57.Location = New System.Drawing.Point(39, 56)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(743, 45)
        Me.Label57.TabIndex = 2
        Me.Label57.Text = "Clientes Registrados"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(39, 99)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.Size = New System.Drawing.Size(743, 339)
        Me.ClientesDataGridView.TabIndex = 1
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarCliente.Location = New System.Drawing.Point(874, 99)
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(144, 34)
        Me.btnAgregarCliente.TabIndex = 1
        Me.btnAgregarCliente.Text = "Modificar"
        Me.btnAgregarCliente.UseVisualStyleBackColor = True
        '
        'TabPageNotificaciones
        '
        Me.TabPageNotificaciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TabPageNotificaciones.Controls.Add(Me.Label69)
        Me.TabPageNotificaciones.Controls.Add(Me.RichTextBoxMessage)
        Me.TabPageNotificaciones.Controls.Add(Me.Button1)
        Me.TabPageNotificaciones.Controls.Add(Me.RichTextBox1)
        Me.TabPageNotificaciones.Controls.Add(Me.PictureBox8)
        Me.TabPageNotificaciones.Location = New System.Drawing.Point(4, 28)
        Me.TabPageNotificaciones.Name = "TabPageNotificaciones"
        Me.TabPageNotificaciones.Size = New System.Drawing.Size(1332, 581)
        Me.TabPageNotificaciones.TabIndex = 10
        Me.TabPageNotificaciones.Text = "NOTIFICACIONES"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(70, 171)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(65, 20)
        Me.Label69.TabIndex = 4
        Me.Label69.Text = "Invitado"
        '
        'RichTextBoxMessage
        '
        Me.RichTextBoxMessage.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RichTextBoxMessage.Location = New System.Drawing.Point(310, 292)
        Me.RichTextBoxMessage.Name = "RichTextBoxMessage"
        Me.RichTextBoxMessage.Size = New System.Drawing.Size(537, 66)
        Me.RichTextBoxMessage.TabIndex = 2
        Me.RichTextBoxMessage.Text = ""
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button1.Location = New System.Drawing.Point(185, 292)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Enviar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(185, 59)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(748, 227)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.MILENIO.My.Resources.Resources.icons8_usuario_de_género_neutro_100
        Me.PictureBox8.Location = New System.Drawing.Point(53, 59)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox8.TabIndex = 3
        Me.PictureBox8.TabStop = False
        '
        'TabPageBalances
        '
        Me.TabPageBalances.BackColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.TabPageBalances.Controls.Add(Me.BunifuCards2)
        Me.TabPageBalances.Controls.Add(Me.BunifuCards1)
        Me.TabPageBalances.Location = New System.Drawing.Point(4, 28)
        Me.TabPageBalances.Name = "TabPageBalances"
        Me.TabPageBalances.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageBalances.Size = New System.Drawing.Size(1332, 581)
        Me.TabPageBalances.TabIndex = 13
        Me.TabPageBalances.Text = "Balances"
        '
        'BunifuCards2
        '
        Me.BunifuCards2.BackColor = System.Drawing.Color.White
        Me.BunifuCards2.BorderRadius = 5
        Me.BunifuCards2.BottomSahddow = True
        Me.BunifuCards2.color = System.Drawing.Color.Khaki
        Me.BunifuCards2.Controls.Add(Me.Label98)
        Me.BunifuCards2.Controls.Add(Me.DataGridViewBalance)
        Me.BunifuCards2.LeftSahddow = False
        Me.BunifuCards2.Location = New System.Drawing.Point(28, 183)
        Me.BunifuCards2.Name = "BunifuCards2"
        Me.BunifuCards2.RightSahddow = True
        Me.BunifuCards2.ShadowDepth = 20
        Me.BunifuCards2.Size = New System.Drawing.Size(1283, 397)
        Me.BunifuCards2.TabIndex = 1
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BunifuCards1.BorderRadius = 8
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.Silver
        Me.BunifuCards1.Controls.Add(Me.Label97)
        Me.BunifuCards1.Controls.Add(Me.Label96)
        Me.BunifuCards1.Controls.Add(Me.BunifuFlatButton3)
        Me.BunifuCards1.Controls.Add(Me.txtAñoBalance)
        Me.BunifuCards1.Controls.Add(Me.BunifuFlatButton2)
        Me.BunifuCards1.Controls.Add(Me.BunifuFlatButton1)
        Me.BunifuCards1.Controls.Add(Me.ComboBoxMeses)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(28, 52)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(1283, 125)
        Me.BunifuCards1.TabIndex = 0
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Active = False
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "Realizar Balance"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = Nothing
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 90.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(908, 36)
        Me.BunifuFlatButton3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(278, 36)
        Me.BunifuFlatButton3.TabIndex = 6
        Me.BunifuFlatButton3.Text = "Realizar Balance"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtAñoBalance
        '
        Me.txtAñoBalance.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtAñoBalance.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAñoBalance.Location = New System.Drawing.Point(539, 71)
        Me.txtAñoBalance.Multiline = True
        Me.txtAñoBalance.Name = "txtAñoBalance"
        Me.txtAñoBalance.Size = New System.Drawing.Size(277, 23)
        Me.txtAñoBalance.TabIndex = 5
        '
        'BunifuFlatButton2
        '
        Me.BunifuFlatButton2.Active = False
        Me.BunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton2.BackColor = System.Drawing.Color.Silver
        Me.BunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton2.BorderRadius = 0
        Me.BunifuFlatButton2.ButtonText = "Año"
        Me.BunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton2.Iconimage = Nothing
        Me.BunifuFlatButton2.Iconimage_right = Nothing
        Me.BunifuFlatButton2.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton2.Iconimage_Selected = Nothing
        Me.BunifuFlatButton2.IconMarginLeft = 0
        Me.BunifuFlatButton2.IconMarginRight = 0
        Me.BunifuFlatButton2.IconRightVisible = True
        Me.BunifuFlatButton2.IconRightZoom = 0R
        Me.BunifuFlatButton2.IconVisible = True
        Me.BunifuFlatButton2.IconZoom = 90.0R
        Me.BunifuFlatButton2.IsTab = False
        Me.BunifuFlatButton2.Location = New System.Drawing.Point(493, 70)
        Me.BunifuFlatButton2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BunifuFlatButton2.Name = "BunifuFlatButton2"
        Me.BunifuFlatButton2.Normalcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton2.OnHovercolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton2.selected = False
        Me.BunifuFlatButton2.Size = New System.Drawing.Size(48, 25)
        Me.BunifuFlatButton2.TabIndex = 4
        Me.BunifuFlatButton2.Text = "Año"
        Me.BunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton2.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton2.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Active = False
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.Color.Silver
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Mes"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(58, 69)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Silver
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(41, 26)
        Me.BunifuFlatButton1.TabIndex = 2
        Me.BunifuFlatButton1.Text = "Mes"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.Black
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ComboBoxMeses
        '
        Me.ComboBoxMeses.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxMeses.FormattingEnabled = True
        Me.ComboBoxMeses.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.ComboBoxMeses.Location = New System.Drawing.Point(97, 69)
        Me.ComboBoxMeses.Name = "ComboBoxMeses"
        Me.ComboBoxMeses.Size = New System.Drawing.Size(285, 25)
        Me.ComboBoxMeses.TabIndex = 1
        '
        'StatusStripEstado
        '
        Me.StatusStripEstado.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StatusStripEstado.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStripEstado.Location = New System.Drawing.Point(0, 727)
        Me.StatusStripEstado.Name = "StatusStripEstado"
        Me.StatusStripEstado.Size = New System.Drawing.Size(1370, 22)
        Me.StatusStripEstado.TabIndex = 4
        Me.StatusStripEstado.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(99, 17)
        Me.ToolStripStatusLabel1.Text = "Ningun cambio..."
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(107, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 37)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "        MILENIO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "COMPRA Y VENTA"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'MenuDlesplegable
        '
        Me.MenuDlesplegable.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.MenuDlesplegable.Name = "MenuDlesplegable"
        Me.MenuDlesplegable.Size = New System.Drawing.Size(126, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(125, 22)
        Me.ToolStripMenuItem1.Text = "Ver"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(125, 22)
        Me.ToolStripMenuItem2.Text = "Modificar"
        '
        'DateTimePickerActual
        '
        Me.DateTimePickerActual.Location = New System.Drawing.Point(1153, -2)
        Me.DateTimePickerActual.Name = "DateTimePickerActual"
        Me.DateTimePickerActual.Size = New System.Drawing.Size(201, 20)
        Me.DateTimePickerActual.TabIndex = 7
        Me.DateTimePickerActual.Visible = False
        '
        'Labelhora
        '
        Me.Labelhora.AutoSize = True
        Me.Labelhora.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelhora.ForeColor = System.Drawing.Color.White
        Me.Labelhora.Location = New System.Drawing.Point(975, 9)
        Me.Labelhora.Name = "Labelhora"
        Me.Labelhora.Size = New System.Drawing.Size(103, 45)
        Me.Labelhora.TabIndex = 8
        Me.Labelhora.Text = "Hora:"
        '
        'LabelFecha2
        '
        Me.LabelFecha2.AutoSize = True
        Me.LabelFecha2.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFecha2.ForeColor = System.Drawing.Color.White
        Me.LabelFecha2.Location = New System.Drawing.Point(938, 51)
        Me.LabelFecha2.Name = "LabelFecha2"
        Me.LabelFecha2.Size = New System.Drawing.Size(76, 25)
        Me.LabelFecha2.TabIndex = 9
        Me.LabelFecha2.Text = "Fecha:"
        '
        'Hora
        '
        Me.Hora.Enabled = True
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.PowderBlue
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Info"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.FillWeight = 120.0!
        Me.DataGridViewImageColumn1.HeaderText = "Vender"
        Me.DataGridViewImageColumn1.Image = Global.MILENIO.My.Resources.Resources.icons8_pagado_48
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.MinimumWidth = 8
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MILENIO.My.Resources.Resources.Sin_título_2_Mesa_de_trabajo_1
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 71)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ProductoBindingSource1
        '
        Me.ProductoBindingSource1.DataMember = "empeñoproducto"
        Me.ProductoBindingSource1.DataSource = Me.EmpeñoBindingSource
        '
        'Label96
        '
        Me.Label96.AutoSize = True
        Me.Label96.Location = New System.Drawing.Point(390, 74)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(53, 16)
        Me.Label96.TabIndex = 7
        Me.Label96.Text = "Label96"
        '
        'DataGridViewBalance
        '
        Me.DataGridViewBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewBalance.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Empeños1, Me.Abonos1, Me.Ventas1, Me.Gastos1, Me.Oro1, Me.InteresesNoPagos1, Me.Ganancias1})
        Me.DataGridViewBalance.Location = New System.Drawing.Point(76, 79)
        Me.DataGridViewBalance.Name = "DataGridViewBalance"
        Me.DataGridViewBalance.Size = New System.Drawing.Size(1095, 107)
        Me.DataGridViewBalance.TabIndex = 1
        '
        'Empeños1
        '
        Me.Empeños1.HeaderText = "Empeños"
        Me.Empeños1.Name = "Empeños1"
        Me.Empeños1.Width = 150
        '
        'Abonos1
        '
        Me.Abonos1.HeaderText = "Abonos"
        Me.Abonos1.Name = "Abonos1"
        Me.Abonos1.Width = 150
        '
        'Ventas1
        '
        Me.Ventas1.HeaderText = "Ventas"
        Me.Ventas1.Name = "Ventas1"
        Me.Ventas1.Width = 150
        '
        'Gastos1
        '
        Me.Gastos1.HeaderText = "Gastos"
        Me.Gastos1.Name = "Gastos1"
        Me.Gastos1.Width = 150
        '
        'Oro1
        '
        Me.Oro1.HeaderText = "Oro"
        Me.Oro1.Name = "Oro1"
        Me.Oro1.Width = 150
        '
        'InteresesNoPagos1
        '
        Me.InteresesNoPagos1.HeaderText = "InteresesNoPagos"
        Me.InteresesNoPagos1.Name = "InteresesNoPagos1"
        Me.InteresesNoPagos1.Width = 150
        '
        'Ganancias1
        '
        Me.Ganancias1.HeaderText = "Ganancias"
        Me.Ganancias1.Name = "Ganancias1"
        Me.Ganancias1.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "codigo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "valor_empeño"
        Me.DataGridViewTextBoxColumn8.HeaderText = "valor_empeño"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "fecha_llegada"
        Me.DataGridViewTextBoxColumn9.HeaderText = "fecha_llegada"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 80
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fecha_salida"
        Me.DataGridViewTextBoxColumn10.HeaderText = "fecha_salida"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 70
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "dia_empeño"
        Me.DataGridViewTextBoxColumn11.HeaderText = "dia_empeño"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "interes"
        Me.DataGridViewTextBoxColumn12.HeaderText = "interes"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "valor_total"
        Me.DataGridViewTextBoxColumn13.HeaderText = "valor_total"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "estado_producto"
        Me.DataGridViewTextBoxColumn14.HeaderText = "estado_producto"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "cedula_cliente"
        Me.DataGridViewTextBoxColumn15.HeaderText = "cedula_cliente"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "mesesPagados"
        Me.DataGridViewTextBoxColumn27.HeaderText = "mesesPagados"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'EmpeñoBindingSource
        '
        Me.EmpeñoBindingSource.DataMember = "empeño"
        Me.EmpeñoBindingSource.DataSource = Me.BDMIDataSet
        '
        'BDMIDataSet
        '
        Me.BDMIDataSet.DataSetName = "BDMIDataSet"
        Me.BDMIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "id_retiro"
        Me.DataGridViewTextBoxColumn21.HeaderText = "id_retiro"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "fecha_retiro"
        Me.DataGridViewTextBoxColumn22.HeaderText = "fecha_retiro"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "hora_retiro"
        Me.DataGridViewTextBoxColumn23.HeaderText = "hora_retiro"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn24.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "id_empeño"
        Me.DataGridViewTextBoxColumn31.HeaderText = "id_empeño"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "valor"
        Me.DataGridViewTextBoxColumn32.HeaderText = "valor"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'RetiroBindingSource
        '
        Me.RetiroBindingSource.DataMember = "retiro"
        Me.RetiroBindingSource.DataSource = Me.BDMIDataSet
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn28.HeaderText = "codigo"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "peso"
        Me.DataGridViewTextBoxColumn29.HeaderText = "peso"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "valor"
        Me.DataGridViewTextBoxColumn30.HeaderText = "valor"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn33.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'OroBindingSource
        '
        Me.OroBindingSource.DataMember = "Oro"
        Me.OroBindingSource.DataSource = Me.BDMIDataSet
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "fecha"
        Me.DataGridViewTextBoxColumn35.HeaderText = "fecha"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "valor"
        Me.DataGridViewTextBoxColumn36.HeaderText = "valor"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "Descripcion"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Descripcion"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.Width = 200
        '
        'GastoBindingSource
        '
        Me.GastoBindingSource.DataMember = "gasto"
        Me.GastoBindingSource.DataSource = Me.BDMIDataSet
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.BDMIDataSet
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_producto"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_producto"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "peso"
        Me.DataGridViewTextBoxColumn4.HeaderText = "peso"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "valor"
        Me.DataGridViewTextBoxColumn5.HeaderText = "valor"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "codigo_empeño"
        Me.DataGridViewTextBoxColumn6.HeaderText = "codigo_empeño"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.BDMIDataSet
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "cedula_cliente"
        Me.DataGridViewTextBoxColumn16.HeaderText = "cedula_cliente"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "lugar_expedicion"
        Me.DataGridViewTextBoxColumn17.HeaderText = "lugar_expedicion"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn18.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn19.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "correo"
        Me.DataGridViewTextBoxColumn20.HeaderText = "correo"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn25.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "apellidos"
        Me.DataGridViewTextBoxColumn26.HeaderText = "apellidos"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'AbonoBindingSource
        '
        Me.AbonoBindingSource.DataMember = "abono"
        Me.AbonoBindingSource.DataSource = Me.BDMIDataSet
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.abonoTableAdapter = Nothing
        Me.TableAdapterManager.arqueoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.empeñoTableAdapter = Nothing
        Me.TableAdapterManager.gastoTableAdapter = Nothing
        Me.TableAdapterManager.mensajesTableAdapter = Nothing
        Me.TableAdapterManager.movimientosTableAdapter = Nothing
        Me.TableAdapterManager.OroTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.retiroTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MILENIO.BDMIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'EmpeñoTableAdapter
        '
        Me.EmpeñoTableAdapter.ClearBeforeFill = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'AbonoTableAdapter
        '
        Me.AbonoTableAdapter.ClearBeforeFill = True
        '
        'EmpeñoTableAdapter1
        '
        Me.EmpeñoTableAdapter1.ClearBeforeFill = True
        '
        'EmpeñoBindingSource1
        '
        Me.EmpeñoBindingSource1.DataMember = "empeño"
        Me.EmpeñoBindingSource1.DataSource = Me.BDMIDataSet
        '
        'OroTableAdapter
        '
        Me.OroTableAdapter.ClearBeforeFill = True
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "venta"
        Me.VentaBindingSource.DataSource = Me.BDMIDataSet
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.BDMIDataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'ArqueoBindingSource
        '
        Me.ArqueoBindingSource.DataMember = "arqueo"
        Me.ArqueoBindingSource.DataSource = Me.BDMIDataSet
        '
        'ArqueoTableAdapter
        '
        Me.ArqueoTableAdapter.ClearBeforeFill = True
        '
        'MensajesBindingSource
        '
        Me.MensajesBindingSource.DataMember = "mensajes"
        Me.MensajesBindingSource.DataSource = Me.BDMIDataSet
        '
        'MensajesTableAdapter
        '
        Me.MensajesTableAdapter.ClearBeforeFill = True
        '
        'RetiroTableAdapter
        '
        Me.RetiroTableAdapter.ClearBeforeFill = True
        '
        'GastoTableAdapter
        '
        Me.GastoTableAdapter.ClearBeforeFill = True
        '
        'MovimientosBindingSource
        '
        Me.MovimientosBindingSource.DataMember = "movimientos"
        Me.MovimientosBindingSource.DataSource = Me.BDMIDataSet
        '
        'MovimientosTableAdapter
        '
        Me.MovimientosTableAdapter.ClearBeforeFill = True
        '
        'Label97
        '
        Me.Label97.AutoSize = True
        Me.Label97.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(58, 36)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(144, 19)
        Me.Label97.TabIndex = 8
        Me.Label97.Text = "Filtrar Resultados"
        '
        'Label98
        '
        Me.Label98.AutoSize = True
        Me.Label98.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(79, 37)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(133, 19)
        Me.Label98.TabIndex = 9
        Me.Label98.Text = "Balance del Mes"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.LabelFecha2)
        Me.Controls.Add(Me.Labelhora)
        Me.Controls.Add(Me.DateTimePickerActual)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStripEstado)
        Me.Controls.Add(Me.TabControlPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.TabControlPrincipal.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.EmpeñoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBoxActualizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxModificar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageDesempeños.ResumeLayout(False)
        CType(Me.RetiroDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.TabPageIntereses.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8Buscar.ResumeLayout(False)
        Me.Panel8Buscar.PerformLayout()
        CType(Me.DataGridViewResultadoAb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel7Abono.ResumeLayout(False)
        Me.Panel7Abono.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPageOro.ResumeLayout(False)
        CType(Me.OroDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageGastos.ResumeLayout(False)
        CType(Me.GastoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        Me.TabPageVentas.ResumeLayout(False)
        CType(Me.DataGridViewProductosDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageArqueo.ResumeLayout(False)
        Me.TabPageArqueo.PerformLayout()
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.GraficoReporteMes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.PanelDetallesArq.ResumeLayout(False)
        Me.PanelDetallesArq.PerformLayout()
        Me.Panel13Oro.ResumeLayout(False)
        Me.Panel13Oro.PerformLayout()
        CType(Me.DGVOro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13Gasto.ResumeLayout(False)
        Me.Panel13Gasto.PerformLayout()
        CType(Me.DGVgasto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13Abono.ResumeLayout(False)
        Me.Panel13Abono.PerformLayout()
        CType(Me.DGVabono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13Retiro.ResumeLayout(False)
        Me.Panel13Retiro.PerformLayout()
        CType(Me.DGVretiro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13Empeño.ResumeLayout(False)
        Me.Panel13Empeño.PerformLayout()
        CType(Me.DGVEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel13Ventas.ResumeLayout(False)
        Me.Panel13Ventas.PerformLayout()
        CType(Me.DGVVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.PictureBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxArqueo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelArqueo.ResumeLayout(False)
        Me.PanelArqueo.PerformLayout()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageEmpeños.ResumeLayout(False)
        Me.TabPageEmpeños.PerformLayout()
        Me.Panel1Agregar.ResumeLayout(False)
        Me.Panel1Agregar.PerformLayout()
        Me.Panel1ModificarProducto.ResumeLayout(False)
        Me.Panel1ModificarProducto.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureModificarProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureAgregarProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageClientes.ResumeLayout(False)
        Me.TabPageClientes.PerformLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageNotificaciones.ResumeLayout(False)
        Me.TabPageNotificaciones.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageBalances.ResumeLayout(False)
        Me.BunifuCards2.ResumeLayout(False)
        Me.BunifuCards2.PerformLayout()
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        Me.StatusStripEstado.ResumeLayout(False)
        Me.StatusStripEstado.PerformLayout()
        Me.MenuDlesplegable.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpeñoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDMIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetiroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GastoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbonoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpeñoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArqueoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MensajesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControlPrincipal As TabControl
    Friend WithEvents TabPageEmpeños As TabPage
    Friend WithEvents Panel1Agregar As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxCodigoEmp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxValor As TextBox
    Friend WithEvents TextBoxPeso As TextBox
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents TextBoxTipoProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnInsertarProducto As Button
    Friend WithEvents TextBoxIdProducto As TextBox
    Friend WithEvents PictureModificarProducto As PictureBox
    Friend WithEvents PictureAgregarProducto As PictureBox
    Friend WithEvents TabPageClientes As TabPage
    Friend WithEvents StatusStripEstado As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BDMIDataSet As BDMIDataSet
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoTableAdapter As BDMIDataSetTableAdapters.productoTableAdapter
    Friend WithEvents TableAdapterManager As BDMIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents EmpeñoBindingSource As BindingSource
    Friend WithEvents EmpeñoTableAdapter As BDMIDataSetTableAdapters.empeñoTableAdapter
    Friend WithEvents ProductoBindingSource1 As BindingSource
    Friend WithEvents ProductoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As BDMIDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents AbonoTableAdapter As BDMIDataSetTableAdapters.abonoTableAdapter
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents Cedula_clienteTextBox As TextBox
    Friend WithEvents Estado_productoTextBox As TextBox
    Friend WithEvents Valor_totalTextBox As TextBox
    Friend WithEvents InteresTextBox As TextBox
    Friend WithEvents Dia_empeñoTextBox As TextBox
    Friend WithEvents Fecha_salidaDateTimePicker As DateTimePicker
    Friend WithEvents Fecha_llegadaDateTimePicker As DateTimePicker
    Friend WithEvents Valor_empeñoTextBox As TextBox
    Friend WithEvents btnAgregarCliente As Button
    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents AbonoBindingSource As BindingSource
    Friend WithEvents PictureBoxModificar As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label22 As Label
    Friend WithEvents TextBoxTelVale As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TextBoxResideVale As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBoxExpedidaVale As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBoxCCVale As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBoxNombreVale As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBoxPrecioEntregado As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents FechaIniVale As DateTimePicker
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBoxCodigoVale As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TextBoxValorTotalVale As TextBox
    Friend WithEvents TextBoxInteresVale As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents FechaSalidaVale As DateTimePicker
    Friend WithEvents Label26 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxApellidoVale As TextBox
    Friend WithEvents TextBoxCorreoVale As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents ListViewProductos As ListView
    Friend WithEvents ColumnTipo As ColumnHeader
    Friend WithEvents ColumnPeso As ColumnHeader
    Friend WithEvents ColumnPrecio As ColumnHeader
    Friend WithEvents ColumnDescripcion As ColumnHeader
    Friend WithEvents Button6 As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBoxActualizar As PictureBox
    Friend WithEvents ButtonModificarEmpeño As Button
    Friend WithEvents MenuDlesplegable As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DateTimePickerActual As DateTimePicker
    Friend WithEvents EmpeñoTableAdapter1 As BDMIDataSetTableAdapters.empeñoTableAdapter
    Friend WithEvents TabPageIntereses As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label36 As Label
    Friend WithEvents LabelMesesPagados As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents LabelUltimoAbono As Label
    Friend WithEvents LabelFechaEmp As Label
    Friend WithEvents TextBoxMesesPagar As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents TextBoxInfoEmp As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents TabPageOro As TabPage
    Friend WithEvents LabelNombreInt As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents LabelPrecioApagar As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents LabelMontoEmpeño As Label
    Friend WithEvents LabelPrecioPagar2 As Label
    Friend WithEvents LabelCorreo As Label
    Friend WithEvents EmpeñoBindingSource1 As BindingSource
    Friend WithEvents EmpeñoDataGridView As DataGridView
    Friend WithEvents Label37 As Label
    Friend WithEvents TextBoxGramosOro As TextBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents TextBoxPrecioCompra As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents ButtonCompraOro As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents OroBindingSource As BindingSource
    Friend WithEvents OroTableAdapter As BDMIDataSetTableAdapters.OroTableAdapter
    Friend WithEvents TabPageVentas As TabPage
    Friend WithEvents DataGridViewProductosDisponibles As DataGridView
    Friend WithEvents ButtonListarProductos As Button
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents TabPageArqueo As TabPage
    Friend WithEvents Label44 As Label
    Friend WithEvents TextBoxOtroIngreso As TextBox
    Friend WithEvents TextBoxInteresesPagos As TextBox
    Friend WithEvents TextBoxSaldoEnCaja As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxSaldoReal As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents ButtonRealizarArqueo As Button
    Friend WithEvents TextBoxGastos As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents TextBoxCompraOro As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents TextBoxDesempeños As TextBox
    Friend WithEvents Label47 As Label
    Friend WithEvents TextBoxEmpeño As TextBox
    Friend WithEvents Label45 As Label
    Friend WithEvents TextBoxTotalArqueo As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents TextBoxVentas As TextBox
    Friend WithEvents Label52 As Label
    Friend WithEvents VentaBindingSource As BindingSource
    Friend WithEvents VentaTableAdapter As BDMIDataSetTableAdapters.ventaTableAdapter
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As BDMIDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents Panel7Abono As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8Buscar As Panel
    Friend WithEvents Label54 As Label
    Friend WithEvents Label53 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripTextBoxDato As ToolStripTextBox
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents DataGridViewResultadoAb As DataGridView
    Friend WithEvents LabelNumEmpeños As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel1ModificarProducto As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Estado_productoTextBox1 As TextBox
    Friend WithEvents Codigo_empeñoTextBox1 As TextBox
    Friend WithEvents ValorTextBox As TextBox
    Friend WithEvents PesoTextBox As TextBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents TipoTextBox As TextBox
    Friend WithEvents Id_productoTextBox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripTextBoxBuscarProd As ToolStripTextBox
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents Label57 As Label
    Friend WithEvents LabelFechaActual As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label58 As Label
    Friend WithEvents ArqueoBindingSource As BindingSource
    Friend WithEvents ArqueoTableAdapter As BDMIDataSetTableAdapters.arqueoTableAdapter
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TextBoxPrestamos As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents TextBoxFaltantes As TextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents TextBoxSobrantes As TextBox
    Friend WithEvents Label62 As Label
    Friend WithEvents LabelSaldoUltimoArq As Label
    Friend WithEvents LabelFechaUltimoArq As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PanelDetallesArq As Panel
    Friend WithEvents PanelArqueo As Panel
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents CorreoTextBox As TextBox
    Friend WithEvents DireccionTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents Lugar_expedicionTextBox As TextBox
    Friend WithEvents Cedula_clienteTextBox1 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBoxArqueo As PictureBox
    Friend WithEvents Label68 As Label
    Friend WithEvents MensajesBindingSource As BindingSource
    Friend WithEvents MensajesTableAdapter As BDMIDataSetTableAdapters.mensajesTableAdapter
    Friend WithEvents TabPageNotificaciones As TabPage
    Friend WithEvents Label69 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents RichTextBoxMessage As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ComboBox123 As ComboBox
    Friend WithEvents TabPageDesempeños As TabPage
    Friend WithEvents TextBoxBuscarDesempeño As TextBox
    Friend WithEvents ButtonDesempeñar As Button
    Friend WithEvents RetiroBindingSource As BindingSource
    Friend WithEvents RetiroTableAdapter As BDMIDataSetTableAdapters.retiroTableAdapter
    Friend WithEvents RetiroDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Labelhora As Label
    Friend WithEvents LabelFecha2 As Label
    Friend WithEvents LabelCedDes As Label
    Friend WithEvents LabelTotalDes As Label
    Friend WithEvents LabelDeudaDes As Label
    Friend WithEvents Label70 As Label
    Friend WithEvents Label71 As Label
    Friend WithEvents Label73 As Label
    Friend WithEvents Label75 As Label
    Friend WithEvents TextBoxDescuento As TextBox
    Friend WithEvents Label72 As Label
    Friend WithEvents LabelAviso As Label
    Friend WithEvents Label74 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents LabelNumeroVentas As Label
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents LabelNumeroRetiros As Label
    Friend WithEvents LabelNumeroAbonos As Label
    Friend WithEvents Label79 As Label
    Friend WithEvents Label78 As Label
    Friend WithEvents Label77 As Label
    Friend WithEvents Label84 As Label
    Friend WithEvents LabelNumeroGastos As Label
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents Label82 As Label
    Friend WithEvents LabelNumeroOro As Label
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents Label80 As Label
    Friend WithEvents LabelNumeroEmpeños As Label
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents OroDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents Hora As Timer
    Friend WithEvents TabPageGastos As TabPage
    Friend WithEvents GastoBindingSource As BindingSource
    Friend WithEvents GastoTableAdapter As BDMIDataSetTableAdapters.gastoTableAdapter
    Friend WithEvents GastoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents Label85 As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Label83 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBoxAñadirGasto As TextBox
    Friend WithEvents Label81 As Label
    Friend WithEvents RichTextBoxGastoDescripcion As RichTextBox
    Friend WithEvents Label86 As Label
    Friend WithEvents Vender As DataGridViewImageColumn
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Panel13Retiro As Panel
    Friend WithEvents Panel13Abono As Panel
    Friend WithEvents Panel13Ventas As Panel
    Friend WithEvents Panel13Empeño As Panel
    Friend WithEvents Panel13Gasto As Panel
    Friend WithEvents Panel13Oro As Panel
    Friend WithEvents DGVVenta As DataGridView
    Friend WithEvents LabelNventas As Label
    Friend WithEvents DGVEmp As DataGridView
    Friend WithEvents LabelNemp As Label
    Friend WithEvents LabelNabono As Label
    Friend WithEvents DGVabono As DataGridView
    Friend WithEvents DGVretiro As DataGridView
    Friend WithEvents LabelNretiro As Label
    Friend WithEvents DGVOro As DataGridView
    Friend WithEvents LabelNoro As Label
    Friend WithEvents LabelN As Label
    Friend WithEvents DGVgasto As DataGridView
    Friend WithEvents Label42 As Label
    Friend WithEvents MovimientosBindingSource As BindingSource
    Friend WithEvents MovimientosTableAdapter As BDMIDataSetTableAdapters.movimientosTableAdapter
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label60 As Label
    Friend WithEvents LabelMesesFaltantes As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents Panel13 As Panel
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents Label64 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label87 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents Label65 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label93 As Label
    Friend WithEvents Label88 As Label
    Friend WithEvents Label89 As Label
    Friend WithEvents Label90 As Label
    Friend WithEvents Label91 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label92 As Label
    Friend WithEvents GraficoReporteMes As DataVisualization.Charting.Chart
    Friend WithEvents Label95 As Label
    Friend WithEvents Label94 As Label
    Friend WithEvents TabPageBalances As TabPage
    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ComboBoxMeses As ComboBox
    Friend WithEvents txtAñoBalance As Bunifu.Framework.BunifuCustomTextbox
    Friend WithEvents BunifuFlatButton2 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCards2 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents Label96 As Label
    Friend WithEvents DataGridViewBalance As DataGridView
    Friend WithEvents Empeños1 As DataGridViewTextBoxColumn
    Friend WithEvents Abonos1 As DataGridViewTextBoxColumn
    Friend WithEvents Ventas1 As DataGridViewTextBoxColumn
    Friend WithEvents Gastos1 As DataGridViewTextBoxColumn
    Friend WithEvents Oro1 As DataGridViewTextBoxColumn
    Friend WithEvents InteresesNoPagos1 As DataGridViewTextBoxColumn
    Friend WithEvents Ganancias1 As DataGridViewTextBoxColumn
    Friend WithEvents Label97 As Label
    Friend WithEvents Label98 As Label
End Class
