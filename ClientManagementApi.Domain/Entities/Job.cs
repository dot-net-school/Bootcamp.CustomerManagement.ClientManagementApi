using ClientManagementApi.Domain.Common;

namespace ClientManagementApi.Domain.Entities;

public class Job : BaseEntity
{
    public string CompanyName { get; set; }
    public string Position { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}