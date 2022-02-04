using System;

namespace MediatrExample.Repositories;

/// <summary>
///		Интерфейс репозитория
/// </summary>
/// <typeparam name="T">Тип сущности</typeparam>
public interface IRepository<T>
{
	/// <summary>
    ///		Возвращает сущность
    /// </summary>
	T Get();

	/// <summary>
    ///     Сохраняет сущность
    /// </summary>
	T Save(T input);
}
