namespace Portfolio.App.Models;

public class Certificate
{
    public string Title { get; set; } = string.Empty;

    public string Issuer { get; set; } = string.Empty;

    public DateTime IssuedDate { get; set; }

    public string CertificateUrl { get; set; } = string.Empty;
}