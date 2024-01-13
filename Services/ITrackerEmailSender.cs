using Microsoft.AspNetCore.Identity.UI.Services;

namespace BugTracker.Services
{
    public interface ITrackerEmailSender : IEmailSender
    {
        Task sendContactEmailAsync(string emailFrom, string name, string subject, string htmlMessage);
    }
}
