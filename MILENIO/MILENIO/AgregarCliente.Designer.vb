<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarCliente
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
        Me.TextBNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxApellido = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCedula = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxExpedida = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxDireccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxCorreo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BDMIDataSet = New MILENIO.BDMIDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter1 = New MILENIO.BDMIDataSetTableAdapters.clientesTableAdapter()
        Me.TableAdapterManager = New MILENIO.BDMIDataSetTableAdapters.TableAdapterManager()
        CType(Me.BDMIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBNombre
        '
        Me.TextBNombre.Location = New System.Drawing.Point(31, 63)
        Me.TextBNombre.Name = "TextBNombre"
        Me.TextBNombre.Size = New System.Drawing.Size(153, 20)
        Me.TextBNombre.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(157, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Hecho"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxApellido
        '
        Me.TextBoxApellido.Location = New System.Drawing.Point(31, 113)
        Me.TextBoxApellido.Name = "TextBoxApellido"
        Me.TextBoxApellido.Size = New System.Drawing.Size(153, 20)
        Me.TextBoxApellido.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Apellidos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cedula"
        '
        'TextBoxCedula
        '
        Me.TextBoxCedula.Location = New System.Drawing.Point(31, 165)
        Me.TextBoxCedula.Name = "TextBoxCedula"
        Me.TextBoxCedula.Size = New System.Drawing.Size(153, 20)
        Me.TextBoxCedula.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Expedida En:"
        '
        'TextBoxExpedida
        '
        Me.TextBoxExpedida.Location = New System.Drawing.Point(31, 214)
        Me.TextBoxExpedida.Name = "TextBoxExpedida"
        Me.TextBoxExpedida.Size = New System.Drawing.Size(153, 20)
        Me.TextBoxExpedida.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(236, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Telefono"
        '
        'TextBoxTelefono
        '
        Me.TextBoxTelefono.Location = New System.Drawing.Point(234, 63)
        Me.TextBoxTelefono.Name = "TextBoxTelefono"
        Me.TextBoxTelefono.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxTelefono.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(236, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Direccion"
        '
        'TextBoxDireccion
        '
        Me.TextBoxDireccion.Location = New System.Drawing.Point(234, 113)
        Me.TextBoxDireccion.Name = "TextBoxDireccion"
        Me.TextBoxDireccion.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxDireccion.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(236, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Correo electronico (opcional)"
        '
        'TextBoxCorreo
        '
        Me.TextBoxCorreo.Location = New System.Drawing.Point(234, 165)
        Me.TextBoxCorreo.Name = "TextBoxCorreo"
        Me.TextBoxCorreo.Size = New System.Drawing.Size(167, 20)
        Me.TextBoxCorreo.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(139, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 18)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Agregar nuevo cliente"
        '
        'BDMIDataSet
        '
        Me.BDMIDataSet.DataSetName = "BDMIDataSet"
        Me.BDMIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "clientes"
        Me.ClientesBindingSource.DataSource = Me.BDMIDataSet
        '
        'ClientesTableAdapter1
        '
        Me.ClientesTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.abonoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Me.ClientesTableAdapter1
        Me.TableAdapterManager.empeñoTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.retiroTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MILENIO.BDMIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        '
        'AgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 333)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBoxCorreo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBoxDireccion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBoxTelefono)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxExpedida)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxCedula)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxApellido)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBNombre)
        Me.Name = "AgregarCliente"
        Me.Text = "AgregarCliente"
        CType(Me.BDMIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxApellido As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCedula As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxExpedida As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxDireccion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxCorreo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BDMIDataSet As BDMIDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter1 As BDMIDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents TableAdapterManager As BDMIDataSetTableAdapters.TableAdapterManager
End Class
