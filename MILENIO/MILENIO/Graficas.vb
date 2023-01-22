Imports System.IO
Imports System.Data.OleDb
Module Graficas
    Dim web As WebBrowser
    Sub Dolar()
        Try
            Dim divs = Administrador.WebBrowser1.Document.Body.GetElementsByTagName("span") ' Obtiene todos los elementos <div> de la página web

            For Each div As HtmlElement In divs ' Recorre la lista de elementos <div>
                Dim className As String = div.GetAttribute("className") ' Obtiene el atributo [class] (nos servirá de filtro)
                If className = "preciodolar" Then ' El texto con el que se compara es el que muestra el valor del dólar en pesos argentinos
                    Administrador.LabelDolar.Text = div.InnerText

                End If
                'If className = "valor-small" Then ' El texto con el que se compara es el que muestra el valor del dólar en pesos argentinos
                '    ' Administrador.LabelDolar.Text = vbNewLine & div.InnerText
                '    Administrador.ComboBox2.Items.Add("[" & div.InnerText & "]")

                'End If
            Next
            Administrador.WebBrowser1.Tag = 2
            Administrador.WebBrowser1.Navigate("https://www.goldrate24.com/es/precios-del-oro/america-del-sur/colombia/gram/18K/")

        Catch ex As Exception

        End Try
    End Sub
    Sub Oro()
        Try
            Dim divs = Administrador.WebBrowser1.Document.Body.GetElementsByTagName("p") ' Obtiene todos los elementos <div> de la página web

            For Each div As HtmlElement In divs ' Recorre la lista de elementos <div>
                Dim className As String = div.GetAttribute("className") ' Obtiene el atributo [class] (nos servirá de filtro)
                If className = "h4 alert alert-info centered" Then ' El texto con el que se compara es el que muestra el valor del dólar en pesos argentinos
                    Administrador.LabelOro.Text = div.InnerText

                End If
            Next
        Catch ex As Exception

        End Try
        'MessageBox.Show("PRECIO DEL DOLAR HOY: " & Administrador.LabelDolar.Text & vbNewLine & vbNewLine & "PRECIO DEL ORO HOY: " & Administrador.LabelOro.Text, "Bienvenido!")
    End Sub


    Sub verificarMensajesNuevos(ByVal usu As String)
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim i As Integer = 0
        Dim consulta As String
        Dim lista As Integer
        consulta = "SELECT * FROM mensajes WHERE visto = true"
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla2")
        lista = registro.Tables("TuTabla2").Rows.Count
        If lista <> 0 Then
            Administrador.PictureBox8.Image = My.Resources.urgent_message_96px
        End If
    End Sub
    Sub enviarMensaje(ByVal usuario As String, ByVal tipo As String, ByVal mensaje As String)
        Administrador.MensajesTableAdapter.ENVIAR_MENSAJE(usuario, mensaje, Now, tipo)
    End Sub
    Sub enviarMensajeInvitado(ByVal usuario As String, ByVal tipo As String, ByVal mensaje As String)
        Principal.MensajesTableAdapter.ENVIAR_MENSAJE(usuario, mensaje, Now, tipo)
        Principal.ActualizarChat()
    End Sub
    Sub ActualizarChat()
        'RichTextBoxMensajes
        'listar mensajes'
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim i As Integer = 0
        Dim consulta As String
        Dim lista As Integer
        consulta = "SELECT * FROM mensajes"
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla2")
        lista = registro.Tables("TuTabla2").Rows.Count

        If lista <> 0 Then
            Administrador.RichTextBoxMensajes.Clear()
            While i < lista
                Dim usuario As String = registro.Tables("TuTabla2").Rows(i).Item("usuario")
                Dim mensaje As String = registro.Tables("TuTabla2").Rows(i).Item("mensaje")
                Dim tipo As String = registro.Tables("TuTabla2").Rows(i).Item("tipo")
                Dim hora As Date = registro.Tables("TuTabla2").Rows(i).Item("hora")
                If (usuario.Equals("invitado") And tipo.Equals("msj")) Then
                    Administrador.RichTextBoxMensajes.AppendText("[" & hora & "]  " & "<" & usuario & ">: " & mensaje & vbNewLine)
                    Administrador.RichTextBoxMensajes.AppendText(" ")
                End If
                If (usuario.Equals("invitado") And tipo.Equals("system")) Then
                    Administrador.RichTextBoxMensajes.AppendText("[" & hora & "]  " & "<" & usuario & ">: Aviso!" & mensaje & vbNewLine)
                    Administrador.RichTextBoxMensajes.AppendText(" ")
                End If
                If (usuario.Equals("administrador") And tipo.Equals("msj")) Then
                    Administrador.RichTextBoxMensajes.AppendText("[" & hora & "]  " & "<" & usuario & ">: " & mensaje & vbNewLine)
                    Administrador.RichTextBoxMensajes.AppendText(" ")
                End If
                i += 1
            End While
        End If
    End Sub
    Sub graficarGananciasMes(ByVal mes As String)

    End Sub
    Sub graficarGananciasAño(ByVal fecha As String)
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim i As Integer = 0
        Dim consulta As String
        Dim lista As Integer
        Dim ene As Integer = 0
        Dim feb As Integer = 0
        Dim marz As Integer = 0
        Dim abril As Integer = 0
        Dim may As Integer = 0
        Dim juni As Integer = 0
        Dim juli As Integer = 0
        Dim agost As Integer = 0
        Dim sep As Integer = 0
        Dim oct As Integer = 0
        Dim nov As Integer = 0
        Dim dic As Integer = 0
        consulta = "SELECT * FROM abono WHERE YEAR(fecha_abono) = '" & fecha & "'"
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla2")
        lista = registro.Tables("TuTabla2").Rows.Count

        If lista <> 0 Then

            While i < lista
                Dim mes As Date = registro.Tables("TuTabla2").Rows(i).Item("fecha_abono")
                If (mes.Month = 1) Then
                    ene += registro.Tables("TuTabla2").Rows(i).Item("valor_abono")
                End If
                If (mes.Month = 2) Then
                    feb += registro.Tables("TuTabla2").Rows(i).Item("valor_abono")
                End If
                If (mes.Month = 3) Then
                    marz += registro.Tables("TuTabla2").Rows(i).Item("valor_abono")
                End If
                If (mes.Month = 4) Then
                    abril += registro.Tables("TuTabla2").Rows(i).Item("valor_abono")
                End If
                If (mes.Month = 5) Then
                    may += registro.Tables("TuTabla2").Rows(i).Item("valor_abono")
                End If
                If (mes.Month = 6) Then
                    juni += registro.Tables("TuTabla2").Rows(i).Item("valor_abono")
                End If
                If (mes.Month = 7) Then
                    juli += registro.Tables("TuTabla2").Rows(i).Item("valor_abono")
                End If
                If (mes.Month = 8) Then
                    agost += registro.Tables("TuTabla2").Rows(i).Item("valor_abono")
                End If
                If (mes.Month = 9) Then
                    sep += registro.Tables("TuTabla2").Rows(i).Item("valor_abono")
                End If
                If (mes.Month = 10) Then
                    oct += registro.Tables("TuTabla2").Rows(i).Item("valor_abono")
                End If
                If (mes.Month = 11) Then
                    nov += registro.Tables("TuTabla2").Rows(i).Item("valor_abono")
                End If
                If (mes.Month = 12) Then
                    dic += registro.Tables("TuTabla2").Rows(i).Item("valor_abono")
                End If
                i += 1
            End While
        End If
        'recorrer retiros y empeños vendidos'
        consulta = "SELECT * FROM retiro AS E WHERE YEAR(fecha_retiro) = '" & fecha & "'"
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla2")
        lista = registro.Tables("TuTabla2").Rows.Count

        If lista <> 0 Then
            i = 0
            While i < lista
                Dim mes As Date = registro.Tables("TuTabla2").Rows(i).Item("fecha_retiro")
                If (mes.Month = 1) Then
                    ene += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 2) Then
                    feb += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 3) Then
                    marz += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 4) Then
                    abril += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 5) Then
                    may += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 6) Then
                    juni += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 7) Then
                    juli += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 8) Then
                    agost += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 9) Then
                    sep += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 10) Then
                    oct += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 11) Then
                    nov += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 12) Then
                    dic += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                i += 1
            End While
        End If

        'ventas de productos'
        consulta = "SELECT * FROM venta as E WHERE YEAR(fecha) = '" & fecha & "'"
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla2")
        lista = registro.Tables("TuTabla2").Rows.Count

        If lista <> 0 Then
            i = 0
            While i < lista
                Dim mes As Date = registro.Tables("TuTabla2").Rows(i).Item("fecha")
                If (mes.Month = 1) Then
                    ene += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 2) Then
                    feb += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 3) Then
                    marz += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 4) Then
                    abril += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 5) Then
                    may += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 6) Then
                    juni += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 7) Then
                    juli += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 8) Then
                    agost += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 9) Then
                    sep += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 10) Then
                    oct += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 11) Then
                    nov += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                If (mes.Month = 12) Then
                    dic += registro.Tables("TuTabla2").Rows(i).Item("valor")
                End If
                i += 1
            End While
        End If
        Administrador.ChartEstadisticas.Series("Series1").Points.Clear()
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Ene", ene)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Feb", feb)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Mar", marz)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Abr", abril)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("May", may)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Jun", juni)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Jul", juli)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Agost", agost)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Sept", sep)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("oct", oct)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Nov", nov)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Dic", dic)
        Administrador.ChartEstadisticas.Series("Series1").IsValueShownAsLabel = True




    End Sub

    'grafica de incio panelHome'
    Sub graficarHome()
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim i As Integer = 0
        Dim consulta As String
        Dim lista As Integer

        Dim fechaIni As Date

        consulta = "SELECT * FROM empeño"
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)

        registro = New DataSet
        adaptador.Fill(registro, "TuTabla")
        lista = registro.Tables("TuTabla").Rows.Count

        If lista <> 0 Then

            Administrador.Chart1.Series("Series1").Points.AddXY("Empeños", registro.Tables("TuTabla").Rows.Count)

        End If
        consulta = "SELECT * FROM abono "
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla")
        lista = registro.Tables("TuTabla").Rows.Count

        If lista <> 0 Then

            Administrador.Chart1.Series("Series1").Points.AddXY("Abonos", registro.Tables("TuTabla").Rows.Count)

        End If
        consulta = "SELECT * FROM retiro "
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla")
        lista = registro.Tables("TuTabla").Rows.Count

        If lista <> 0 Then

            Administrador.Chart1.Series("Series1").Points.AddXY("Retiros", registro.Tables("TuTabla").Rows.Count)

        End If
        consulta = "SELECT * FROM venta "
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla")
        lista = registro.Tables("TuTabla").Rows.Count

        If lista <> 0 Then

            Administrador.Chart1.Series("Series1").Points.AddXY("Ventas", registro.Tables("TuTabla").Rows.Count)

        End If

        consulta = "SELECT * FROM movimientos"
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla")
        lista = registro.Tables("TuTabla").Rows.Count

        If lista <> 0 Then

            Administrador.Chart1.Series("Series1").Points.AddXY("Movimientos", registro.Tables("TuTabla").Rows.Count)

        End If

    End Sub

    Sub graficarEmpeñosAño(ByVal fecha As String)
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim i As Integer = 0
        Dim consulta As String
        Dim lista As Integer
        Dim ene As Integer = 0
        Dim feb As Integer = 0
        Dim marz As Integer = 0
        Dim abril As Integer = 0
        Dim may As Integer = 0
        Dim juni As Integer = 0
        Dim juli As Integer = 0
        Dim agost As Integer = 0
        Dim sep As Integer = 0
        Dim oct As Integer = 0
        Dim nov As Integer = 0
        Dim dic As Integer = 0
        consulta = "SELECT * FROM empeño WHERE YEAR(fecha_llegada) = '" & fecha & "'"
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla2")
        lista = registro.Tables("TuTabla2").Rows.Count

        If lista <> 0 Then

            While i < lista
                Dim mes As Date = registro.Tables("TuTabla2").Rows(i).Item("fecha_llegada")
                If (mes.Month = 1) Then
                    ene += registro.Tables("TuTabla2").Rows(i).Item("valor_empeño")
                End If
                If (mes.Month = 2) Then
                    feb += registro.Tables("TuTabla2").Rows(i).Item("valor_empeño")
                End If
                If (mes.Month = 3) Then
                    marz += registro.Tables("TuTabla2").Rows(i).Item("valor_empeño")
                End If
                If (mes.Month = 4) Then
                    abril += registro.Tables("TuTabla2").Rows(i).Item("valor_empeño")
                End If
                If (mes.Month = 5) Then
                    may += registro.Tables("TuTabla2").Rows(i).Item("valor_empeño")
                End If
                If (mes.Month = 6) Then
                    juni += registro.Tables("TuTabla2").Rows(i).Item("valor_empeño")
                End If
                If (mes.Month = 7) Then
                    juli += registro.Tables("TuTabla2").Rows(i).Item("valor_empeño")
                End If
                If (mes.Month = 8) Then
                    agost += registro.Tables("TuTabla2").Rows(i).Item("valor_empeño")
                End If
                If (mes.Month = 9) Then
                    sep += registro.Tables("TuTabla2").Rows(i).Item("valor_empeño")
                End If
                If (mes.Month = 10) Then
                    oct += registro.Tables("TuTabla2").Rows(i).Item("valor_empeño")
                End If
                If (mes.Month = 11) Then
                    nov += registro.Tables("TuTabla2").Rows(i).Item("valor_empeño")
                End If
                If (mes.Month = 12) Then
                    dic += registro.Tables("TuTabla2").Rows(i).Item("valor_empeño")
                End If
                i += 1
            End While
        End If
        Administrador.ChartEstadisticas.Series("Series1").Points.Clear()
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Ene", ene)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Feb", feb)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Mar", marz)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Abr", abril)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("May", may)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Jun", juni)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Jul", juli)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Agost", agost)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Sept", sep)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("oct", oct)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Nov", nov)
        Administrador.ChartEstadisticas.Series("Series1").Points.AddXY("Dic", dic)
        Administrador.ChartEstadisticas.Series("Series1").IsValueShownAsLabel = True
    End Sub
End Module
