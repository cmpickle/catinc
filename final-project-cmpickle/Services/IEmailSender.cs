using System.Threading.Tasks;

namespace final_project_cmpickle.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}