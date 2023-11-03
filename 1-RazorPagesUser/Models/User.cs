using System.ComponentModel.DataAnnotations;

namespace RazorPagesUsers.Models;

public class User
{
    public int UserId { get; set; }
    public string UserName { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? EmailAddress { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    [DataType(DataType.Date)]
    public DateTime CreationDate { get; set; }
}