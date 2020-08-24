using System.Threading.Tasks;

namespace AnkurMadaan.Core.Interfaces
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string to, string from, string subject, string body);
    }
}
