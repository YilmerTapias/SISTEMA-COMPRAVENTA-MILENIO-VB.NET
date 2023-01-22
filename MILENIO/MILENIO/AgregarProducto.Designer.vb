<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarProducto
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.RichTextBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 196)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(140, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 40)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Agregar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(172, 105)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(144, 20)
        Me.TextBox9.TabIndex = 6
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(16, 108)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(150, 13)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "Precio estimado del producto :"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(95, 61)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(53, 20)
        Me.TextBox8.TabIndex = 4
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(16, 64)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 13)
        Me.Label24.TabIndex = 3
        Me.Label24.Text = "Peso (gramos) :"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(186, 19)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(174, 62)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = "Descripcion..."
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Electrodomestico", "Prenda (Oro)", "Prenda (Plata)", "portatil ", "consola de video juegos", "Telefono Movil", "Otro"})
        Me.ComboBox1.Location = New System.Drawing.Point(50, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(98, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.Text = "Seleccione"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(16, 30)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(31, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Tipo:"
        '
        'AgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 220)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AgregarProducto"
        Me.Text = "AgregarProducto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Button1 As Button
End Class
