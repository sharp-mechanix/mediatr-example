using System;

namespace MediatrExample.Requests;

/// <summary>
///		Запрос на получение числа
/// </summary>
public record GetNumberRequest
{
	/// <summary>
    ///     Фильтр "не меньше"
    /// </summary>
    public int NotGreaterThan { get; init; }
}
