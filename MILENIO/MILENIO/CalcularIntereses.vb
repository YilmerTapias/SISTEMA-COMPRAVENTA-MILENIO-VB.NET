Imports System.Data.OleDb
Module CalcularIntereses
    Sub intereses()

        Try
            Dim comando As New OleDb.OleDbCommand
            Dim adaptador As New OleDb.OleDbDataAdapter
            Dim registro As New DataSet
            Dim i As Integer = 0
            Dim consulta As String
            Dim lista As Integer

            Dim fechaIni As Date

            consulta = "SELECT * FROM empeño WHERE estado_producto like 'activo'"
            adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
            registro = New DataSet
            adaptador.Fill(registro, "TuTabla")
            lista = registro.Tables("TuTabla").Rows.Count
            If lista <> 0 Then
                CargaFormularioPrincipal.Label2.Text = "calculando Intereses... [ 0 /" & lista & " ]"
                While (i < lista)
                    CargaFormularioPrincipal.Label2.Text = "calculando Intereses... [" & i & "/" & lista & " ]"
                    fechaIni = registro.Tables("TuTabla").Rows(i).Item("fecha_llegada")
                    Dim codigo As Integer = registro.Tables("TuTabla").Rows(i).Item("codigo")
                    Dim valor_empeño As Double = registro.Tables("TuTabla").Rows(i).Item("valor_empeño")
                    Dim mesespagados As Integer = registro.Tables("TuTabla").Rows(i).Item("mesesPagados")
                    i += 1
                    'diferencia en dias entre fecha entrada del producto y fecha de salida del producto'
                    Dim meses As Integer = 0

                    ' On Error Resume Next
                    ' meses = DateDiff(DateInterval.Month, fechaIni, fechaactual)
                    Dim dias As Double = 0
                    dias = DateDiff(DateInterval.Day, fechaIni, Now)
                    meses = DateDiff(DateInterval.Month, fechaIni, Now)
                    Dim residuo As Decimal = dias Mod 30
                    If (dias Mod 30 = 0) Then
                        ' MsgBox("meses transcurridos" & meses & "NumDias: " & dias & "residuo: " & residuo)

                        AñadirInteresMensual(codigo, meses, dias, valor_empeño, mesespagados)
                        Application.DoEvents()

                    Else
                        meses += 1
                        ' MsgBox("meses transcurridos" & meses & "NumDias: " & dias & "residuo: " & residuo)
                        AñadirInteresMensual(codigo, meses, dias, valor_empeño, mesespagados)
                        Application.DoEvents()
                    End If

                End While
                CargaFormularioPrincipal.Close()
            Else


            End If
        Catch ex As Exception
            MsgBox("Error: un error ha ocurrido en el calculo automatico de los intereses para los empeños")
        End Try
    End Sub


    Sub interesPorCodigo(ByVal cod As Integer)
        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim i As Integer = 0
        Dim consulta As String
        Dim lista As Byte

        Dim fechaIni As Date

        consulta = "SELECT * FROM empeño where codigo=" & cod
        adaptador = New OleDb.OleDbDataAdapter(consulta, My.Settings.BDMIConnectionString)
        registro = New DataSet
        adaptador.Fill(registro, "TuTabla")
        lista = registro.Tables("TuTabla").Rows.Count
        If lista <> 0 Then
            While (i < lista)
                fechaIni = registro.Tables("TuTabla").Rows(i).Item("fecha_llegada")
                Dim codigo As Integer = registro.Tables("TuTabla").Rows(i).Item("codigo")
                Dim valor_empeño As Integer = registro.Tables("TuTabla").Rows(i).Item("valor_empeño")
                Dim mesespagados As Integer = registro.Tables("TuTabla").Rows(i).Item("mesesPagados")
                i += 1
                'diferencia en dias entre fecha entrada del producto y fecha de salida del producto'
                Dim meses As Integer = 0

                On Error Resume Next
                ' meses = DateDiff(DateInterval.Month, fechaIni, fechaactual)
                Dim dias As Double = 0
                dias = DateDiff(DateInterval.Day, fechaIni, Now)
                meses = DateDiff(DateInterval.Month, fechaIni, Now)
                Dim residuo As Decimal = dias Mod 30
                If (dias Mod 30 = 0) Then
                    ' MsgBox("meses transcurridos" & meses & "NumDias: " & dias & "residuo: " & residuo)

                    AñadirInteresMensual(codigo, meses, dias, valor_empeño, mesespagados)


                Else
                    meses += 1
                    ' MsgBox("meses transcurridos" & meses & "NumDias: " & dias & "residuo: " & residuo)
                    AñadirInteresMensual(codigo, meses, dias, valor_empeño, mesespagados)
                End If

            End While
        Else


        End If
    End Sub


    Sub AñadirInteresMensual(ByVal cod As Integer, ByVal meses As Integer, ByVal dias As Integer, ByVal valor As Integer, ByVal mesespagados As Integer)
        If (dias <= 30) Then
            meses = 1
        End If
        Dim interes As Integer = valor * (0.1 * (meses - mesespagados))
        Dim valorTotal As Integer = (valor + interes)
        'condicional para que valor total no sea negativo nunca'
        If (valorTotal < 0) Then
            valorTotal = valorTotal * -1
        End If
        Principal.EmpeñoTableAdapter.ModificarInteresMensual(interes, valorTotal, dias, cod)
        'CargaFormularioPrincipal.Close()


    End Sub
End Module
