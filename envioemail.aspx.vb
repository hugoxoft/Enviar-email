
Public Class envioemail
    Inherits System.Web.UI.Page
    Protected Sub Button_enviar_Click(sender As Object, e As EventArgs)
        Try
            Dim usuario As String = "hugoxoft@hotmail.com"
            Dim contrasena As String = "xsmtpsib-b8ab6b65cefd87880f9298cf5d9f8e4653779329418bfe0425c8044f1911978e-yOFxfR1stjH9KNIw"

            Dim correo As New System.Net.Mail.MailMessage
            correo.To.Add(Me.TextBox_destino.Text)
            correo.From = New System.Net.Mail.MailAddress(usuario)
            'correo.CC.Add("")
            'correo.Bcc.Add("")
            correo.Subject = Me.TextBox_titulo.Text
            correo.Body = "<br>" & "<strong>" + Me.TextBox_contenido.Text + "</strong>"
            correo.IsBodyHtml = True
            correo.Priority = System.Net.Mail.MailPriority.Normal
            Dim smtp As New System.Net.Mail.SmtpClient("smtp-relay.sendinblue.com")
            smtp.UseDefaultCredentials = False
            smtp.Port = 587
            smtp.Credentials = New System.Net.NetworkCredential(usuario, contrasena)
            smtp.Send(correo)
            ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "alertMessage", "alert('Se ha enviado el email')", True)
        Catch ex As Exception
            ScriptManager.RegisterClientScriptBlock(Me, Me.GetType(), "alertMessage", "alert('" + ex.Message + "')", True)
        End Try
    End Sub

End Class