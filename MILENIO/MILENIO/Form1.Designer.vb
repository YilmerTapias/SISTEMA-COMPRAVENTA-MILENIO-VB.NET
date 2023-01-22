<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BDMIDataSet = New MILENIO.BDMIDataSet()
        Me.UsuariosTableAdapter = New MILENIO.BDMIDataSetTableAdapters.usuariosTableAdapter()
        Me.TableAdapterManager = New MILENIO.BDMIDataSetTableAdapters.TableAdapterManager()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox2 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuTileButton1 = New Bunifu.Framework.UI.BunifuTileButton()
        Me.UsuarioTextBox = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.ContraseñaTextBox = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDMIDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(188, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(0, 667)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1024, 73)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MILENIO.My.Resources.Resources.icons8_contraseña_100
        Me.PictureBox1.Location = New System.Drawing.Point(6, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Open Sans", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(89, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingrese sus datos para acceder a MILENO SYSTEM."
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "usuarios"
        Me.UsuariosBindingSource.DataSource = Me.BDMIDataSet
        '
        'BDMIDataSet
        '
        Me.BDMIDataSet.DataSetName = "BDMIDataSet"
        Me.BDMIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.productoTableAdapter = Nothing
        Me.TableAdapterManager.retiroTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MILENIO.BDMIDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuariosTableAdapter = Me.UsuariosTableAdapter
        Me.TableAdapterManager.ventaTableAdapter = Nothing
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.MILENIO.My.Resources.Resources.icons8_administrador_del_hombre_80
        Me.PictureBox2.Location = New System.Drawing.Point(8, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(182, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 25)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "LOGIN - MILENIO"
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Enabled = False
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Comic Sans MS", 14.25!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox1.HintText = ""
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.CornflowerBlue
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue
        Me.BunifuMaterialTextbox1.LineThickness = 5
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(143, 174)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.MaxLength = 32767
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(266, 44)
        Me.BunifuMaterialTextbox1.TabIndex = 21
        Me.BunifuMaterialTextbox1.Text = "Usuario:"
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox2
        '
        Me.BunifuMaterialTextbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None
        Me.BunifuMaterialTextbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None
        Me.BunifuMaterialTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.BunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox2.Enabled = False
        Me.BunifuMaterialTextbox2.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox2.HintText = ""
        Me.BunifuMaterialTextbox2.isPassword = False
        Me.BunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.CornflowerBlue
        Me.BunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue
        Me.BunifuMaterialTextbox2.LineThickness = 5
        Me.BunifuMaterialTextbox2.Location = New System.Drawing.Point(143, 278)
        Me.BunifuMaterialTextbox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuMaterialTextbox2.MaxLength = 32767
        Me.BunifuMaterialTextbox2.Name = "BunifuMaterialTextbox2"
        Me.BunifuMaterialTextbox2.Size = New System.Drawing.Size(266, 39)
        Me.BunifuMaterialTextbox2.TabIndex = 22
        Me.BunifuMaterialTextbox2.Text = "Contraseña:"
        Me.BunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(8, 138)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(504, 10)
        Me.BunifuSeparator1.TabIndex = 23
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuTileButton1
        '
        Me.BunifuTileButton1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BunifuTileButton1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BunifuTileButton1.color = System.Drawing.Color.DarkSlateGray
        Me.BunifuTileButton1.colorActive = System.Drawing.Color.Teal
        Me.BunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuTileButton1.Font = New System.Drawing.Font("Century Gothic", 15.75!)
        Me.BunifuTileButton1.ForeColor = System.Drawing.Color.White
        Me.BunifuTileButton1.Image = Global.MILENIO.My.Resources.Resources.logout_rounded_100px
        Me.BunifuTileButton1.ImagePosition = 15
        Me.BunifuTileButton1.ImageZoom = 65
        Me.BunifuTileButton1.LabelPosition = 35
        Me.BunifuTileButton1.LabelText = "ENTRAR"
        Me.BunifuTileButton1.Location = New System.Drawing.Point(208, 387)
        Me.BunifuTileButton1.Margin = New System.Windows.Forms.Padding(6)
        Me.BunifuTileButton1.Name = "BunifuTileButton1"
        Me.BunifuTileButton1.Size = New System.Drawing.Size(128, 129)
        Me.BunifuTileButton1.TabIndex = 24
        '
        'UsuarioTextBox
        '
        Me.UsuarioTextBox.BorderColorFocused = System.Drawing.Color.Blue
        Me.UsuarioTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UsuarioTextBox.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.UsuarioTextBox.BorderThickness = 3
        Me.UsuarioTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.UsuarioTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsuarioTextBox.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsuarioTextBox.ForeColor = System.Drawing.Color.White
        Me.UsuarioTextBox.isPassword = False
        Me.UsuarioTextBox.Location = New System.Drawing.Point(143, 219)
        Me.UsuarioTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UsuarioTextBox.MaxLength = 32767
        Me.UsuarioTextBox.Name = "UsuarioTextBox"
        Me.UsuarioTextBox.Size = New System.Drawing.Size(266, 44)
        Me.UsuarioTextBox.TabIndex = 25
        Me.UsuarioTextBox.Text = "invitado"
        Me.UsuarioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.BunifuSeparator2)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.ContraseñaTextBox)
        Me.Panel1.Controls.Add(Me.UsuarioTextBox)
        Me.Panel1.Controls.Add(Me.BunifuTileButton1)
        Me.Panel1.Controls.Add(Me.BunifuSeparator1)
        Me.Panel1.Controls.Add(Me.BunifuMaterialTextbox2)
        Me.Panel1.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Location = New System.Drawing.Point(262, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(552, 551)
        Me.Panel1.TabIndex = 20
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.MILENIO.My.Resources.Resources.Sin_título_2_Mesa_de_trabajo_1
        Me.PictureBox4.Location = New System.Drawing.Point(469, 3)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 27
        Me.PictureBox4.TabStop = False
        '
        'ContraseñaTextBox
        '
        Me.ContraseñaTextBox.BorderColorFocused = System.Drawing.Color.Blue
        Me.ContraseñaTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ContraseñaTextBox.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.ContraseñaTextBox.BorderThickness = 3
        Me.ContraseñaTextBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.ContraseñaTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ContraseñaTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.ContraseñaTextBox.ForeColor = System.Drawing.Color.White
        Me.ContraseñaTextBox.isPassword = True
        Me.ContraseñaTextBox.Location = New System.Drawing.Point(143, 318)
        Me.ContraseñaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ContraseñaTextBox.MaxLength = 32767
        Me.ContraseñaTextBox.Name = "ContraseñaTextBox"
        Me.ContraseñaTextBox.Size = New System.Drawing.Size(266, 44)
        Me.ContraseñaTextBox.TabIndex = 26
        Me.ContraseñaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(81, 154)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(28, 394)
        Me.BunifuSeparator2.TabIndex = 28
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 740)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LOGIN"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDMIDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BDMIDataSet As BDMIDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As BDMIDataSetTableAdapters.usuariosTableAdapter
    Friend WithEvents TableAdapterManager As BDMIDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents ContraseñaTextBox As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents UsuarioTextBox As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuTileButton1 As Bunifu.Framework.UI.BunifuTileButton
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuMaterialTextbox2 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
End Class
