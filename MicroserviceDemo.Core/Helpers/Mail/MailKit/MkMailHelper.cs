using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit.Text;
using MimeKit;
using MicroserviceDemo.Core.Utilities.Configuration;

namespace MicroserviceDemo.Core.Helpers.Mail.MailKit
{
    public class MkMailHelper
    {
        //"<h1>Example HTML Message Body</h1>"
        public static string SendMailWithHtml(string to, string subject, string html, string smtpServer, string from = null)
        {
            SmtpClient? smtp = null;
            string result = string.Empty;
            try
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(from ?? CoreConfig._EmailFrom));
                email.To.Add(MailboxAddress.Parse(to));
                email.Subject = subject;
                //email.Body = new TextPart(TextFormat.Html) { Text = html };
                email.Body = new TextPart(TextFormat.Html) { Text = "<h1>Example HTML Message Body</h1>" };

                // send email
                using (smtp = new SmtpClient())
                {
                    smtpServer = GenerateSmtp(smtpServer);
                    smtp.Connect(smtpServer, Convert.ToInt32(CoreConfig._EmailPort), SecureSocketOptions.StartTls);
                    smtp.Authenticate(CoreConfig._EmailUsername, CoreConfig._EmailPassword);
                    result = smtp.Send(email);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                smtp?.Disconnect(true);
            }
            return result;
        }

        private static string GenerateSmtp(string smtpServer)
        {
            if (smtpServer.Equals("gmail"))
                smtpServer = CoreConfig.GetValue("EmailConfiguration:SmtpServerGmail");
            else if (smtpServer.Equals("hotmail"))
                smtpServer = CoreConfig.GetValue("EmailConfiguration:SmtpServerHotmail");
            else if (smtpServer.Equals("office"))
                smtpServer = CoreConfig.GetValue("EmailConfiguration:SmtpServerOffice");
            return smtpServer;
        }

        public static string SendMailWithText(string to, string subject, string text, string smtpServer, string from = null)
        {
            SmtpClient? smtp = null;
            string result = string.Empty;
            try
            {
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(from ?? CoreConfig._EmailFrom));
                email.To.Add(MailboxAddress.Parse(to));
                email.Subject = subject;
                //email.Body = new TextPart(TextFormat.Plain) { Text = text };
                email.Body = new TextPart(TextFormat.Plain) { Text = "Example TEXT Message Body" };

                // send email
                using (smtp = new SmtpClient())
                {
                    smtpServer = GenerateSmtp(smtpServer);
                    smtp.Connect(smtpServer, Convert.ToInt32(CoreConfig._EmailPort), SecureSocketOptions.StartTls);
                    smtp.Authenticate(CoreConfig._EmailUsername, CoreConfig._EmailPassword);
                    result = smtp.Send(email); 
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                smtp?.Disconnect(true);
            }
            return result;
        }
    }
}
