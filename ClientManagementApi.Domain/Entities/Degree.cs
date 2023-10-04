using ClientManagementApi.Domain.Common;

namespace ClientManagementApi.Domain.Entities;

public class Degree : BaseEntity<int>
{
    public string? Name { get; set; }
    public string? University { get; set; }
    public DateOnly GraduationDate { get; set; }
    public string? Grade { get; set; }
    public DegreeType Type { get; set; }
}