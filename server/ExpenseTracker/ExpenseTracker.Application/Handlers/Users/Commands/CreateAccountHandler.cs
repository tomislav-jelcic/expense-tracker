using ExpenseTracker.Application.Definitions;
using ExpenseTracker.Application.Dtos.Account;
using ExpenseTracker.Application.Exceptions;
using ExpenseTracker.Application.Operations.Users.Commands;
using ExpenseTracker.Application.Persistence;
using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Domain.ValueObjects;

namespace ExpenseTracker.Application.Handlers.Users.Commands;

public class CreateAccountHandler : ICommandHandler<CreateAccount, AccountResponseDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateAccountHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<AccountResponseDto> HandleAsync(CreateAccount request, CancellationToken ct = default)
    {
        var balance = _mapper.Map<Money>(request.Payload.Balance);
        var owner = await _unitOfWork.Users.GetAsync(request.OwnerId, ct);

        if (owner == null)
            throw new BadArgumentException("Specified user, for which the account is being made, has not been found");

        var account = new Account(owner, request.Payload.Name, request.Payload.Type!, balance);

        _unitOfWork.Accounts.Add(account);

        await _unitOfWork.SaveChangesAsync();

        var newAccount = await _unitOfWork.Accounts.GetAsync(account.Id, ct);

        return _mapper.Map<AccountResponseDto>(newAccount!);
    }
}
