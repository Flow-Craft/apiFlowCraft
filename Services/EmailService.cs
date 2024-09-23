using ApiNet8.Models;
using ApiNet8.Services.IServices;
using Microsoft.Extensions.Options;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using sib_api_v3_sdk.Api;
using sib_api_v3_sdk.Model;
using System.Diagnostics;

public class EmailService : IEmailService
{
    private readonly EmailSettings _emailSettings;

    public EmailService(IOptions<EmailSettings> emailSettings)
    {
        _emailSettings = emailSettings.Value;
    }

    public void SendEmail(string receiverEmail, string receiverName, string subject, string message)
    {

        var apiInstance = new TransactionalEmailsApi();

        // configuro quien envia el mail
        SendSmtpEmailSender sender = new SendSmtpEmailSender(_emailSettings.senderName, _emailSettings.senderEmail);

        // quien lo recibe
        SendSmtpEmailTo receiver1 = new SendSmtpEmailTo(receiverEmail, receiverName);

        // lista de recibidores
        List<SendSmtpEmailTo> To = new List<SendSmtpEmailTo>();
        To.Add(receiver1);

        string HtmlContent = null;
        string TextContent = message;
        long template = 1;

        JObject Params = new JObject
        {
            { "message", TextContent }
        };

        try
        {
            var sendSmtpEmail = new SendSmtpEmail(sender, To, null, null, HtmlContent, TextContent, subject, null, null, null, template, Params);
            CreateSmtpEmail result = apiInstance.SendTransacEmail(sendSmtpEmail);
            Console.WriteLine("Brevo response: " + result.ToJson());
        }
        catch (Exception e)
        {
            throw new Exception(e.Message, e);
        }

    }
}