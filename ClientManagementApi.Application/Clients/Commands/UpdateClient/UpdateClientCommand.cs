using ClientManagementApi.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManagementApi.Application.Clients.Commands.UpdateClient
{
    public class UpdateClientCommand : IRequest<string>
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public Gender Gender { get; set; }
        public string? NationalId { get; set; }
        public string? PassportId { get; set; }

        public Address? Address { get; set; }
        public ICollection<Degree>? Degrees { get; set; }
        public ICollection<Job>? Jobs { get; set; }
       
    }
}
