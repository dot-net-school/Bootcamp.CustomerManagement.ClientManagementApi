using ClientManagementApi.Domain.Common;

namespace ClientManagementApi.Domain.Entities;
[Entity]
public class Job : BaseEntity<int>
{
    public string CompanyName { get; set; }
    public string Position { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}