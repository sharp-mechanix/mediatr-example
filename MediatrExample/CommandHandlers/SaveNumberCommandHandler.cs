using System;
using MediatR;
using MediatrExample.Repositories;

namespace MediatrExample.CommandHandlers;

/// <summary>
///		Обработчик команды сохранения числа
/// </summary>
public class SaveNumberCommandHandler : IRequestHandler<SaveNumberCommand, int>
{
	private readonly ILogger<SaveNumberCommandHandler> _logger;

	private readonly IRepository<int> _repository;

	/// <inheritdoc cref="SaveNumberCommandHandler"/>
	public SaveNumberCommandHandler(ILogger<SaveNumberCommandHandler> logger, IRepository<int> repository)
	{
		_logger = logger;
		_repository = repository;
	}

	/// <summary>
    ///     Обработка запроса
    /// </summary>
    public Task<int> Handle(SaveNumberCommand request, CancellationToken cancellationToken)
    {
		_logger.LogInformation("Triggered command handler");

		return Task.FromResult(_repository.Save(request.Number));
    }
}
