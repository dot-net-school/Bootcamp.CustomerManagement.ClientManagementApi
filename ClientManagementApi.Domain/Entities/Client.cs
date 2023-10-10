using ClientManagementApi.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace ClientManagementApi.Domain.Entities;

public class Client : BaseEntity<Guid>
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public MaritalStatus MaritalStatus { get; set; }
    public Gender Gender { get; set; }
    public string? NationalId { get; set; }
    public string? PassportId { get; set; }


    public DateTime CreatedAt { get; set; } = DateTime.Now;


    public Address? Address { get; set; }
    public ICollection<Degree>? Degrees { get; set; }
    public ICollection<Job>? Jobs { get; set; }
}