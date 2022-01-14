using ExpenseTracker.Application.Definitions;
using ExpenseTracker.Application.Dtos;
using ExpenseTracker.Application.Exceptions;
using ExpenseTracker.Application.Persistence;
using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.ValueObjects;

namespace ExpenseTracker.Application.Handlers.Users;

public class CreateUserAccountRequestDto
{
    public string Name { get; set; } = default!;
    public AccountType Type { get; set; }
    public MoneyRequestDto Balance { get; set; } = default!;
}
public class CreateUserAccountResponseDto
{
    public int Id { get; set; }
    public string OwnerId { get; set; } = default!;
    public string Name { get; set; } = default!;
    public AccountType Type { get; set; } = default!;
    public MoneyResponseDto Balance { get; set; } = default!;
}
public record CreateAccount(int OwnerId, CreateUserAccountRequestDto Payload) : ICommand<CreateUserAccountResponseDto>;

public class CreateAccountHandler : ICommandHandler<CreateAccount, CreateUserAccountResponseDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateAccountHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CreateUserAccountResponseDto> Handle(CreateAccount request, CancellationToken cancellationToken)
    {

        var balance = _mapper.Map<Money>(request.Payload.Balance);
        var owner = await _unitOfWork.Users.GetAsync(request.OwnerId, cancellationToken);

        if (owner == null)
            throw new BadArgumentException("Specified user, for which the account is being made, has not been found");

        var account = new Account(owner, request.Payload.Name, request.Payload.Type!, balance);

        _unitOfWork.Accounts.Add(account);

        await _unitOfWork.SaveChangesAsync(cancellationToken);

        var newAccount = await _unitOfWork.Accounts.GetAsync(account.Id, cancellationToken);

        return _mapper.Map<CreateUserAccountResponseDto>(newAccount!);
    }
}
