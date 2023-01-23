namespace DIMVC.Tools
{
    public static class Mail
    {
        public static bool SendMail(string userMail, string subject, string body, bool isHTML = false)
        {
            try
            {


                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.IsBodyHtml = isHTML;

                mail.From = new System.Net.Mail.MailAddress("tsertsvadzeiphone@gmail.com", "Activation Mail");

                mail.To.Add(userMail);
                mail.Subject = subject;
                mail.Body = body;

                System.Net.Mail.SmtpClient SmtpServer = new System.Net.Mail.SmtpClient("smtp-relay.sendinblue.com");
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("raticercvadze@gmail.com", "PbGpWqYUBagRMjCk");
                SmtpServer.EnableSsl = false;

                SmtpServer.Send(mail);
                return true;
            }
            catch
            {
                return false;
            }
        }

       
    }
}
