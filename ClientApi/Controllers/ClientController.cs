using ClientManagementApi.Application.Clients.Command.CreateClient;
using ClientManagementApi.Application.Clients.Queries.GetClinetForScoring;
using Microsoft.AspNetCore.Mvc;

namespace ClientApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : BaseController
{

    [HttpGet]

    public async Task<ActionResult<GetClinetForScoringDto>> GetClient([FromQuery] GetClientForScoringQuery query)
    => await Mediator.Send(query);

    

    [HttpPost]
    public async Task<ActionResult<Guid>> Create(CreateClientCommand command)
           => await Mediator.Send(command);


}