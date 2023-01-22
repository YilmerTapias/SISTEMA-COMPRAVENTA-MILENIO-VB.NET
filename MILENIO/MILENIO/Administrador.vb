Imports System.IO
Imports System.Data.OleDb
Public Class Administrador
    Dim fileEnUso As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Dropbox\BDMILENIO\EnUso.txt"
    Public Shared codigoEmpeñoAdministrador As Integer = 0
    Public Shared cedulaEmpeñoAdministrador As Integer = 0
    Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Dropbox\BDMILENIO\BDMI.mdb"
    Dim dt1 As DateTime = File.GetLastWriteTime(path)
    Dim cont As Integer = 0
    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet1.usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.BDMIDataSet1.usuarios)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet1.mensajes' Puede moverla o quitarla según sea necesario.
        Me.MensajesTableAdapter.Fill(Me.BDMIDataSet1.mensajes)

        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet1.empeño' Puede moverla o quitarla según sea necesario.
        Me.EmpeñoTableAdapter.Fill(Me.BDMIDataSet1.empeño)
        'TODO: esta línea de código carga datos en la tabla 'BDMIDataSet1.movimientos' Puede moverla o quitarla según sea necesario.
        'Me.MovimientosTableAdapter1.Fill(Me.BDMIDataSet1.movimientos)
        'Dim buttonColumnEliminar As New DataGridViewImageColumn()
        'buttonColumnEliminar.Name = "MH"
        'MovimientosDataGridView.Columns.Add(buttonColumnEliminar)
        'cargar registro de hoy a datagridview movimientos '

        MovimientosTableAdapter1.MOVIMIENTOS_HOY(BDMIDataSet1.movimientos, Now.Date)
        graficarHome()
        verificarMensajesNuevos("administrador")
        'agregar icono a datagridview movimientos'
        'Dolar hoy'
        Timer1.Enabled = True
        Dim buttonColumnDetalles As New DataGridViewButtonColumn()
        buttonColumnDetalles.Name = "Detalles"
        DataGridViewRemates.Columns.Add(buttonColumnDetalles)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles PanelHome.Paint
        'Dim comando As New OleDb.OleDbCommand
        'Dim adaptador As New OleDb.OleDbDataAdapter
        'Dim registro As New DataSet
        'Dim i As Integer = 0
        'Dim consulta As String
        'Dim lista As Byte
        'Dim ds As DataSet

        'Dim fechaIni As Date

        'consulta = "SELECT * FROM empeño WHERE fechallegada=" & Now
        'adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        'registro = New DataSet
        'adaptador.Fill(registro, "TuTabla")
        'lista = registro.Tables("TuTabla").Rows.Count
        'If lista <> 0 Then
        '    While (i < lista)
        '        ' fechaIni = registro.Tables("TuTabla").Rows(i).Item("fecha_llegada")
        '        ' Dim codigo As Integer = registro.Tables("TuTabla").Rows(i).Item("codigo")
        '    End While
        'End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        PanelHome.BringToFront()
    End Sub

    Private Sub TimerActualizar_Tick(sender As Object, e As EventArgs) Handles TimerActualizar.Tick
        Dim dt2 As DateTime = File.GetLastWriteTime(path)
        If File.Exists(path) = False Then
            MsgBox("Base de datos no encontrada, verifique si el archivo se encuentra en la ruta: " + Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\Dropbox\")
        Else
            If (dt2 <> dt1) Then
                MovimientosTableAdapter1.MOVIMIENTOS_HOY(BDMIDataSet1.movimientos, Now.Date)
                Chart1.Series("Series1").Points.Clear()
                graficarHome()
                ActualizarChat()

            End If

        End If
        dt1 = File.GetLastWriteTime(path)
    End Sub

    Private Sub MovimientosBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MovimientosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BDMIDataSet)

    End Sub
    Private Sub MovimientosHoy()
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim i As Integer = 0
        Dim consulta As String
        Dim lista As Byte

        Dim fechaIni As Date = Now
        'MsgBox(Now.Date)
        consulta = "SELECT * FROM movimientos WHERE CDate(fecha) =" & Format(Now.Date, "dd/MM/yyyy")
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla")
        lista = registro.Tables("TuTabla").Rows.Count

        If lista <> 0 Then
            '         MovimientosTableAdapter1.MOVIMIENTOS_HOY(BDMIDataSet1.movimientos, Now.Date)
            'While (i < lista)
            '    MovimientosDataGridView.Item(0, i).Value = registro.Tables("TuTabla").Rows(i).Item("id")
            '    MovimientosDataGridView.Item(1, i) = registro.Tables("TuTabla").Rows(i).Item("movimiento")
            '    MovimientosDataGridView.Item(2, i) = registro.Tables("TuTabla").Rows(i).Item("valor")
            '    MovimientosDataGridView.Item(3, i) = registro.Tables("TuTabla").Rows(i).Item("fecha")

            '    i += 1
            'End While
            MovimientosDataGridView.DataSource = registro
        End If

    End Sub

    Private Sub MovimientosBindingSource1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MovimientosBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.BDMIDataSet1)

    End Sub

    Private Sub MovimientosDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles MovimientosDataGridView.CellContentClick

    End Sub

    Private Sub MovimientosDataGridView_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles MovimientosDataGridView.CellPainting

        'If (e.ColumnIndex = 4 And e.RowIndex >= 0) Then

        '    e.Paint(e.CellBounds, DataGridViewPaintParts.All)
        '    Dim celbuton As DataGridViewButtonCell = MovimientosDataGridView.Rows(e.RowIndex).Cells("MH")
        '    Dim ico As Icon = New Icon(Environment.CurrentDirectory & "\iconos\icons8_Delete.ico")
        '        e.Graphics.DrawIcon(ico, e.CellBounds.Left + 3, e.CellBounds.Top + 3)
        '        MovimientosDataGridView.Rows(e.RowIndex).Height = ico.Height + 8
        '        MovimientosDataGridView.Columns(e.ColumnIndex).Width = ico.Width + 8
        '        e.Handled = True

        'End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.SelectedIndex() = 0) Then
            Dim Result As String = InputBox("Digite un año:", "!!!", Now.Year)

            If String.IsNullOrEmpty(Result) Then
                MessageBox.Show("Se cancelo el Inputbox")

            Else
                graficarGananciasAño(Result)
            End If

        End If
        If (ComboBox1.SelectedIndex() = 1) Then
            Dim Result As String = InputBox("Digite un año:", "!!!", Now.Year)

            If String.IsNullOrEmpty(Result) Then
                MessageBox.Show("Se cancelo el Inputbox")

            Else
                graficarEmpeñosAño(Result)
            End If

        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        GroupBoxMensaje.Visible = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        GroupBoxMensaje.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        PanelOtros.Visible = False
        PanelRemates.Visible = False
        PanelEstadisticas.Visible = False
        PanelNotificaciones.Visible = False
        PanelHome.Visible = True
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PanelOtros.Visible = False
        PanelRemates.Visible = False
        PanelHome.Visible = False
        PanelNotificaciones.Visible = False
        PanelEstadisticas.Visible = True
        graficarGananciasAño(Now.Year)
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        PanelOtros.Visible = False
        PanelRemates.Visible = False
        PanelHome.Visible = False
        PanelEstadisticas.Visible = False
        PanelNotificaciones.Visible = True
        PictureBox8.Image = My.Resources.message_96px
        MensajesTableAdapter.VISTO(True, "invitado")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        ChartEstadisticas.Series("Series1").ChartType = 7
        ChartEstadisticas.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        ChartEstadisticas.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Column
        ChartEstadisticas.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs)
        ChartEstadisticas.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Line
        ChartEstadisticas.ChartAreas("ChartArea1").Area3DStyle.Enable3D = False
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs)
        ChartEstadisticas.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Pie
        ChartEstadisticas.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
    End Sub

    Private Sub PanelNotificaciones_Paint(sender As Object, e As PaintEventArgs) Handles PanelNotificaciones.Paint
        ActualizarChat()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ButtoneEnviar.Click
        If (RichTextBox1.Text <> "") Then

            enviarMensaje("administrador", "msj", RichTextBox1.Text)
            RichTextBox1.Text = ""
        Else
            MsgBox("debe escribir un mensaje")
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If (WebBrowser1.Tag = 1) Then
            Dolar()
        Else
            Oro()
        End If

    End Sub

    Private Sub PanelRemates_Paint(sender As Object, e As PaintEventArgs) Handles PanelRemates.Paint

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        PanelOtros.Visible = False
        PanelHome.Visible = False
        PanelEstadisticas.Visible = False
        PanelNotificaciones.Visible = False
        PanelRemates.Visible = True



    End Sub

    Private Sub ButtonRematar_Click(sender As Object, e As EventArgs) Handles ButtonRematar.Click
        ButtonRematar.Enabled = False
        Dim i As Integer = 0
        While (i < DataGridViewRemates.Rows.Count)
            If (DataGridViewRemates.Rows(i).Cells(0).Value = True) Then
                ' MsgBox("seleccionado: " & DataGridViewRemates.Rows(i).Cells(1).Value)
                EmpeñoTableAdapter.HISTORICO("historico", DataGridViewRemates.Rows(i).Cells(8).Value)
            End If
            i += 1
        End While
        ' DataGridViewRemates.Rows.Clear()
        ListarEmpeñosEnRiesgo()
        MsgBox("Todos los empeños seleccionados han sido rematados correctamente")
        ButtonRematar.Enabled = True
    End Sub

    Private Sub DataGridViewRemates_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRemates.CellContentClick

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles ButtonListar.Click
        ListarEmpeñosEnRiesgo()

    End Sub
    Private Sub ListarEmpeñosEnRiesgo()
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim i As Integer = 0
        Dim consulta As String
        Dim lista As Integer
        Dim fechaIni As Date = Now

        consulta = "SELECT * FROM empeño WHERE estado_producto like 'activo' "
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla")
        lista = registro.Tables("TuTabla").Rows.Count

        If lista <> 0 Then
            'DataGridViewRemates.Rows.Clear()
            Dim dt As New DataTable("Empeños_Rematar")

            dt.Columns.Add("ValorEmpeño")
            dt.Columns.Add("InteresAcumulado")
            dt.Columns.Add("ValorTotal")
            dt.Columns.Add("#MesesPagos")
            dt.Columns.Add("FechaLLegada")
            dt.Columns.Add("NumeroDias")
            dt.Columns.Add("Codigo")
            dt.Columns.Add("CC")


            While i < lista
                Dim fechallegada As Date = registro.Tables("TuTabla").Rows(i).Item("fecha_llegada")
                Dim mesespagados As Integer = registro.Tables("TuTabla").Rows(i).Item("mesesPagados")
                Dim dias As Double = 0
                Dim meses As Integer = 0
                dias = DateDiff(DateInterval.Day, fechallegada, Now)
                meses = DateDiff(DateInterval.Month, fechallegada, Now)
                Dim residuo As Decimal = dias Mod 30
                If (dias Mod 30 = 0) Then

                Else
                    meses += 1

                End If
                If ((meses - mesespagados) >= 6) Then
                    'DataGridViewRemates.Rows.Add()
                    Dim valoremp = registro.Tables("TuTabla").Rows(i).Item("valor_empeño")
                    Dim int = registro.Tables("TuTabla").Rows(i).Item("interes")
                    Dim valorT = registro.Tables("TuTabla").Rows(i).Item("valor_total")
                    Dim mesesP = registro.Tables("TuTabla").Rows(i).Item("mesesPagados")
                    Dim fech = registro.Tables("TuTabla").Rows(i).Item("fecha_llegada")
                    'Dim cedula = registro.Tables("TuTabla").Rows(i).Item("cedula_cliente")
                    Dim codigo = registro.Tables("TuTabla").Rows(i).Item("codigo")

                    Dim dr As DataRow
                    dr = dt.NewRow()

                    dr("ValorEmpeño") = valoremp
                    dr("InteresAcumulado") = int
                    dr("ValorTotal") = valorT
                    dr("#MesesPagos") = mesesP
                    dr("FechaLLegada") = fech
                    dr("NumeroDias") = dias
                    dr("Codigo") = codigo
                    dr("CC") = registro.Tables("TuTabla").Rows(i).Item("cedula_cliente")

                    dt.Rows.Add(dr)

                End If

                i += 1
            End While
            Dim ds As New DataSet()
            ds.Tables.Add(dt)
            DataGridViewRemates.DataSource = ds.Tables("Empeños_Rematar")

        End If
    End Sub
    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonSeleccionarTodos.CheckedChanged

        Dim i As Integer = 0
        While (i < DataGridViewRemates.Rows.Count - 1)
            If (RadioButtonSeleccionarTodos.Checked = True) Then
                DataGridViewRemates.Rows(i).Cells(0).Value = True
            Else
                DataGridViewRemates.Rows(i).Cells(0).Value = False
            End If
            i += 1
        End While
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dolar()
        Timer1.Enabled = False
    End Sub

    Private Sub ToolStripComboBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

        PanelHome.Visible = False
        PanelNotificaciones.Visible = False
        PanelEstadisticas.Visible = False
        PanelRemates.Visible = False
        PanelOtros.Visible = True
    End Sub

    Private Sub BARRAToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ChartEstadisticas.Series("Series1").ChartType = 7
        ChartEstadisticas.ChartAreas("ChartArea1").Area3DStyle.Enable3D = False
    End Sub

    Private Sub LINEAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LINEAToolStripMenuItem.Click
        ChartEstadisticas.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Line
        ChartEstadisticas.ChartAreas("ChartArea1").Area3DStyle.Enable3D = False
    End Sub

    Private Sub LINEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LINEToolStripMenuItem.Click
        ChartEstadisticas.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Line
        ChartEstadisticas.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
    End Sub

    Private Sub BARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BARToolStripMenuItem.Click
        ChartEstadisticas.Series("Series1").ChartType = 7
        ChartEstadisticas.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
    End Sub

    Private Sub TORTAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TORTAToolStripMenuItem.Click
        ChartEstadisticas.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Pie
        ChartEstadisticas.ChartAreas("ChartArea1").Area3DStyle.Enable3D = False
    End Sub

    Private Sub TORTAToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TORTAToolStripMenuItem1.Click
        ChartEstadisticas.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Pie
        ChartEstadisticas.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
    End Sub

    Private Sub COLUMNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COLUMNToolStripMenuItem.Click
        ChartEstadisticas.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Column
        ChartEstadisticas.ChartAreas("ChartArea1").Area3DStyle.Enable3D = False
    End Sub

    Private Sub COLUMNToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles COLUMNToolStripMenuItem1.Click
        ChartEstadisticas.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Column
        ChartEstadisticas.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
    End Sub

    Private Sub AREAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AREAToolStripMenuItem.Click
        ChartEstadisticas.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Area
        ChartEstadisticas.ChartAreas("ChartArea1").Area3DStyle.Enable3D = False
    End Sub

    Private Sub AREAToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AREAToolStripMenuItem1.Click
        ChartEstadisticas.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Area
        ChartEstadisticas.ChartAreas("ChartArea1").Area3DStyle.Enable3D = True
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If (DisponibilidadBD()) Then
            MsgBox("La base de datos esta siendo modificada en el mismo instante. vuelva a intertarlo")
        Else
            MsgBox("listo")
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim i As Integer = 0
        Dim consulta As String
        Dim lista As Byte
        Dim fechaIni As Date = Now

        consulta = "SELECT * FROM empeño WHERE estado_producto like 'activo' "
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla")
        lista = registro.Tables("TuTabla").Rows.Count

        If lista <> 0 Then
            'DataGridViewRemates.Rows.Clear()
            Dim dt As New DataTable("Empeños_Rematar")

            dt.Columns.Add("ValorEmpeño")
            dt.Columns.Add("InteresAcumulado")
            dt.Columns.Add("ValorTotal")
            dt.Columns.Add("#MesesPagos")
            dt.Columns.Add("FechaLLegada")
            dt.Columns.Add("NumeroDias")
            dt.Columns.Add("Codigo")

            While i < lista
                Dim fechallegada As Date = registro.Tables("TuTabla").Rows(i).Item("fecha_llegada")
                Dim mesespagados As Integer = registro.Tables("TuTabla").Rows(i).Item("mesesPagados")
                Dim dias As Double = 0
                Dim meses As Integer = 0
                dias = DateDiff(DateInterval.Day, fechallegada, Now)
                meses = DateDiff(DateInterval.Month, fechallegada, Now)
                Dim residuo As Decimal = dias Mod 30
                If (dias Mod 30 = 0) Then

                Else
                    meses += 1

                End If
                If ((meses - mesespagados) >= 6) Then
                    'DataGridViewRemates.Rows.Add()
                    Dim valoremp = registro.Tables("TuTabla").Rows(i).Item("valor_empeño")
                    Dim int = registro.Tables("TuTabla").Rows(i).Item("interes")
                    Dim valorT = registro.Tables("TuTabla").Rows(i).Item("valor_total")
                    Dim mesesP = registro.Tables("TuTabla").Rows(i).Item("mesesPagados")
                    Dim fech = registro.Tables("TuTabla").Rows(i).Item("fecha_llegada")
                    'Dim cedula = registro.Tables("TuTabla").Rows(i).Item("cedula_cliente")
                    Dim codigo = registro.Tables("TuTabla").Rows(i).Item("codigo")

                    Dim dr As DataRow
                    dr = dt.NewRow()

                    dr("ValorEmpeño") = valoremp
                    dr("InteresAcumulado") = int
                    dr("ValorTotal") = valorT
                    dr("#MesesPagos") = mesesP
                    dr("FechaLLegada") = fech
                    dr("NumeroDias") = dias
                    dr("Codigo") = codigo
                    dt.Rows.Add(dr)

                End If

                i += 1
            End While
            Dim ds As New DataSet()
            ds.Tables.Add(dt)
            DataGridViewRemates.DataSource = ds.Tables("Empeños_Rematar")

        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Principal.Show()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub CambiarContraseñaAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CambiarContraseñaAdminToolStripMenuItem.Click
        Dim pass As String = InputBox("Para esta accion Debe tener permisos de administrador, Porfavor introduzca la contraseña administrador", "Validacion!", "")

        If String.IsNullOrEmpty(pass) Then
            MessageBox.Show("No ingreso ninguna Contraseña")
            Return
        Else

            If (validarUsuarioOpciones("admin", pass) = True) Then
                Dim NewPass As String = InputBox("Digite la nueva contraseña administrador, Nota! no debe contener simbolos", "Validacion!")
                UsuariosTableAdapter.ACTUALIZAR_CONTRASEÑA(NewPass, 1)
                MsgBox("Contraseña cambiada con exito!!")
            Else
                MsgBox("Contraseña incorrecta")
            End If
        End If
    End Sub

    Private Sub ToolStripDropDownButton1_Click(sender As Object, e As EventArgs) Handles ToolStripDropDownButton1.Click

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        Dim i As Integer = 0
            While (i < DataGridViewRemates.Rows.Count - 1)
            If (CheckBox1.Checked = True) Then
                DataGridViewRemates.Rows(i).Cells(0).Value = True
            Else
                DataGridViewRemates.Rows(i).Cells(0).Value = False
                End If
                i += 1
            End While

    End Sub

    Private Sub Administrador_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not Directory.Exists(fileEnUso) Then
            My.Computer.FileSystem.DeleteFile(fileEnUso)
        End If

    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If PanelInfo.Visible = False Then
            PanelInfo.Visible = True
        Else
            PanelInfo.Visible = False
        End If
    End Sub

    Private Sub DataGridViewRemates_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRemates.CellClick
        If (e.ColumnIndex >= 0) Then
            If (DataGridViewRemates.Columns(e.ColumnIndex).Name = "Detalles") Then
                codigoEmpeñoAdministrador = DataGridViewRemates.Rows(e.RowIndex).Cells(8).Value
                cedulaEmpeñoAdministrador = DataGridViewRemates.Rows(e.RowIndex).Cells(9).Value

                DetallesEmpeñoRemate.ShowDialog()

            Else


            End If
        End If
    End Sub

    Private Sub DataGridViewRemates_CellPainting(sender As Object, e As DataGridViewCellPaintingEventArgs) Handles DataGridViewRemates.CellPainting
        If (e.ColumnIndex = 1 And e.RowIndex >= 0) Then
            e.Paint(e.CellBounds, DataGridViewPaintParts.All)
            Dim celbuton As DataGridViewButtonCell = DataGridViewRemates.Rows(e.RowIndex).Cells("Detalles")
            Dim ico As Icon = New Icon(Environment.CurrentDirectory & "\iconos\icons8_info.ico")
            e.Graphics.DrawIcon(ico, e.CellBounds.Left + 3, e.CellBounds.Top + 3)
            DataGridViewRemates.Rows(e.RowIndex).Height = ico.Height + 8
            DataGridViewRemates.Columns(e.ColumnIndex).Width = ico.Width + 8
            e.Handled = True
        End If
    End Sub

    Private Sub ToolStrip3_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip3.ItemClicked

    End Sub
End Class