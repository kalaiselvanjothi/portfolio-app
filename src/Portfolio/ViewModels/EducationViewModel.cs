using Portfolio.App.Models;

namespace Portfolio.App.ViewModels;

public class EducationViewModel : BaseViewModel 
{
    public EducationViewModel(PersonalInformation personalInformation, List<Education> educations)
        : base(personalInformation)
    {
        Educations = educations;
    }
    
    public List<Education> Educations { get; }
}