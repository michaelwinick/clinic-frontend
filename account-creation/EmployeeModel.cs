using System.ComponentModel.DataAnnotations;

public class EmployeeModel
{
    public string ClinicId { get; set; }
    public string FirstName { get; set; } = "John";
    public string LastName { get; set; } = "Bonham";
    public string Title { get; set; } = "the drummer";
    public string Email { get; set; } = "john.bonham";
}