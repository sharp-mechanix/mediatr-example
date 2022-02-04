using System;
using MediatR;

namespace MediatrExample.QueryHandlers;

/// <summary>
///     Обработчик запроса числа
/// </summary>
public class GetNumberQueryHandler : IRequestHandler<GetNumberQuery, int>
{
    private readonly ILogger<GetNumberQueryHandler> _logger;

    private static int _increment = 420;

    public GetNumberQueryHandler(ILogger<GetNumberQueryHandler> logger)
    {
        _logger = logger;
    }

    /// <summary>
    ///     Обработка запроса
    /// </summary>
    public Task<int> Handle(GetNumberQuery request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Triggered query handler");

        return Task.FromResult(420 + request.Number);
    }
}
