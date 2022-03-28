using ExpenseTracker.Application.Definitions;
using MediatR;

namespace ExpenseTracker.Implementation.Definitions;

internal class MediatrCommandWrapper<TResponse> : IRequest<TResponse>
{
#pragma warning disable IDE0052 // Remove unread private members
    private readonly ICommand<TResponse> _command;
#pragma warning restore IDE0052 // Remove unread private members
    public MediatrCommandWrapper(ICommand<TResponse> command)
    {
        _command = command;
    }
}
