using Hangfire;
using System;
using System.Threading.Tasks;

namespace Diploma1.Infrastructure.Jobs
{
    public class NotificationJobs
    {
        public async Task SendAttestationReminderAsync(Guid employeeId)
        {
            // TODO: Реализовать отправку email-напоминания
            await Task.CompletedTask;
        }
    }
}