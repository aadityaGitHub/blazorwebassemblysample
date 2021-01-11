namespace AtndTrackBlazorApp.Server.Services
{
    public interface IEmailService
    {
        void Send(string to, string subject, string html);
    }
}