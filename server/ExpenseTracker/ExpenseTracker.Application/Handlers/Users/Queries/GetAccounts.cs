using ExpenseTracker.Application.Definitions;
using ExpenseTracker.Application.Dtos.Account;
using ExpenseTracker.Application.Exceptions;
using ExpenseTracker.Application.Persistence;

namespace ExpenseTracker.Application.Handlers.Users.Queries;

public class GetAccountsHandler : IQueryHandler<GetAccounts, IReadOnlyCollection<AccountResponseDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAccountsHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<IReadOnlyCollection<AccountResponseDto>> Handle(GetAccounts request, CancellationToken ct)
    {
        var userId = request.OwnerId;

        var userExists = await _unitOfWork.Users.ExistsAsync(x => x.Id == userId, ct);

        if (!userExists)
            throw new ObjectNotFoundException($"User with id {userId} was not found in the system");

        var userAccounts = await _unitOfWork.Accounts.FilterAsync(x => x.OwnerId == userId, ct);

        return _mapper.Map<IReadOnlyCollection<AccountResponseDto>>(userAccounts);
    }
}
