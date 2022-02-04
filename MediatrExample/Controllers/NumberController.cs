using MediatR;
using MediatrExample.QueryHandlers;
using Microsoft.AspNetCore.Mvc;

namespace MediatrExample.Controllers;

/// <summary>
///     Контроллер чисел
/// </summary>
[ApiController]
[Route("api/number")]
public class NumberController : ControllerBase
{
    private readonly ILogger<NumberController> _logger;

    private readonly IMediator _mediator;

    public NumberController(ILogger<NumberController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    /// <summary>
    ///     Возвращает сумму числа из запроса и константы
    /// </summary>
    [HttpGet]
    public Task<int> GetIncrementedNumber([FromQuery] int input)
    {
        _logger.LogInformation("Entering GET /api/number");

        return _mediator.Send(new GetNumberQuery { Number = input });
    }
}
