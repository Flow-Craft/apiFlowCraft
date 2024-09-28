namespace ApiNet8.Services.IServices
{
    public interface IEmailService
    {
        void SendEmail(string receiverEmail, string receiverName, string subject, string message);
    }
}

