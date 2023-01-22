Imports System.IO
Module GestorDeAcciones
    'verificamos si la base de datos esta siendo modificada por otro'

    Function DisponibilidadBD()
        Dim ocupado = Application.StartupPath + "/OcupadoTemp.txt"
        If (File.Exists(ocupado)) Then
            FrmEspera.ShowDialog()
            Return True
        Else
            FrmEspera.Close()
            Return False
        End If

    End Function

End Module
