using System;

namespace MediatrExample.Requests;

/// <summary>
///		 Запрос сохранения числа
/// </summary>
public record SaveNumberRequest
{
	/// <summary>
    ///     Число для сохранения
    /// </summary>
	public int Number { get; set; }
}
