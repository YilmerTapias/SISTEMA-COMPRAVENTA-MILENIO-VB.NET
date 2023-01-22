<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetallesEmpeño
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetallesEmpeño))
        Me.LabelProductos = New System.Windows.Forms.Label()
        Me.RetiroDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetiroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDMIDataSet = New MILENIO.BDMIDataSet()
        Me.AbonoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpeñoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbonoDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbonoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpeñoabonoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelNombreCliente = New System.Windows.Forms.Label()
        Me.ClientesempeñoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.AbonoTableAdapter = New MILENIO.BDMIDataSetTableAdapters.abonoTableAdapter()
        Me.TableAdapterManager = New MILENIO.BDMIDataSetTableAdapters.TableAdapterManager()
        Me.EmpeñoTableAdapter = New MILENIO.BDMIDataSetTableAdapters.empeñoTableAdapter()
        Me.ProductoTableAdapter = New MILENIO.BDMIDataSetTableAdapters.productoTableAdapter()
        Me.RetiroTableAdapter = New MILENIO.BDMIDataSetTableAdapters.retiroTableAdapter()
        Me.ClientesTableAdapter = New MILENIO.BDMIDataSetTableAdapters.clientesTableAdapter()
        Me.ClientesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelDeudaTotalCliente = New System.Windows.Forms.Label()
        Me.LabelEstadoEmpeño = New System.Windows.Forms.Label()
        Me.LabelMesesNoPagos = New System.Windows.Forms.Label()
        Me.LabelMesesPagos = New System.Windows.Forms.Label()
        Me.LabelCedulaCliente = New System.Windows.Forms.Label()
        Me.LabelDeudaIntereses = New System.Windows.Forms.Label()
        Me.LabelApellidoCliente = New System.Windows.Forms.Label()
        Me.LabelNombreCli = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ButtonDesempeñar = New System.Windows.Forms.Button()
        Me.LabelAbonos = New System.Windows.Forms.Label()
        Me.LabelAvisoEmp = New System.Windows.Forms.Label()
        CType(Me.RetiroDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetiroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDMIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbonoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpeñoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbonoDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbonoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpeñoabonoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesempeñoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelProductos
        '
        Me.LabelProductos.AutoSize = True
        Me.LabelProductos.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProductos.Location = New System.Drawing.Point(222, 29)
        Me.LabelProductos.Name = "LabelProductos"
        Me.LabelProductos.Size = New System.Drawing.Size(71, 14)
        Me.LabelProductos.TabIndex = 4
        Me.LabelProductos.Text = "PRODUCTOS"
        '
        'RetiroDataGridView
        '
        Me.RetiroDataGridView.AutoGenerateColumns = False
        Me.RetiroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RetiroDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.RetiroDataGridView.DataSource = Me.RetiroBindingSource
        Me.RetiroDataGridView.Location = New System.Drawing.Point(12, 553)
        Me.RetiroDataGridView.Name = "RetiroDataGridView"
        Me.RetiroDataGridView.Size = New System.Drawing.Size(543, 73)
        Me.RetiroDataGridView.TabIndex = 5
        Me.RetiroDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "id_retiro"
        Me.DataGridViewTextBoxColumn11.HeaderText = "id_retiro"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "fecha_retiro"
        Me.DataGridViewTextBoxColumn12.HeaderText = "fecha_retiro"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "hora_retiro"
        Me.DataGridViewTextBoxColumn13.HeaderText = "hora_retiro"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "id_cliente"
        Me.DataGridViewTextBoxColumn14.HeaderText = "id_cliente"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "id_empeño"
        Me.DataGridViewTextBoxColumn15.HeaderText = "id_empeño"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'RetiroBindingSource
        '
        Me.RetiroBindingSource.DataMember = "retiro"
        Me.RetiroBindingSource.DataSource = Me.BDMIDataSet
        '
        'BDMIDataSet
        '
        Me.BDMIDataSet.DataSetName = "BDMIDataSet"
        Me.BDMIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AbonoBindingSource1
        '
        Me.AbonoBindingSource1.DataMember = "empeñoabono"
        Me.AbonoBindingSource1.DataSource = Me.EmpeñoBindingSource
        '
        'EmpeñoBindingSource
        '
        Me.EmpeñoBindingSource.DataMember = "empeño"
        Me.EmpeñoBindingSource.DataSource = Me.BDMIDataSet
        '
        'AbonoDataGridView1
        '
        Me.AbonoDataGridView1.AutoGenerateColumns = False
        Me.AbonoDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AbonoDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19})
        Me.AbonoDataGridView1.DataSource = Me.AbonoBindingSource
        Me.AbonoDataGridView1.Location = New System.Drawing.Point(662, 299)
        Me.AbonoDataGridView1.Name = "AbonoDataGridView1"
        Me.AbonoDataGridView1.Size = New System.Drawing.Size(440, 220)
        Me.AbonoDataGridView1.TabIndex = 6
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "id_abono"
        Me.DataGridViewTextBoxColumn16.HeaderText = "id_abono"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "fecha_abono"
        Me.DataGridViewTextBoxColumn17.HeaderText = "fecha_abono"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "valor_abono"
        Me.DataGridViewTextBoxColumn18.HeaderText = "valor_abono"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "codigo_empeño"
        Me.DataGridViewTextBoxColumn19.HeaderText = "codigo_empeño"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'AbonoBindingSource
        '
        Me.AbonoBindingSource.DataMember = "abono"
        Me.AbonoBindingSource.DataSource = Me.BDMIDataSet
        '
        'EmpeñoabonoBindingSource
        '
        Me.EmpeñoabonoBindingSource.DataMember = "empeñoabono"
        Me.EmpeñoabonoBindingSource.DataSource = Me.EmpeñoBindingSource
        '
        'ProductoBindingSource1
        '
        Me.ProductoBindingSource1.DataMember = "empeñoproducto"
        Me.ProductoBindingSource1.DataSource = Me.EmpeñoBindingSource
        '
        'ProductoDataGridView
        '
        Me.ProductoDataGridView.AutoGenerateColumns = False
        Me.ProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.ProductoDataGridView.DataSource = Me.ProductoBindingSource
        Me.ProductoDataGridView.Location = New System.Drawing.Point(13, 298)
        Me.ProductoDataGridView.Name = "ProductoDataGridView"
        Me.ProductoDataGridView.Size = New System.Drawing.Size(641, 220)
        Me.ProductoDataGridView.TabIndex = 6
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
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "producto"
        Me.ProductoBindingSource.DataSource = Me.BDMIDataSet
        '
        'LabelNombreCliente
        '
        Me.LabelNombreCliente.AutoSize = True
        Me.LabelNombreCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.LabelNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreCliente.ForeColor = System.Drawing.Color.White
        Me.LabelNombreCliente.Location = New System.Drawing.Point(350, 16)
        Me.LabelNombreCliente.Name = "LabelNombreCliente"
        Me.LabelNombreCliente.Size = New System.Drawing.Size(69, 20)
        Me.LabelNombreCliente.TabIndex = 7
        Me.LabelNombreCliente.Text = "Nombre:"
        '
        'ClientesempeñoBindingSource
        '
        Me.ClientesempeñoBindingSource.DataMember = "clientesempeño"
        Me.ClientesempeñoBindingSource.DataSource = Me.ClientesBindingSource
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.BDMIDataSet
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(571, 553)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.Size = New System.Drawing.Size(531, 73)
        Me.ClientesDataGridView.TabIndex = 7
        Me.ClientesDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cedula_cliente"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cedula_cliente"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "lugar_expedicion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "lugar_expedicion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "telefono"
        Me.DataGridViewTextBoxColumn9.HeaderText = "telefono"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "direccion"
        Me.DataGridViewTextBoxColumn10.HeaderText = "direccion"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "correo"
        Me.DataGridViewTextBoxColumn20.HeaderText = "correo"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "nombre"
        Me.DataGridViewTextBoxColumn21.HeaderText = "nombre"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "apellidos"
        Me.DataGridViewTextBoxColumn22.HeaderText = "apellidos"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.LabelProductos)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 234)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(640, 63)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones-producto"
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Enabled = False
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(149, 24)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(45, 36)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 7
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(86, 24)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 36)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(24, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 36)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.PictureBox7.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(1127, 45)
        Me.PictureBox7.TabIndex = 10
        Me.PictureBox7.TabStop = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(925, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 11
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
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.empeñoTableAdapter = Me.EmpeñoTableAdapter
        Me.TableAdapterManager.gastoTableAdapter = Nothing
        Me.TableAdapterManager.mensajesTableAdapter = Nothing
        Me.TableAdapterManager.movimientosTableAdapter = Nothing
        Me.TableAdapterManager.OroTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Me.ProductoTableAdapter
        Me.TableAdapterManager.retiroTableAdapter = Me.RetiroTableAdapter
        Me.TableAdapterManager.UpdateOrder = MILENIO.BDMIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'EmpeñoTableAdapter
        '
        Me.EmpeñoTableAdapter.ClearBeforeFill = True
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'RetiroTableAdapter
        '
        Me.RetiroTableAdapter.ClearBeforeFill = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ClientesBindingSource1
        '
        Me.ClientesBindingSource1.DataMember = "clientes"
        Me.ClientesBindingSource1.DataSource = Me.BDMIDataSet
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LabelDeudaTotalCliente)
        Me.Panel1.Controls.Add(Me.LabelEstadoEmpeño)
        Me.Panel1.Controls.Add(Me.LabelMesesNoPagos)
        Me.Panel1.Controls.Add(Me.LabelMesesPagos)
        Me.Panel1.Controls.Add(Me.LabelCedulaCliente)
        Me.Panel1.Controls.Add(Me.LabelDeudaIntereses)
        Me.Panel1.Controls.Add(Me.LabelApellidoCliente)
        Me.Panel1.Controls.Add(Me.LabelNombreCli)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Location = New System.Drawing.Point(19, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1087, 110)
        Me.Panel1.TabIndex = 12
        '
        'LabelDeudaTotalCliente
        '
        Me.LabelDeudaTotalCliente.AutoSize = True
        Me.LabelDeudaTotalCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LabelDeudaTotalCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDeudaTotalCliente.Location = New System.Drawing.Point(844, 65)
        Me.LabelDeudaTotalCliente.Name = "LabelDeudaTotalCliente"
        Me.LabelDeudaTotalCliente.Size = New System.Drawing.Size(56, 16)
        Me.LabelDeudaTotalCliente.TabIndex = 14
        Me.LabelDeudaTotalCliente.Text = "Label11"
        '
        'LabelEstadoEmpeño
        '
        Me.LabelEstadoEmpeño.AutoSize = True
        Me.LabelEstadoEmpeño.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEstadoEmpeño.Location = New System.Drawing.Point(890, 23)
        Me.LabelEstadoEmpeño.Name = "LabelEstadoEmpeño"
        Me.LabelEstadoEmpeño.Size = New System.Drawing.Size(56, 16)
        Me.LabelEstadoEmpeño.TabIndex = 14
        Me.LabelEstadoEmpeño.Text = "Label11"
        '
        'LabelMesesNoPagos
        '
        Me.LabelMesesNoPagos.AutoSize = True
        Me.LabelMesesNoPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMesesNoPagos.Location = New System.Drawing.Point(667, 62)
        Me.LabelMesesNoPagos.Name = "LabelMesesNoPagos"
        Me.LabelMesesNoPagos.Size = New System.Drawing.Size(56, 16)
        Me.LabelMesesNoPagos.TabIndex = 14
        Me.LabelMesesNoPagos.Text = "Label11"
        '
        'LabelMesesPagos
        '
        Me.LabelMesesPagos.AutoSize = True
        Me.LabelMesesPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMesesPagos.Location = New System.Drawing.Point(649, 23)
        Me.LabelMesesPagos.Name = "LabelMesesPagos"
        Me.LabelMesesPagos.Size = New System.Drawing.Size(56, 16)
        Me.LabelMesesPagos.TabIndex = 13
        Me.LabelMesesPagos.Text = "Label11"
        '
        'LabelCedulaCliente
        '
        Me.LabelCedulaCliente.AutoSize = True
        Me.LabelCedulaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCedulaCliente.Location = New System.Drawing.Point(344, 63)
        Me.LabelCedulaCliente.Name = "LabelCedulaCliente"
        Me.LabelCedulaCliente.Size = New System.Drawing.Size(56, 16)
        Me.LabelCedulaCliente.TabIndex = 11
        Me.LabelCedulaCliente.Text = "Label11"
        '
        'LabelDeudaIntereses
        '
        Me.LabelDeudaIntereses.AutoSize = True
        Me.LabelDeudaIntereses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDeudaIntereses.Location = New System.Drawing.Point(419, 23)
        Me.LabelDeudaIntereses.Name = "LabelDeudaIntereses"
        Me.LabelDeudaIntereses.Size = New System.Drawing.Size(56, 16)
        Me.LabelDeudaIntereses.TabIndex = 10
        Me.LabelDeudaIntereses.Text = "Label11"
        '
        'LabelApellidoCliente
        '
        Me.LabelApellidoCliente.AutoSize = True
        Me.LabelApellidoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelApellidoCliente.Location = New System.Drawing.Point(152, 63)
        Me.LabelApellidoCliente.Name = "LabelApellidoCliente"
        Me.LabelApellidoCliente.Size = New System.Drawing.Size(56, 16)
        Me.LabelApellidoCliente.TabIndex = 9
        Me.LabelApellidoCliente.Text = "Label10"
        '
        'LabelNombreCli
        '
        Me.LabelNombreCli.AutoSize = True
        Me.LabelNombreCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreCli.Location = New System.Drawing.Point(145, 23)
        Me.LabelNombreCli.Name = "LabelNombreCli"
        Me.LabelNombreCli.Size = New System.Drawing.Size(49, 16)
        Me.LabelNombreCli.TabIndex = 8
        Me.LabelNombreCli.Text = "Label9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(289, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Deuda De Intereses: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(757, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Deuda Total:  "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(757, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Estado del Empeño:  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(553, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Meses Pagos: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(553, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Meses No Pagos: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(289, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cedula: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre: "
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PictureBox4.Location = New System.Drawing.Point(749, 54)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(305, 53)
        Me.PictureBox4.TabIndex = 15
        Me.PictureBox4.TabStop = False
        '
        'ButtonDesempeñar
        '
        Me.ButtonDesempeñar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ButtonDesempeñar.Enabled = False
        Me.ButtonDesempeñar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDesempeñar.Location = New System.Drawing.Point(979, 197)
        Me.ButtonDesempeñar.Name = "ButtonDesempeñar"
        Me.ButtonDesempeñar.Size = New System.Drawing.Size(127, 62)
        Me.ButtonDesempeñar.TabIndex = 13
        Me.ButtonDesempeñar.Text = "Desempeñar"
        Me.ButtonDesempeñar.UseVisualStyleBackColor = False
        '
        'LabelAbonos
        '
        Me.LabelAbonos.AutoSize = True
        Me.LabelAbonos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAbonos.Location = New System.Drawing.Point(673, 263)
        Me.LabelAbonos.Name = "LabelAbonos"
        Me.LabelAbonos.Size = New System.Drawing.Size(128, 16)
        Me.LabelAbonos.TabIndex = 14
        Me.LabelAbonos.Text = "TOTAL ABONOS:"
        '
        'LabelAvisoEmp
        '
        Me.LabelAvisoEmp.AutoSize = True
        Me.LabelAvisoEmp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAvisoEmp.Location = New System.Drawing.Point(103, 197)
        Me.LabelAvisoEmp.Name = "LabelAvisoEmp"
        Me.LabelAvisoEmp.Size = New System.Drawing.Size(146, 22)
        Me.LabelAvisoEmp.TabIndex = 15
        Me.LabelAvisoEmp.Text = "Aviso: Ninguno"
        '
        'DetallesEmpeño
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1125, 636)
        Me.Controls.Add(Me.LabelAvisoEmp)
        Me.Controls.Add(Me.LabelAbonos)
        Me.Controls.Add(Me.ButtonDesempeñar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.Controls.Add(Me.LabelNombreCliente)
        Me.Controls.Add(Me.ProductoDataGridView)
        Me.Controls.Add(Me.RetiroDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.AbonoDataGridView1)
        Me.Name = "DetallesEmpeño"
        Me.Text = "DetallesEmpeño"
        CType(Me.RetiroDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetiroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDMIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbonoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpeñoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbonoDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbonoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpeñoabonoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesempeñoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BDMIDataSet As BDMIDataSet
    Friend WithEvents AbonoBindingSource As BindingSource
    Friend WithEvents AbonoTableAdapter As BDMIDataSetTableAdapters.abonoTableAdapter
    Friend WithEvents TableAdapterManager As BDMIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductoTableAdapter As BDMIDataSetTableAdapters.productoTableAdapter
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents RetiroTableAdapter As BDMIDataSetTableAdapters.retiroTableAdapter
    Friend WithEvents LabelProductos As Label
    Friend WithEvents RetiroBindingSource As BindingSource
    Friend WithEvents RetiroDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents EmpeñoTableAdapter As BDMIDataSetTableAdapters.empeñoTableAdapter
    Friend WithEvents EmpeñoBindingSource As BindingSource
    Friend WithEvents AbonoBindingSource1 As BindingSource
    Friend WithEvents AbonoDataGridView1 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents ProductoBindingSource1 As BindingSource
    Friend WithEvents ProductoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents EmpeñoabonoBindingSource As BindingSource
    Friend WithEvents LabelNombreCliente As Label
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As BDMIDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents ClientesBindingSource1 As BindingSource
    Friend WithEvents ClientesempeñoBindingSource As BindingSource
    Friend WithEvents ClientesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelDeudaTotalCliente As Label
    Friend WithEvents LabelEstadoEmpeño As Label
    Friend WithEvents LabelMesesNoPagos As Label
    Friend WithEvents LabelMesesPagos As Label
    Friend WithEvents LabelCedulaCliente As Label
    Friend WithEvents LabelDeudaIntereses As Label
    Friend WithEvents LabelApellidoCliente As Label
    Friend WithEvents LabelNombreCli As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ButtonDesempeñar As Button
    Friend WithEvents LabelAbonos As Label
    Friend WithEvents LabelAvisoEmp As Label
End Class
