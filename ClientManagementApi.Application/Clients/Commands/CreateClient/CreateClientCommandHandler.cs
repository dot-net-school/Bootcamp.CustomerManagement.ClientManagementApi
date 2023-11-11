using ClientManagementApi.Application.Common;
using ClientManagementApi.Application.Common.DTOs;
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
    public class CreateClientCommandHandler : IRequestHandler<CreateClientCommand, ApiResult>
    {

        private readonly IApplicationDbContext _context;
        public CreateClientCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<ApiResult> Handle(CreateClientCommand request, CancellationToken cancellationToken = default)
        {
            var client = new Client
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber
            };
            var apiResult = new ApiResult();
            try
            {
                _context.Set<Client>().Add(client);
                await _context.SaveChangesAsync(cancellationToken);
                apiResult.IsSuccess = true;
                apiResult.Data = client.Id;
            }
            catch (Exception e)
            {

                apiResult.IsSuccess = false;
                apiResult.ErrorMessage = e.Message;
            }
            return apiResult;
        }
    }
}
