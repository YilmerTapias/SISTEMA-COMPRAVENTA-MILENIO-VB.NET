<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Desempeñar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxDescuento = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelDeuda = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.PanelProd = New System.Windows.Forms.Panel()
        Me.DataGridViewP = New System.Windows.Forms.DataGridView()
        Me.LabelCod = New System.Windows.Forms.Label()
        Me.LabelCed = New System.Windows.Forms.Label()
        Me.BDMIDataSet = New MILENIO.BDMIDataSet()
        Me.RetiroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RetiroTableAdapter = New MILENIO.BDMIDataSetTableAdapters.retiroTableAdapter()
        Me.TableAdapterManager = New MILENIO.BDMIDataSetTableAdapters.TableAdapterManager()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.PanelProd.SuspendLayout()
        CType(Me.DataGridViewP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDMIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RetiroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(138, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Milenio Compra Venta"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(141, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(121, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Continuar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxDescuento
        '
        Me.TextBoxDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDescuento.Location = New System.Drawing.Point(126, 84)
        Me.TextBoxDescuento.Multiline = True
        Me.TextBoxDescuento.Name = "TextBoxDescuento"
        Me.TextBoxDescuento.Size = New System.Drawing.Size(122, 23)
        Me.TextBoxDescuento.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descuento : $"
        '
        'LabelDeuda
        '
        Me.LabelDeuda.AutoSize = True
        Me.LabelDeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDeuda.Location = New System.Drawing.Point(193, 51)
        Me.LabelDeuda.Name = "LabelDeuda"
        Me.LabelDeuda.Size = New System.Drawing.Size(41, 18)
        Me.LabelDeuda.TabIndex = 4
        Me.LabelDeuda.Text = "none"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(45, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Deuda Total Del Empeño:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MILENIO.My.Resources.Resources.icons8_desplegar_50
        Me.PictureBox1.Location = New System.Drawing.Point(2, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(39, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Tag = "0"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LabelTotal)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBoxDescuento)
        Me.Panel1.Controls.Add(Me.LabelDeuda)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(101, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 226)
        Me.Panel1.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(72, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 18)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Total : "
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(124, 124)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(36, 18)
        Me.LabelTotal.TabIndex = 6
        Me.LabelTotal.Text = "$0.0"
        '
        'PanelProd
        '
        Me.PanelProd.Controls.Add(Me.Label7)
        Me.PanelProd.Controls.Add(Me.Label6)
        Me.PanelProd.Controls.Add(Me.Label3)
        Me.PanelProd.Controls.Add(Me.DataGridViewP)
        Me.PanelProd.Controls.Add(Me.LabelCod)
        Me.PanelProd.Controls.Add(Me.LabelCed)
        Me.PanelProd.Location = New System.Drawing.Point(2, 12)
        Me.PanelProd.Name = "PanelProd"
        Me.PanelProd.Size = New System.Drawing.Size(190, 212)
        Me.PanelProd.TabIndex = 6
        Me.PanelProd.Visible = False
        '
        'DataGridViewP
        '
        Me.DataGridViewP.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridViewP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewP.Location = New System.Drawing.Point(6, 119)
        Me.DataGridViewP.Name = "DataGridViewP"
        Me.DataGridViewP.Size = New System.Drawing.Size(181, 83)
        Me.DataGridViewP.TabIndex = 2
        '
        'LabelCod
        '
        Me.LabelCod.AutoSize = True
        Me.LabelCod.Location = New System.Drawing.Point(39, 44)
        Me.LabelCod.Name = "LabelCod"
        Me.LabelCod.Size = New System.Drawing.Size(33, 13)
        Me.LabelCod.TabIndex = 1
        Me.LabelCod.Text = "None"
        '
        'LabelCed
        '
        Me.LabelCed.AutoSize = True
        Me.LabelCed.Location = New System.Drawing.Point(39, 22)
        Me.LabelCed.Name = "LabelCed"
        Me.LabelCed.Size = New System.Drawing.Size(33, 13)
        Me.LabelCed.TabIndex = 0
        Me.LabelCed.Text = "None"
        '
        'BDMIDataSet
        '
        Me.BDMIDataSet.DataSetName = "BDMIDataSet"
        Me.BDMIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RetiroBindingSource
        '
        Me.RetiroBindingSource.DataMember = "retiro"
        Me.RetiroBindingSource.DataSource = Me.BDMIDataSet
        '
        'RetiroTableAdapter
        '
        Me.RetiroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.abonoTableAdapter = Nothing
        Me.TableAdapterManager.arqueoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.clientesTableAdapter = Nothing
        Me.TableAdapterManager.empeñoTableAdapter = Nothing
        Me.TableAdapterManager.mensajesTableAdapter = Nothing
        Me.TableAdapterManager.movimientosTableAdapter = Nothing
        Me.TableAdapterManager.OroTableAdapter = Nothing
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.retiroTableAdapter = Me.RetiroTableAdapter
        Me.TableAdapterManager.UpdateOrder = MILENIO.BDMIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Nothing
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cod :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "C.C :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Detalles"
        '
        'Desempeñar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 226)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PanelProd)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Desempeñar"
        Me.Text = "Desempeñar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelProd.ResumeLayout(False)
        Me.PanelProd.PerformLayout()
        CType(Me.DataGridViewP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDMIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RetiroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxDescuento As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelDeuda As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelProd As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents BDMIDataSet As BDMIDataSet
    Friend WithEvents RetiroBindingSource As BindingSource
    Friend WithEvents RetiroTableAdapter As BDMIDataSetTableAdapters.retiroTableAdapter
    Friend WithEvents TableAdapterManager As BDMIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LabelCod As Label
    Friend WithEvents LabelCed As Label
    Friend WithEvents DataGridViewP As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
End Class
