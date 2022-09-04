using System.ComponentModel.DataAnnotations;

public class InformationModel
{
    public string AccountId { get; set; } = "accountId";
    public string ClinicName { get; set; } = "The Clinic";
    public string ClinicAddress { get; set; } = "111 State St.";
    public string Country { get; set; } = "USA";
    public string? Region { get; set; } = "Southwest";
}