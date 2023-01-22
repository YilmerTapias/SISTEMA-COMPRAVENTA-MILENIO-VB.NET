Module Validacion
    Sub validarUsuario(ByVal user As String, ByVal pass As String)
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim i As Integer = 0
        Dim consulta As String
        Dim lista As Byte

        Try

            consulta = "SELECT * FROM usuarios WHERE usuario like '" & user & "' and contraseña like '" & pass & "'"
            adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
            registro = New DataSet
            adaptador.Fill(registro, "TuTabla")
            lista = registro.Tables("TuTabla").Rows.Count
            If lista <> 0 Then

                Dim nivel As Boolean = registro.Tables("TuTabla").Rows(0).Item("acceso_completo")
                If (nivel = True) Then
                    Administrador.Show()
                    Form1.Close()
                Else
                    CargaFormularioPrincipal.Show()
                    'Principal.Show()
                    Form1.Close()
                End If
            Else
                MsgBox("usuario o contraseña son incorrectos!")
                Form1.Show()
                Form1.UsuarioTextBox.Text = ""
                Form1.ContraseñaTextBox.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Error al intentar iniciar sesion! intente nuevamente.")

        End Try
    End Sub

    Function validarUsuarioOpciones(ByVal user As String, ByVal pass As String)
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim i As Integer = 0
        Dim consulta As String
        Dim lista As Byte
        Dim resp As Boolean = False
        Try

            consulta = "SELECT * FROM usuarios WHERE usuario like '" & user & "' and contraseña like '" & pass & "'"
            adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
            registro = New DataSet
            adaptador.Fill(registro, "TuTabla")
            lista = registro.Tables("TuTabla").Rows.Count

            If lista <> 0 Then
                resp = True

            Else
                resp = False
            End If
        Catch ex As Exception
            MsgBox("Error al validar!.")

        End Try
        Return resp
    End Function
End Module
