using ClientManagementApi.Application.Common;
using ClientManagementApi.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApi.Application.Clients.Command
{
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, Guid>
    {
        private readonly IApplicationUnitOfWork _uow;
        public CreateClientCommandHandler(IApplicationUnitOfWork applicationUnitOfWork)
            => _uow = applicationUnitOfWork;

        public async Task<Guid> Handle(CreateClientCommand request, CancellationToken cancellationToken = default)
        {
            var client = new Client
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email
            };
            _uow.Clients.Add(client);
            await _uow.SaveChangesAsync(cancellationToken);
            return client.Id;
        }
    }
}
