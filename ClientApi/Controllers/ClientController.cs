using ClientManagementApi.Application.Clients.Command;
using Microsoft.AspNetCore.Mvc;

namespace ClientApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : BaseController
{
    [HttpPost]
    public async Task<ActionResult<Guid>> Create(CreateClientCommand command)
           => await Mediator.Send(command);
}