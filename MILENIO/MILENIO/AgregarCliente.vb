Public Class AgregarCliente

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.ClientesTableAdapter1.INSERTAR_CLIENTE(TextBoxCedula.Text, TextBoxExpedida.Text, TextBoxTelefono.Text, TextBoxDireccion.Text, TextBoxCorreo.Text, TextBNombre.Text, TextBoxApellido.Text)
        Me.ClientesTableAdapter1.Fill(Me.BDMIDataSet.clientes)
        Principal.ClientesTableAdapter.Update(Principal.BDMIDataSet.clientes)
        MsgBox("cliente agregado con exito!")
        Me.Close()
    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDMIDataSet)

    End Sub

    Private Sub AgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter1.Fill(Me.BDMIDataSet.clientes)

    End Sub
End Class