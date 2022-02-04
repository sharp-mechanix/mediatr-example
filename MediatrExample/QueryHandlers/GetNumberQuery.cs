using System;
using MediatR;

namespace MediatrExample.QueryHandlers;

/// <summary>
///		Запрос получения числа
/// </summary>
public record GetNumberQuery : IRequest<int>
{
    public int NotGreaterThan { get; init; }
}
