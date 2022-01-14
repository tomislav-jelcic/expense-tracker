namespace ExpenseTracker.Application.Definitions;

/// <summary>
/// Defines a executing command returning a response
/// </summary>
/// <typeparam name="TResponse"></typeparam>
public interface ICommand<TResponse>
{
}

/// <summary>
/// Defines a executing command without returning a response
/// </summary>
public interface ICommand
{
}
