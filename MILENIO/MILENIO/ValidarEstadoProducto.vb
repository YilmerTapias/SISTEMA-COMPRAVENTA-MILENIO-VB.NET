Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System
Imports System.IO
Imports System.Security.Permissions
Imports System.Globalization
Module ValidarEstadoProducto
    Sub CambiarActivoaHistorial()
        'comprobar y cambiar de estado todos al iniciar formulario principal
        Principal.EmpeñoTableAdapter.CAMBIAR_ACTIVO_HISTORIAL("historial", Principal.DateTimePickerActual.Value)

    End Sub
End Module
