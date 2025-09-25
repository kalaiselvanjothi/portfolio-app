using Portfolio.App.Models;

namespace Portfolio.App.ViewModels;

public class ContactViewModel : BaseViewModel
{
    public ContactViewModel(PersonalInformation personalInformation)
        : base(personalInformation)
    {
    }

    public ContactViewModel(PersonalInformation personalInformation,string message, string? senderName, bool isContactFormSubmitted)
        : base(personalInformation)
    {
        IsContactFormSubmitted = isContactFormSubmitted;
        SenderName = senderName;
        Message = message;
    }

    public string? SenderName { get; }

    public bool? IsContactFormSubmitted { get; }

    public string Message { get; } = string.Empty;
}
