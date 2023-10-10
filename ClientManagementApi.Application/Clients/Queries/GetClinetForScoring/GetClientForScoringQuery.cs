using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApi.Application.Clients.Queries.GetClinetForScoring
{
    public class GetClientForScoringQuery :IRequest<GetClinetForScoringDto>
    {
        public Guid Id { get; set; }
    }
}
