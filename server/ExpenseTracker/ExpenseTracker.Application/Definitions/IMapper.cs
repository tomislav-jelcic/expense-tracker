namespace ExpenseTracker.Application.Definitions;

public interface IMapper
{
    /// <summary>
    /// Defines a method needed to map two objects
    /// </summary>
    /// <typeparam name="TFrom"></typeparam>
    /// <param name="object"></param>
    /// <returns></returns>
    TTo Map<TTo>(object @object);
}
