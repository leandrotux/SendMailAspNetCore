using SendMailAspNetCore.models;
using System.Threading.Tasks;

namespace SendMailAspNetCore.Services
{
    public interface IMailService
    {
        Task SendEmailAsync(Mail mail);
    }
}