using ApiNet8.Models;
using ApiNet8.Services.IServices;
using Microsoft.Extensions.Options;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

public class EmailService : IEmailService
{
    private readonly EmailSettings _emailSettings;

    public EmailService(IOptions<EmailSettings> emailSettings)
    {
        _emailSettings = emailSettings.Value;
    }

    public async Task SendEmailAsync(string toEmail, string subject, string body)
    {
        var smtpClient = new SmtpClient(_emailSettings.Host, _emailSettings.Port)
        {
            Credentials = new NetworkCredential(_emailSettings.UserName, _emailSettings.Password),
            EnableSsl = _emailSettings.EnableSsl,
            UseDefaultCredentials = false
        };

        var mailMessage = new MailMessage
        {
            From = new MailAddress(_emailSettings.FromEmail, _emailSettings.FromName),
            Subject = subject,
            Body = body,
            IsBodyHtml = false // Set to true if sending HTML email
        };

        mailMessage.To.Add(toEmail);

        await smtpClient.SendMailAsync(mailMessage);
    }
}