using GloboTicket.TicketManagement.Application.Models.Mail;

namespace GloboTicket.TicketManagement.Application.Contracts.Infrastructure;

public interface IEmailService
{
    public Task<bool> SendEmail(Email email);
}
