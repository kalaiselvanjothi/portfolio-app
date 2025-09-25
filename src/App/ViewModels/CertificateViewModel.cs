using Portfolio.App.Models;

namespace Portfolio.App.ViewModels;

public class CertificateViewModel : BaseViewModel
{
    public CertificateViewModel(PersonalInformation personalInformation, List<Certificate> certificates)
        : base(personalInformation)
    {
        Certificates = certificates;
    }

    public List<Certificate> Certificates { get; }
}