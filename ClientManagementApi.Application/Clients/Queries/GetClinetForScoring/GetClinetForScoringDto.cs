using ClientManagementApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApi.Application.Clients.Queries.GetClinetForScoring
{
    public class GetClinetForScoringDto
    {
        public Guid Id { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }

        public IEnumerable<Degree>? Degrees { get; set; } 
    }
}
