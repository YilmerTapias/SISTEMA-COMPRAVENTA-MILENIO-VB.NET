
Imports System.Net
Imports System.Net.Mail
Imports System
Imports System.IO
Imports System.Collections
Module CorreoMilenio
    Private correos As New MailMessage
    Private envios As New SmtpClient
    Dim mail As MailMessage = New MailMessage



    Sub enviarCorreo(ByVal emisor As String, ByVal password As String, ByVal mensaje As String, ByVal asunto As String, ByVal destinatario As String, td As String)


        Try
            ' System.Net.Mail.MailMessage mail = New MailMessage();
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.Body = "<p style='text-align: center;'><strong>COMPRA VENTA MILENIO</strong></p>
             <p>Hola, " & mensaje & ".</p>
             <p>Te notificamos que hace poco, usted empe&ntilde;&oacute; los siguientes articulos.</p>
             <hr>
             <table style = 'border-collapse: collapse; width: 100%;' border='1'>
             <tr>
                <th style='width: 33.3333%;'> NOMBRE </td>
                <th style='width: 33.3333%;'> FECHA  </td>
                <th style='width: 33.3333%;'> FECHA VENCIMIENTO </td>
                </tr>" +
                  td + "
             </table>
            <br />
            <hr>
            <p>Gracias por confiar en nosotros.</p>
            <p>Dir : san carlos c&oacute;rdoba. 
             Calle Principal - Cel. 314 803 5473</p>"
            'MsgBox(correos.Body.ToString)
            correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))

            correos.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, password)

            'Datos importantes no modificables para tener acceso a las cuentas
            envios.Host = "smtp.gmail.com"
            envios.Port = 587
            envios.EnableSsl = True

            envios.Send(correos)
            'MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Sub NotificarAbono(ByVal emisor As String, ByVal password As String, ByVal asunto As String, ByVal destinatario As String, ByVal valorabono As Double, ByVal fecha As String, ByVal cod As Integer)


        Try
            correos.To.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.Body = "<p style='text-align: center;'><strong>MILENIO COMPRA-VENTA</strong></p>  
             <br />
             <p>Usted ha realizado un abono.</p>
             <p>ValorAbono: $" & valorabono & "</p>
             <hr>
            <br />
            <p>c&oacute;digo de empe&ntilde;o " & cod & ".</p>
            <p>Fecha " & fecha & ".</p>
            <hr>
            <p>Gracias por confiar en nosotros.</p>
            <p>Dir : san carlos c&oacute;rdoba. 
             Calle Principal - Cel. 314 803 5473</p>"


            MsgBox(correos.Body.ToString)
            correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))

            correos.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, password)

            'Datos importantes no modificables para tener acceso a las cuentas

            envios.Host = "smtp.gmail.com"
            envios.Port = 587
            envios.EnableSsl = True

            envios.Send(correos)
            MsgBox("El mensaje fue enviado correctamente. ", MsgBoxStyle.Information, "Mensaje")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Module
