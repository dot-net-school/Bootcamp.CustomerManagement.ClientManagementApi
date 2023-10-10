using ClientManagementApi.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApi.Application.Clients.Queries.GetClinetForScoring
{
    public class GetClientForScoringHandler : IRequestHandler<GetClientForScoringQuery, GetClinetForScoringDto>
    {
        private readonly IApplicationDbContext _context;

        public GetClientForScoringHandler(IApplicationDbContext context)
        => _context = context;


        public async Task<GetClinetForScoringDto> Handle(GetClientForScoringQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.Client
                                       .Select(x => new GetClinetForScoringDto
                                       {
                                           Email = x.Email,
                                           Gender = x.Gender,
                                           Id = x.Id,
                                           Degrees = x.Degrees.ToList()
                                       })
                                       .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
            return result;
        }

        
    }
}
