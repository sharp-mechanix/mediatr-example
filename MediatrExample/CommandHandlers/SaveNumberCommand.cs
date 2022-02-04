using System;
using MediatR;

namespace MediatrExample.CommandHandlers;

/// <summary>
///		Команда сохранения числа
/// </summary>
public record SaveNumberCommand : IRequest<int>
{
	/// <summary>
    ///		Число для сохранения
    /// </summary>
	public int Number { get; init; }
}
