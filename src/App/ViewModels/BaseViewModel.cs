using Portfolio.App.Models;

namespace Portfolio.App.ViewModels;

public class BaseViewModel
{
    public BaseViewModel(PersonalInformation personalInformation)
    {
        PersonalInformation = personalInformation;
    }

    public PersonalInformation PersonalInformation { get; }
}
