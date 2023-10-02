namespace Core;
public interface IEmailService
{
    public void SendEmail(string to, string body);
}
