using ClientManagementApi.Application.Common.Interfaces;
using MediatR;

namespace ClientManagementApi.Application.Clients.Commands.DeleteClient;

public class DeleteClientCommandHandler : IRequestHandler<DeleteClientCommand, bool>
{
    private readonly IApplicationDbContext _context;
    public DeleteClientCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> Handle(DeleteClientCommand request, CancellationToken cancellationToken)
    {
        var result = await _context.Client.FindAsync(new object[] { request.Id }, cancellationToken);
        if (result == null) return false;
        _context.Client.Remove(result);
        await _context.SaveChangesAsync(cancellationToken);
        return true;
    }
}