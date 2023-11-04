using ClientManagementApi.Application.Common.DTOs;
using MediatR;


namespace ClientManagementApi.Application.Clients.Command.CreateClient
{
    public record CreateClientCommand : IRequest<ApiResult>
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? PhoneNumber { get; set; }

    }
}
