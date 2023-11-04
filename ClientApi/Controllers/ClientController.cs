using ClientManagementApi.Application.Clients.Command.CreateClient;
using ClientManagementApi.Application.Clients.Commands.DeleteClient;
using ClientManagementApi.Application.Clients.Commands.UpdateClient;
using ClientManagementApi.Application.Clients.Queries.GetClinetForScoring;
using ClientManagementApi.Application.Common.DTOs;
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
    public async Task<ActionResult<ApiResult>> Create(CreateClientCommand command)
           => await Mediator.Send(command);

    [HttpPut]
    public async Task<ActionResult<string>> Update(UpdateClientCommand command)
           => await Mediator.Send(command);
    
    [HttpDelete]
    public async Task<ActionResult<bool>> Delete(DeleteClientCommand command)
           => await Mediator.Send(command);
}