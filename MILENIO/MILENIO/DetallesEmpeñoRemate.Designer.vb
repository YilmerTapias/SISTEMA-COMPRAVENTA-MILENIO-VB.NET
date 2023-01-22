<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetallesEmpeñoRemate
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LabelMesesNoPagos = New System.Windows.Forms.Label()
        Me.LabelMesesPagos = New System.Windows.Forms.Label()
        Me.LabelCedulaCliente = New System.Windows.Forms.Label()
        Me.LabelDeudaIntereses = New System.Windows.Forms.Label()
        Me.LabelApellidoCliente = New System.Windows.Forms.Label()
        Me.LabelNombreCli = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelCabezera = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelRematesDetalles = New System.Windows.Forms.Panel()
        Me.LabelDeudaTotalCliente = New System.Windows.Forms.Label()
        Me.LabelEstadoEmpeño = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDMIDataSet = New MILENIO.BDMIDataSet()
        Me.EmpeñoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpeñoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelAbonos = New System.Windows.Forms.Label()
        Me.LabelProductos = New System.Windows.Forms.Label()
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbonoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbonoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbonoTableAdapter = New MILENIO.BDMIDataSetTableAdapters.abonoTableAdapter()
        Me.TableAdapterManager = New MILENIO.BDMIDataSetTableAdapters.TableAdapterManager()
        Me.ClientesTableAdapter = New MILENIO.BDMIDataSetTableAdapters.clientesTableAdapter()
        Me.EmpeñoTableAdapter = New MILENIO.BDMIDataSetTableAdapters.empeñoTableAdapter()
        Me.ProductoTableAdapter = New MILENIO.BDMIDataSetTableAdapters.productoTableAdapter()
        Me.PanelRematesAbonos = New System.Windows.Forms.Panel()
        Me.PanelRematesProductos = New System.Windows.Forms.Panel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LabelUltimoAbono = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PanelCabezera.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRematesDetalles.SuspendLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDMIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpeñoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpeñoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbonoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbonoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRematesAbonos.SuspendLayout()
        Me.PanelRematesProductos.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelMesesNoPagos
        '
        Me.LabelMesesNoPagos.AutoSize = True
        Me.LabelMesesNoPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMesesNoPagos.Location = New System.Drawing.Point(150, 205)
        Me.LabelMesesNoPagos.Name = "LabelMesesNoPagos"
        Me.LabelMesesNoPagos.Size = New System.Drawing.Size(56, 16)
        Me.LabelMesesNoPagos.TabIndex = 26
        Me.LabelMesesNoPagos.Text = "Label11"
        '
        'LabelMesesPagos
        '
        Me.LabelMesesPagos.AutoSize = True
        Me.LabelMesesPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMesesPagos.Location = New System.Drawing.Point(129, 167)
        Me.LabelMesesPagos.Name = "LabelMesesPagos"
        Me.LabelMesesPagos.Size = New System.Drawing.Size(56, 16)
        Me.LabelMesesPagos.TabIndex = 25
        Me.LabelMesesPagos.Text = "Label11"
        '
        'LabelCedulaCliente
        '
        Me.LabelCedulaCliente.AutoSize = True
        Me.LabelCedulaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCedulaCliente.Location = New System.Drawing.Point(363, 96)
        Me.LabelCedulaCliente.Name = "LabelCedulaCliente"
        Me.LabelCedulaCliente.Size = New System.Drawing.Size(56, 16)
        Me.LabelCedulaCliente.TabIndex = 24
        Me.LabelCedulaCliente.Text = "Label11"
        '
        'LabelDeudaIntereses
        '
        Me.LabelDeudaIntereses.AutoSize = True
        Me.LabelDeudaIntereses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDeudaIntereses.Location = New System.Drawing.Point(427, 56)
        Me.LabelDeudaIntereses.Name = "LabelDeudaIntereses"
        Me.LabelDeudaIntereses.Size = New System.Drawing.Size(56, 16)
        Me.LabelDeudaIntereses.TabIndex = 23
        Me.LabelDeudaIntereses.Text = "Label11"
        '
        'LabelApellidoCliente
        '
        Me.LabelApellidoCliente.AutoSize = True
        Me.LabelApellidoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApellidoCliente.Location = New System.Drawing.Point(92, 96)
        Me.LabelApellidoCliente.Name = "LabelApellidoCliente"
        Me.LabelApellidoCliente.Size = New System.Drawing.Size(56, 16)
        Me.LabelApellidoCliente.TabIndex = 22
        Me.LabelApellidoCliente.Text = "Label10"
        '
        'LabelNombreCli
        '
        Me.LabelNombreCli.AutoSize = True
        Me.LabelNombreCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreCli.Location = New System.Drawing.Point(85, 56)
        Me.LabelNombreCli.Name = "LabelNombreCli"
        Me.LabelNombreCli.Size = New System.Drawing.Size(49, 16)
        Me.LabelNombreCli.TabIndex = 21
        Me.LabelNombreCli.Text = "Label9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(297, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Deuda De Intereses: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Meses Pagos: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 16)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Meses No Pagos: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(308, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Cedula: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Apellidos: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Nombre: "
        '
        'PanelCabezera
        '
        Me.PanelCabezera.BackColor = System.Drawing.Color.Teal
        Me.PanelCabezera.Controls.Add(Me.Label9)
        Me.PanelCabezera.Controls.Add(Me.Label7)
        Me.PanelCabezera.Controls.Add(Me.Label6)
        Me.PanelCabezera.Controls.Add(Me.PictureBox3)
        Me.PanelCabezera.Controls.Add(Me.PictureBox2)
        Me.PanelCabezera.Controls.Add(Me.PictureBox1)
        Me.PanelCabezera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabezera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabezera.Name = "PanelCabezera"
        Me.PanelCabezera.Size = New System.Drawing.Size(803, 55)
        Me.PanelCabezera.TabIndex = 27
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(585, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 18)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Productos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(396, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 18)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Abonos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(205, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 18)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Detalles"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.MILENIO.My.Resources.Resources.add_tag_48px
        Me.PictureBox3.Location = New System.Drawing.Point(511, 9)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(68, 39)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.MILENIO.My.Resources.Resources.receive_cash_64px
        Me.PictureBox2.Location = New System.Drawing.Point(322, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 39)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.MILENIO.My.Resources.Resources.bill_64px
        Me.PictureBox1.Location = New System.Drawing.Point(131, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelRematesDetalles
        '
        Me.PanelRematesDetalles.BackColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.PanelRematesDetalles.Controls.Add(Me.LabelDeudaTotalCliente)
        Me.PanelRematesDetalles.Controls.Add(Me.LabelEstadoEmpeño)
        Me.PanelRematesDetalles.Controls.Add(Me.Label10)
        Me.PanelRematesDetalles.Controls.Add(Me.Label11)
        Me.PanelRematesDetalles.Controls.Add(Me.ClientesDataGridView)
        Me.PanelRematesDetalles.Controls.Add(Me.EmpeñoDataGridView)
        Me.PanelRematesDetalles.Controls.Add(Me.LabelMesesNoPagos)
        Me.PanelRematesDetalles.Controls.Add(Me.Label1)
        Me.PanelRematesDetalles.Controls.Add(Me.LabelMesesPagos)
        Me.PanelRematesDetalles.Controls.Add(Me.Label2)
        Me.PanelRematesDetalles.Controls.Add(Me.LabelCedulaCliente)
        Me.PanelRematesDetalles.Controls.Add(Me.Label3)
        Me.PanelRematesDetalles.Controls.Add(Me.LabelDeudaIntereses)
        Me.PanelRematesDetalles.Controls.Add(Me.Label4)
        Me.PanelRematesDetalles.Controls.Add(Me.LabelApellidoCliente)
        Me.PanelRematesDetalles.Controls.Add(Me.Label5)
        Me.PanelRematesDetalles.Controls.Add(Me.LabelNombreCli)
        Me.PanelRematesDetalles.Controls.Add(Me.Label8)
        Me.PanelRematesDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRematesDetalles.Location = New System.Drawing.Point(0, 55)
        Me.PanelRematesDetalles.Name = "PanelRematesDetalles"
        Me.PanelRematesDetalles.Size = New System.Drawing.Size(803, 348)
        Me.PanelRematesDetalles.TabIndex = 28
        '
        'LabelDeudaTotalCliente
        '
        Me.LabelDeudaTotalCliente.AutoSize = True
        Me.LabelDeudaTotalCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelDeudaTotalCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDeudaTotalCliente.Location = New System.Drawing.Point(427, 167)
        Me.LabelDeudaTotalCliente.Name = "LabelDeudaTotalCliente"
        Me.LabelDeudaTotalCliente.Size = New System.Drawing.Size(66, 17)
        Me.LabelDeudaTotalCliente.TabIndex = 29
        Me.LabelDeudaTotalCliente.Text = "Label11"
        '
        'LabelEstadoEmpeño
        '
        Me.LabelEstadoEmpeño.AutoSize = True
        Me.LabelEstadoEmpeño.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstadoEmpeño.Location = New System.Drawing.Point(704, 56)
        Me.LabelEstadoEmpeño.Name = "LabelEstadoEmpeño"
        Me.LabelEstadoEmpeño.Size = New System.Drawing.Size(56, 16)
        Me.LabelEstadoEmpeño.TabIndex = 30
        Me.LabelEstadoEmpeño.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(313, 167)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 17)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Deuda Total:  "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(571, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 16)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Estado del Empeño:  "
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(636, 232)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.Size = New System.Drawing.Size(71, 47)
        Me.ClientesDataGridView.TabIndex = 26
        Me.ClientesDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "cedula_cliente"
        Me.DataGridViewTextBoxColumn22.HeaderText = "cedula_cliente"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "lugar_expedicion"
        Me.DataGridViewTextBoxColumn23.HeaderText = "lugar_expedicion"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn24.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn25.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "correo"
        Me.DataGridViewTextBoxColumn26.HeaderText = "correo"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn27.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "apellidos"
        Me.DataGridViewTextBoxColumn28.HeaderText = "apellidos"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.BDMIDataSet
        '
        'BDMIDataSet
        '
        Me.BDMIDataSet.DataSetName = "BDMIDataSet"
        Me.BDMIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpeñoDataGridView
        '
        Me.EmpeñoDataGridView.AutoGenerateColumns = False
        Me.EmpeñoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpeñoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.EmpeñoDataGridView.DataSource = Me.EmpeñoBindingSource
        Me.EmpeñoDataGridView.Location = New System.Drawing.Point(502, 230)
        Me.EmpeñoDataGridView.Name = "EmpeñoDataGridView"
        Me.EmpeñoDataGridView.Size = New System.Drawing.Size(77, 47)
        Me.EmpeñoDataGridView.TabIndex = 26
        Me.EmpeñoDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "codigo"
        Me.DataGridViewTextBoxColumn5.HeaderText = "codigo"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "valor_empeño"
        Me.DataGridViewTextBoxColumn6.HeaderText = "valor_empeño"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "fecha_llegada"
        Me.DataGridViewTextBoxColumn7.HeaderText = "fecha_llegada"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fecha_salida"
        Me.DataGridViewTextBoxColumn8.HeaderText = "fecha_salida"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "dia_empeño"
        Me.DataGridViewTextBoxColumn9.HeaderText = "dia_empeño"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "interes"
        Me.DataGridViewTextBoxColumn10.HeaderText = "interes"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "valor_total"
        Me.DataGridViewTextBoxColumn11.HeaderText = "valor_total"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "estado_producto"
        Me.DataGridViewTextBoxColumn12.HeaderText = "estado_producto"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "cedula_cliente"
        Me.DataGridViewTextBoxColumn13.HeaderText = "cedula_cliente"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "mesesPagados"
        Me.DataGridViewTextBoxColumn14.HeaderText = "mesesPagados"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'EmpeñoBindingSource
        '
        Me.EmpeñoBindingSource.DataMember = "empeño"
        Me.EmpeñoBindingSource.DataSource = Me.BDMIDataSet
        '
        'LabelAbonos
        '
        Me.LabelAbonos.AutoSize = True
        Me.LabelAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAbonos.Location = New System.Drawing.Point(43, 96)
        Me.LabelAbonos.Name = "LabelAbonos"
        Me.LabelAbonos.Size = New System.Drawing.Size(128, 16)
        Me.LabelAbonos.TabIndex = 32
        Me.LabelAbonos.Text = "TOTAL ABONOS:"
        '
        'LabelProductos
        '
        Me.LabelProductos.AutoSize = True
        Me.LabelProductos.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductos.Location = New System.Drawing.Point(33, 43)
        Me.LabelProductos.Name = "LabelProductos"
        Me.LabelProductos.Size = New System.Drawing.Size(71, 14)
        Me.LabelProductos.TabIndex = 31
        Me.LabelProductos.Text = "PRODUCTOS"
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(36, 75)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.Size = New System.Drawing.Size(743, 151)
        Me.ProductoDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "id_producto"
        Me.DataGridViewTextBoxColumn15.HeaderText = "id_producto"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Tipo"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "descripcion"
        Me.DataGridViewTextBoxColumn17.HeaderText = "descripcion"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "peso"
        Me.DataGridViewTextBoxColumn18.HeaderText = "peso"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "valor"
        Me.DataGridViewTextBoxColumn19.HeaderText = "valor"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "codigo_empeño"
        Me.DataGridViewTextBoxColumn20.HeaderText = "codigo_empeño"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "estado_producto"
        Me.DataGridViewTextBoxColumn21.HeaderText = "estado_producto"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.BDMIDataSet
        '
        'AbonoDataGridView
        '
        Me.AbonoDataGridView.AutoGenerateColumns = False
        Me.AbonoDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.AbonoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.AbonoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.AbonoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AbonoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.AbonoDataGridView.DataSource = Me.AbonoBindingSource
        Me.AbonoDataGridView.Location = New System.Drawing.Point(36, 129)
        Me.AbonoDataGridView.Name = "AbonoDataGridView"
        Me.AbonoDataGridView.Size = New System.Drawing.Size(447, 188)
        Me.AbonoDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_abono"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_abono"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "fecha_abono"
        Me.DataGridViewTextBoxColumn2.HeaderText = "fecha_abono"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "valor_abono"
        Me.DataGridViewTextBoxColumn3.HeaderText = "valor_abono"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "codigo_empeño"
        Me.DataGridViewTextBoxColumn4.HeaderText = "codigo_empeño"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'AbonoBindingSource
        '
        Me.AbonoBindingSource.DataMember = "abono"
        Me.AbonoBindingSource.DataSource = Me.BDMIDataSet
        '
        'AbonoTableAdapter
        '
        Me.AbonoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.abonoTableAdapter = Me.AbonoTableAdapter
        Me.TableAdapterManager.arqueoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.empeñoTableAdapter = Me.EmpeñoTableAdapter
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
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'EmpeñoTableAdapter
        '
        Me.EmpeñoTableAdapter.ClearBeforeFill = True
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'PanelRematesAbonos
        '
        Me.PanelRematesAbonos.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.PanelRematesAbonos.Controls.Add(Me.LabelUltimoAbono)
        Me.PanelRematesAbonos.Controls.Add(Me.Label12)
        Me.PanelRematesAbonos.Controls.Add(Me.LabelAbonos)
        Me.PanelRematesAbonos.Controls.Add(Me.AbonoDataGridView)
        Me.PanelRematesAbonos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRematesAbonos.Location = New System.Drawing.Point(0, 55)
        Me.PanelRematesAbonos.Name = "PanelRematesAbonos"
        Me.PanelRematesAbonos.Size = New System.Drawing.Size(803, 348)
        Me.PanelRematesAbonos.TabIndex = 33
        '
        'PanelRematesProductos
        '
        Me.PanelRematesProductos.Controls.Add(Me.Label13)
        Me.PanelRematesProductos.Controls.Add(Me.LabelProductos)
        Me.PanelRematesProductos.Controls.Add(Me.ProductoDataGridView)
        Me.PanelRematesProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelRematesProductos.Location = New System.Drawing.Point(0, 55)
        Me.PanelRematesProductos.Name = "PanelRematesProductos"
        Me.PanelRematesProductos.Size = New System.Drawing.Size(803, 348)
        Me.PanelRematesProductos.TabIndex = 34
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(279, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(191, 22)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Fecha Ultimo Abono: "
        '
        'LabelUltimoAbono
        '
        Me.LabelUltimoAbono.AutoSize = True
        Me.LabelUltimoAbono.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUltimoAbono.Location = New System.Drawing.Point(476, 38)
        Me.LabelUltimoAbono.Name = "LabelUltimoAbono"
        Me.LabelUltimoAbono.Size = New System.Drawing.Size(89, 18)
        Me.LabelUltimoAbono.TabIndex = 34
        Me.LabelUltimoAbono.Text = "Ninguno..."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(575, 280)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(204, 16)
        Me.Label13.TabIndex = 32
        Me.Label13.Text = "Productos Asociados al empeño"
        '
        'DetallesEmpeñoRemate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 403)
        Me.Controls.Add(Me.PanelRematesProductos)
        Me.Controls.Add(Me.PanelRematesAbonos)
        Me.Controls.Add(Me.PanelRematesDetalles)
        Me.Controls.Add(Me.PanelCabezera)
        Me.Name = "DetallesEmpeñoRemate"
        Me.Text = "DetallesEmpeñoRemate"
        Me.PanelCabezera.ResumeLayout(False)
        Me.PanelCabezera.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRematesDetalles.ResumeLayout(False)
        Me.PanelRematesDetalles.PerformLayout()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDMIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpeñoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpeñoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbonoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbonoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRematesAbonos.ResumeLayout(False)
        Me.PanelRematesAbonos.PerformLayout()
        Me.PanelRematesProductos.ResumeLayout(False)
        Me.PanelRematesProductos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelMesesNoPagos As Label
    Friend WithEvents LabelMesesPagos As Label
    Friend WithEvents LabelCedulaCliente As Label
    Friend WithEvents LabelDeudaIntereses As Label
    Friend WithEvents LabelApellidoCliente As Label
    Friend WithEvents LabelNombreCli As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelCabezera As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PanelRematesDetalles As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents BDMIDataSet As BDMIDataSet
    Friend WithEvents AbonoBindingSource As BindingSource
    Friend WithEvents AbonoTableAdapter As BDMIDataSetTableAdapters.abonoTableAdapter
    Friend WithEvents TableAdapterManager As BDMIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AbonoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents EmpeñoTableAdapter As BDMIDataSetTableAdapters.empeñoTableAdapter
    Friend WithEvents EmpeñoBindingSource As BindingSource
    Friend WithEvents EmpeñoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents ProductoTableAdapter As BDMIDataSetTableAdapters.productoTableAdapter
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ProductoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents ClientesTableAdapter As BDMIDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents LabelDeudaTotalCliente As Label
    Friend WithEvents LabelEstadoEmpeño As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LabelAbonos As Label
    Friend WithEvents LabelProductos As Label
    Friend WithEvents PanelRematesAbonos As Panel
    Friend WithEvents PanelRematesProductos As Panel
    Friend WithEvents LabelUltimoAbono As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
End Class
