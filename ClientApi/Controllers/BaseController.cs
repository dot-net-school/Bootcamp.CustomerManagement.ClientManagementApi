﻿
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ClientApi.Controllers;

[Route("[controller]/[action]"), ApiController]
public abstract class BaseController : ControllerBase
{
    private ISender? _mediator;

    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}
