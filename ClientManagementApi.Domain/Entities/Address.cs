using ClientManagementApi.Domain.Common;

namespace ClientManagementApi.Domain.Entities;

[Entity]
public class Address : BaseEntity<int>
{
    public string? City { get; set; }
    public string? Street { get; set; }
    public string? Alley { get; set; }
    public string? DoorNumber { get; set; }
    public string? PostalCode { get; set; }
}