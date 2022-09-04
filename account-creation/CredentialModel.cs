using System.ComponentModel.DataAnnotations;

public class CredentialModel
{
    public string? aa;
    public string AccountId { get; set; }
    public string ClinicId { get; set; }
    public string Email { get; set; } = "john.bohnam@gmail.com";
    public string Password { get; set; } = "hi-hat1";
    public string? ConfirmPassword { get; set; } = "hi-hat1";
    public string SecurityQuestion { get; set; } = "best band of all times";
    public string SecurityAnswer { get; set; } = "led zeppelin";
    public string Consent { get; set; } = "true";
    public string? ParentConfirmation { get; set; }
    public string? HealthDataConfirmation { get; set; }
    public string? TermsOfService { get; set; }
}