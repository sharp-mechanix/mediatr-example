using System;
using MediatR;
using MediatrExample.Repositories;

namespace MediatrExample.QueryHandlers;

/// <summary>
///     Обработчик запроса числа
/// </summary>
public class GetNumberQueryHandler : IRequestHandler<GetNumberQuery, int>
{
    private readonly ILogger<GetNumberQueryHandler> _logger;

    private readonly IRepository<int> _repository;

    public GetNumberQueryHandler(ILogger<GetNumberQueryHandler> logger, IRepository<int> repository)
    {
        _logger = logger;
        _repository = repository;
    }

    /// <summary>
    ///     Обработка запроса
    /// </summary>
    public Task<int> Handle(GetNumberQuery request, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Triggered query handler");

        var value = _repository.Get();

        return Task.FromResult(value <= request.NotGreaterThan ? value : 0);
    }
}
