using ExpenseTracker.Application.Definitions;
using MediatR;

namespace ExpenseTracker.Implementation.Definitions;

public class MediatrQueryWrapper<TResponse> : IRequest<TResponse>
{
    private readonly IQuery<TResponse> _command;
    public MediatrQueryWrapper(IQuery<TResponse> command)
    {
        _command = command;
    }
}