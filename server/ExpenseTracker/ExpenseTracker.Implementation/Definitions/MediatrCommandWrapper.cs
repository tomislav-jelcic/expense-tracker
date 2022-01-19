using ExpenseTracker.Application.Definitions;
using MediatR;

namespace ExpenseTracker.Implementation.Definitions;

internal class MediatrCommandWrapper<TResponse> : IRequest<TResponse>
{
    private readonly ICommand<TResponse> _command;
    public MediatrCommandWrapper(ICommand<TResponse> command)
    {
        _command = command;
    }
}
