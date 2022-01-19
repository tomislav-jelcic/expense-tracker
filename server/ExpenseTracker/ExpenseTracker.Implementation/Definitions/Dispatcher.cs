using ExpenseTracker.Application.Definitions;
using MediatR;

namespace ExpenseTracker.Implementation.Definitions;

public class Dispatcher : IDispatcher
{
    private readonly IMediator _mediatr;

    public Dispatcher(IMediator mediadtr)
    {
        _mediatr = mediadtr;
    }
    public Task<TResult> DispatchCommand<TCommand, TResult>(TCommand command, CancellationToken ct = default) where TCommand : ICommand<TResult>
    {
        return _mediatr.Send(new MediatrCommandWrapper<TResult>(command), ct);
    }

    public Task<TResult> DispatchQuery<TRequest, TResult>(TRequest query, CancellationToken ct = default) where TRequest : IQuery<TResult>
    {
        return _mediatr.Send(new MediatrQueryWrapper<TResult>(query), ct);
    }
}
