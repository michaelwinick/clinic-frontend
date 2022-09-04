using System.ComponentModel.DataAnnotations;

public class CredentialModel
{
    public string AccountId { get; set; } = "AccountId1";
    public string Email { get; set; } = "adm.dymitruk@gamil.com";
    public string Password { get; set; } = "good passoword";
    public string SecurityQuestion { get; set; } = "favorite modeling technique";
    public string SecurityAnswer { get; set; } = "Event Modeling";
    public string HealthDataNotice { get; set; } = "true";
    public string TermsOfUse { get; set; } = "true";
}