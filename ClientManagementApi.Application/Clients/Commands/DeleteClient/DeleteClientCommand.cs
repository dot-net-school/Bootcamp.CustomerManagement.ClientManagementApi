using MediatR;

namespace ClientManagementApi.Application.Clients.Commands.DeleteClient;

public class DeleteClientCommand : IRequest<bool>
{
    public Guid Id { get; set; }
}