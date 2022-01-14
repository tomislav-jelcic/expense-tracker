namespace ExpenseTracker.Application.Definitions;

/// <summary>
/// Definition of a handler that servers a query definition
/// </summary>
/// <typeparam name="TQuery"></typeparam>
/// <typeparam name="TResult"></typeparam>
public interface IQueryHandler<in TQuery, TResult>
{
    /// <summary>
    /// Handles a query instance
    /// </summary>
    /// <param name="request"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task<TResult> Handle(TQuery request, CancellationToken ct);
}
