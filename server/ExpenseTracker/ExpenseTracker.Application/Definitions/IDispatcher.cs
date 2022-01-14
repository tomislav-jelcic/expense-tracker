namespace ExpenseTracker.Application.Definitions;

public interface IDispatcher
{
    /// <summary>
    /// Dispatches a command async and returns a response
    /// </summary>
    /// <typeparam name="TCommand"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="command"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task<TResult> DispatchCommand<TCommand, TResult>(TCommand command, CancellationToken ct = default) where TCommand : ICommand<TResult>;

    /// <summary>
    /// Dispatchs a query and returns a response
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TResult"></typeparam>
    /// <param name="query"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task<TResult> DispatchQuery<TRequest, TResult>(TRequest query, CancellationToken ct = default) where TRequest : IQuery<TResult>;
}
