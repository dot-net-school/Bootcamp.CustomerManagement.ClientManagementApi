using ClientManagementApi.Application.Clients.Command.CreateClient;
using ClientManagementApi.Application.Common.Interfaces;
using ClientManagementApi.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApi.Application.Clients.Commands.UpdateClient
{
    public class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommand, string>
    {
        private readonly IApplicationDbContext _context;
        public UpdateClientCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<string> Handle(UpdateClientCommand request, CancellationToken cancellationToken = default)
        {
            var result = await _context.Client.FindAsync(new object[] { request.Id }, cancellationToken);
            if (result != null)
            {
                result.FirstName = request.FirstName;
                result.LastName = request.LastName;
                result.Email = request.Email;
                result.PhoneNumber = request.PhoneNumber;
                result.DateOfBirth = request.DateOfBirth;
                result.MaritalStatus = request.MaritalStatus;
                result.Gender = request.Gender;
                result.NationalId = request.NationalId;
                result.PassportId = request.PassportId;
                result.Address = request.Address;
                result.Degrees = request.Degrees;
                result.Jobs = request.Jobs;

                await _context.SaveChangesAsync(cancellationToken);

                return "Successfully Updated Client.";
            }

            else
                return "Client Not Found!";

            
        }
    }
}
