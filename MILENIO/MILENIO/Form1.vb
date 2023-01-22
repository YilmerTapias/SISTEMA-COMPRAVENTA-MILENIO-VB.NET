Imports System.ComponentModel
Imports System.IO

Public Class Form1

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        validarUsuario(UsuarioTextBox.Text, ContraseñaTextBox.Text)

    End Sub

    Private Sub UsuariosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsuariosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDMIDataSet)

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim fileEnUso As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Dropbox\BDMILENIO\EnUso.txt"
        'If (File.Exists(fileEnUso)) Then
        '    MsgBox("EL programa esta siendo utilizado por otra persona en este momento, porfavor ingrese mas tarde!")
        '    Me.Close()
        'Else
        '    Dim fs As FileStream = File.Create(fileEnUso)
        'End If
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.BDMIDataSet.usuarios)

    End Sub

    Private Sub UsuarioTextBox_TextChanged(sender As Object, e As EventArgs)
        If (UsuarioTextBox.Text.Equals("admin")) Then
            PictureBox2.Image = My.Resources.icons8_administrador_del_hombre_80
        End If
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        BunifuTileButton1.Enabled = False
        validarUsuario(UsuarioTextBox.Text, ContraseñaTextBox.Text)
        BunifuTileButton1.Enabled = True
    End Sub
End Class
