using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using portfolio_back.Models;
using portfolio_back;

namespace portfolio_back.Services
{
    public class SendMailService
    {
        public void sendNotification(MailRequest request)
        {
            // create email message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("pamela.lotriet@gmail.com"));
            email.To.Add(MailboxAddress.Parse("pamela.lotriet@gmail.com"));
            email.Subject = "Portfolio Inquiry";
            email.Body = new TextPart(TextFormat.Text) { Text = request.Body + "\n\n" + request.FromMail };

            // send email
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("pamela.lotriet@gmail.com", "fvwwxrasexnvpqoi");
            smtp.Send(email);
            smtp.Disconnect(true);

            sendMail(request);
        }

        public void sendMail(MailRequest request)
        {
            // create email message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("pamela.lotriet@gmail.com"));
            email.To.Add(MailboxAddress.Parse(request.FromMail));
            email.Subject = "Pamela Lotriet";
            email.Body = new TextPart(TextFormat.Text) { Text = "Good day \n\nI have recieved your email and I will get back to you as soon as possible. \n\n\nKind Regards \n Pamela Lotriet" };

            // send email
            using var smtp = new SmtpClient();
            smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("pamela.lotriet@gmail.com", "fvwwxrasexnvpqoi");
            smtp.Send(email);
            smtp.Disconnect(true);
        }
    }
}
