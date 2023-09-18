using ClientManagementApi.Domain.Common;

namespace ClientManagementApi.Domain.Entities;

public class Client : BaseEntity
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public Address? Address { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public MaritalStatus MaritalStatus { get; set; }
    public Gender Gender { get; set; }
    public List<Degree>? Degrees { get; set; }
    public List<Job>? Jobs { get; set; }
    public string? NationalId { get; set; }
    public string? PassportId { get; set; }
}