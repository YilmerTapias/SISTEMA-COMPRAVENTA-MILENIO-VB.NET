Imports System.Data.OleDb
Imports System.Data.SqlClient

Module Caja
    Function ArqueoDeCaja(fecha As Date)
        Dim ingresos As Double
        MsgBox("ventas " & Ventas())
        ' ingresos = Ventas(fecha) + pagosIntereses() + ventasDeOro() + Desempeños()

    End Function
    'ingresos'
    Function verificarSiHayArqueos()
        Try


            Dim resul As Boolean = False
            Dim comando As New OleDb.OleDbCommand
            Dim adaptador As New OleDb.OleDbDataAdapter
            Dim registro As New DataSet
            Dim i As Integer = 0
            Dim consulta As String
            Dim lista As Byte

            consulta = "SELECT COUNT(*) as cont FROM arqueo"
            adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
            registro = New DataSet
            adaptador.Fill(registro, "TuTabla")
            lista = registro.Tables("TuTabla").Rows.Count
            If lista <> 0 And registro.Tables("TuTabla").Rows(0).Item("cont") > 0 Then

                resul = True

            End If
            Return resul
        Catch ex As Exception

        End Try
    End Function

    Function Ventas()
        Dim resul As Double = 0
        If (verificarSiHayArqueos() = True) Then
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT SUM(valor) as val FROM venta WHERE fecha = @fecha"
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now.Date)
                Dim ultimoarqueo As Date = Principal.ArqueoTableAdapter.ULTIMO_ARQUEO()
                COMANDO.Parameters.AddWithValue("@UltimoArqueo", ultimoarqueo)
                Dim DR As OleDbDataReader = COMANDO.ExecuteReader
                If (DR.Read) Then
                    resul = DR(0)
                End If
                DR.Close()
                CONEXION.Close()

            Catch ex As Exception
                ' MsgBox(ex.Message)
            End Try
        Else
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT SUM(valor) as val FROM venta WHERE fecha <= @fecha"
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now.Date)
                Dim DR As OleDbDataReader = COMANDO.ExecuteReader
                If (DR.Read) Then
                    resul = DR(0)
                End If
                DR.Close()
                CONEXION.Close()

            Catch ex As Exception
                ' MsgBox(ex.Message)
            End Try
        End If
        Return resul

    End Function
    Function pagosIntereses()
        Dim resul As Double = 0
        If (verificarSiHayArqueos() = True) Then
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT SUM(valor_abono) as val FROM abono WHERE fecha_abono = @fecha"
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now.Date)
                Dim ultimoarqueo As Date = Principal.ArqueoTableAdapter.ULTIMO_ARQUEO()
                ultimoarqueo = ultimoarqueo.Date
                COMANDO.Parameters.AddWithValue("@UltimoArqueo", ultimoarqueo)

                Dim DR As OleDbDataReader = COMANDO.ExecuteReader
                If (DR.Read) Then
                    resul = DR(0)
                End If
                DR.Close()
                CONEXION.Close()

            Catch ex As Exception
                'MsgBox(ex.Message)
            End Try
        Else
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT SUM(valor_abono) as val FROM abono WHERE fecha_abono <= @fecha"
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now)
                Dim DR As OleDbDataReader = COMANDO.ExecuteReader
                If (DR.Read) Then
                    resul = DR(0)
                End If
                DR.Close()
                CONEXION.Close()

            Catch ex As Exception
                ' MsgBox(ex.Message)
            End Try
        End If
        Return resul
    End Function
    Function Desempeños()
        Dim resul As Double = 0
        If (verificarSiHayArqueos() = True) Then
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT SUM(valor) as val FROM retiro WHERE fecha_retiro = @fecha"
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now.Date)
                Dim ultimoarqueo As Date = Principal.ArqueoTableAdapter.ULTIMO_ARQUEO()

                COMANDO.Parameters.AddWithValue("@UltimoArqueo", ultimoarqueo)
                Dim DR As OleDbDataReader = COMANDO.ExecuteReader
                If (DR.Read) Then
                    resul = DR(0)
                End If
                DR.Close()
                CONEXION.Close()

            Catch ex As Exception
                ' MsgBox(ex.Message)
            End Try
        Else
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT SUM(valor) as val FROM retiro WHERE fecha_retiro <= @fecha"
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now.Date)
                Dim DR As OleDbDataReader = COMANDO.ExecuteReader
                If (DR.Read) Then
                    resul = DR(0)
                End If
                DR.Close()
                CONEXION.Close()

            Catch ex As Exception
                ' MsgBox(ex.Message)
            End Try
        End If
        Return resul
    End Function

    'egresos'
    Function CompraOro()
        Dim resul As Double = 0
        If (verificarSiHayArqueos() = True) Then
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT SUM(valor) as val FROM Oro WHERE fecha = @fecha"
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now.Date)
                Dim ultimoarqueo As Date = Principal.ArqueoTableAdapter.ULTIMO_ARQUEO()
                COMANDO.Parameters.AddWithValue("@UltimoArqueo", ultimoarqueo)
                Dim DR As OleDbDataReader = COMANDO.ExecuteReader
                If (DR.Read) Then
                    resul = DR(0)
                End If
                DR.Close()
                CONEXION.Close()

            Catch ex As Exception
                ' MsgBox(ex.Message)
            End Try
        Else
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT SUM(valor) as val FROM Oro WHERE fecha <= @fecha"
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now.Date)
                Dim DR As OleDbDataReader = COMANDO.ExecuteReader
                If (DR.Read) Then
                    resul = DR(0)
                End If
                DR.Close()
                CONEXION.Close()

            Catch ex As Exception
                ' MsgBox(ex.Message)
            End Try
        End If
        Return resul

    End Function


    Function empeños()
        Dim resul As Double = 0
        If (verificarSiHayArqueos() = True) Then
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT SUM(valor_empeño) as val FROM empeño WHERE fecha_llegada = @fecha and estado_producto like 'activo' or fecha_llegada = @fecha2 and estado_producto like 'historico'"
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now.Date)

                Dim ultimoarqueo As Date = Principal.ArqueoTableAdapter.ULTIMO_ARQUEO()
                COMANDO.Parameters.AddWithValue("@UltimoArqueo", ultimoarqueo)
                COMANDO.Parameters.AddWithValue("@fecha2", Now.Date)
                COMANDO.Parameters.AddWithValue("@UltimoArqueo2", ultimoarqueo)
                Dim DR As OleDbDataReader = COMANDO.ExecuteReader
                If (DR.Read) Then
                    resul = DR(0)
                Else
                    resul = 0
                End If
                DR.Close()
                CONEXION.Close()

            Catch ex As Exception
                ' MsgBox(ex.Message)
            End Try
        Else
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT SUM(valor_empeño) as val FROM empeño WHERE fecha_llegada <= @fecha and estado_producto like 'activo' or fecha_llegada <= @fecha and estado_producto like 'historico'"
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now.Date)
                Dim DR As OleDbDataReader = COMANDO.ExecuteReader
                If (DR.Read) Then
                    resul = DR(0)
                End If
                DR.Close()
                CONEXION.Close()

            Catch ex As Exception
                ' MsgBox(ex.Message)
            End Try
        End If
        Return resul
    End Function

    Function gastos()
        Dim resul As Double = 0
        If (verificarSiHayArqueos() = True) Then
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT SUM(valor) as val FROM gasto WHERE fecha = @fecha "
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now.Date)

                Dim ultimoarqueo As Date = Principal.ArqueoTableAdapter.ULTIMO_ARQUEO()
                COMANDO.Parameters.AddWithValue("@UltimoArqueo", ultimoarqueo)
                COMANDO.Parameters.AddWithValue("@fecha2", Now.Date)
                COMANDO.Parameters.AddWithValue("@UltimoArqueo2", ultimoarqueo)
                Dim DR As OleDbDataReader = COMANDO.ExecuteReader
                If (DR.Read) Then
                    resul = DR(0)
                Else
                    resul = 0
                End If
                DR.Close()
                CONEXION.Close()

            Catch ex As Exception
                ' MsgBox(ex.Message)
            End Try
        Else
            Try
                Dim CONEXION As New OleDbConnection(My.Settings.BDMIConnectionString)
                CONEXION.Open()
                Dim CONSULTA As String = "SELECT SUM(valor) as val FROM gasto WHERE fecha <= @fecha"
                Dim COMANDO As New OleDbCommand(CONSULTA, CONEXION)
                COMANDO.Parameters.AddWithValue("@fecha", Now.Date)
                Dim DR As OleDbDataReader = COMANDO.ExecuteReader
                If (DR.Read) Then
                    resul = DR(0)
                End If
                DR.Close()
                CONEXION.Close()

            Catch ex As Exception
                '  MsgBox(ex.Message)
            End Try
        End If
        Return resul
    End Function

End Module
