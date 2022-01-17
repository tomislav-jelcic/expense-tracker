using ExpenseTracker.Application.Definitions;
using ExpenseTracker.Application.Dtos;
using ExpenseTracker.Application.Exceptions;
using ExpenseTracker.Application.Persistence;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Application.Handlers.Users.Queries;

public class UserAccountDto
{
    public int Id { get; set; }
    public string OwnerId { get; set; } = default!;
    public string Name { get; set; } = default!;
    public AccountType Type { get; set; } = default!;
    public MoneyResponseDto Balance { get; set; } = default!;
}

public record GetAccounts(int OwnerId) : IQuery<IReadOnlyCollection<UserAccountDto>>;

public class GetAccountsHandler : IQueryHandler<GetAccounts, IReadOnlyCollection<UserAccountDto>>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public GetAccountsHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _mapper = mapper;
        _unitOfWork = unitOfWork;
    }

    public async Task<IReadOnlyCollection<UserAccountDto>> Handle(GetAccounts request, CancellationToken ct)
    {
        var userId = request.OwnerId;

        var userExists = await _unitOfWork.Users.ExistsAsync(x => x.Id == userId, ct);

        if (!userExists)
            throw new ObjectNotFoundException($"User with id {userId} was not found in the system");

        var userAccounts = await _unitOfWork.Accounts.FilterAsync(x => x.OwnerId == userId, ct);

        return _mapper.Map<IReadOnlyCollection<UserAccountDto>>(userAccounts);
    }
}
