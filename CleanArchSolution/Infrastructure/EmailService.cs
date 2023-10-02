using Core;
using System.Net.Mail;

namespace Infrastructure;

public class EmailService: IEmailService
{
    public void SendEmail(string to, string body)
    {
        var smtpClient = new SmtpClient();
        string from = "udemy@clean.com";
        MailMessage message = new MailMessage(from, to);
        message.Subject = "Sorted List";
        message.Body = body;

        smtpClient.DeliveryMethod = SmtpDeliveryMethod.SpecifiedPickupDirectory;
        var emailPickupDirectory = "C:\\email";
        if (!Directory.Exists(emailPickupDirectory))
        {
            Directory.CreateDirectory(emailPickupDirectory);
        }
        smtpClient.PickupDirectoryLocation = emailPickupDirectory;

        smtpClient.Send(message);
    }
}
