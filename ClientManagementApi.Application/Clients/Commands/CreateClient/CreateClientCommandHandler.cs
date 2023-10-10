using ClientManagementApi.Application.Common;
using ClientManagementApi.Application.Common.Interfaces;
using ClientManagementApi.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApi.Application.Clients.Command.CreateClient
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, Guid>
    {

        private readonly IApplicationDbContext _context;
        public CreateClientCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Guid> Handle(CreateClientCommand request, CancellationToken cancellationToken = default)
        {
            var client = new Client
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber
            };

            _context.Client.Add(client);
            await _context.SaveChangesAsync(cancellationToken);

            return client.Id;
        }
    }
}
