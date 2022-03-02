namespace ExpenseTracker.Application.Definitions;

/// <summary>
/// Defines a handler that executes a command 
/// </summary>
/// <typeparam name="TCommand"></typeparam>
/// <typeparam name="TResult"></typeparam>
public interface ICommandHandler<TCommand, TResult> where TCommand : ICommand<TResult>
{
    Task<TResult> HandleAsync(TCommand command);
}
