Imports System.Net.Mail
Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types

Module msg
    Private mail As New MailMessage
    Private sender As New SmtpClient("smtp.gmail.com")

    Private Function GenerarNumeroAleatorioDe5Digitos() As String
        Dim random As New Random()
        Return random.Next(10000, 100000)
    End Function

    Public na As String = GenerarNumeroAleatorioDe5Digitos()
    Sub Enviar(ByVal Destino As String)
        Try
            mail.To.Clear()
            mail.Body = "Su Codigo de Verificacion es: " & na
            mail.Subject = "CODIGO DE VALIDACION"
            mail.IsBodyHtml = False
            mail.From = New MailAddress("procurepharmacyvzla@gmail.com")
            mail.To.Add(Trim(Destino))
            sender.Port = 587
            sender.UseDefaultCredentials = False
            sender.Credentials = New Net.NetworkCredential("procurepharmacyvzla@gmail.com", "ygev bijv zoqm jelt")
            sender.EnableSsl = True

            sender.Send(mail)
            MessageBox.Show("El correo se envio exitosamente")

        Catch ex As Exception
            MessageBox.Show("El correo Nose envio exitosamente" & ex.Message)

        End Try
    End Sub

    Public Sub SendSms(tlf As String)
        Const accountSid As String = "ACa7f7484a7eca80f5723ee00a910324aa"
        Const authToken As String = "c628819366fd91661a7bef03406741d1"
        TwilioClient.Init(accountSid, authToken)
        Dim message = MessageResource.Create(
            body:=vbCrLf & "Tu codigo de verificacion es: " & na,
            from:=New PhoneNumber("+13852194392"),
            to:=New PhoneNumber("+58" & tlf)
        )
        Console.WriteLine($"Mensaje enviado con SID: {message.Sid}")
    End Sub


End Module
