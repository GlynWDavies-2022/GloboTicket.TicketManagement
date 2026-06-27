using System.ComponentModel.DataAnnotations;

namespace GloboTicket.TicketManagement.Application.Exceptions;

public class ValidationException : Exception
{
    public List<string> ValidationErrors { get; set; }

    public ValidationException(ValidationResult validationResult)
    {
        ValidationErrors = new List<string>();

        foreach (var validationError in validationResult.MemberNames)
        {
            ValidationErrors.Add(validationError);
        }
    }
}
