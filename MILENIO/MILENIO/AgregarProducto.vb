Public Class AgregarProducto
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim oreg As New ListViewItem(ComboBox1.Text)
        With (oreg)
            .SubItems.Add(TextBox8.Text)
            .SubItems.Add(TextBox9.Text)
            .SubItems.Add(RichTextBox1.Text)
            'ListViewProductos.Items.Add(oreg)
            Principal.ListViewProductos.Items.Add(oreg)
            Principal.ListViewProductos.Refresh()
        End With
        'frm.ListViewProductos.Refresh()
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedIndex = 6) Then
            Dim result As String = InputBox("Escriba el Tipo de producto", "Tipo Producto", "")
            If result <> "" Then
                ComboBox1.Items.Add(result)
                ComboBox1.SelectedIndex = 7

            Else
                MsgBox("Debe digitar el tipo de producto")
                Return
            End If
        End If
    End Sub




    Private Sub TextBox8_LostFocus(sender As Object, e As EventArgs) Handles TextBox8.LostFocus
        If (TextBox8.Text <> "") Then
            Dim content As String = TextBox8.Text
            TextBox8.Text = content.ToString.Replace(".", ",")
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class