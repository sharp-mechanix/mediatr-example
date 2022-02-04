using System;

namespace MediatrExample.Repositories;

/// <summary>
///		Репозиторий чисел
/// </summary>
public class NumberRepository : IRepository<int>
{
	private int _entity = 0;

    /// <inheritdoc />
    public int Get()
    {
        return _entity;
    }

    /// <inheritdoc />
    public int Save(int input)
    {
        _entity = input;

        return _entity;
    }
}
