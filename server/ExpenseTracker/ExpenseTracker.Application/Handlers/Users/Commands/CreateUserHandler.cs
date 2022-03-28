using ExpenseTracker.Application.Definitions;
using ExpenseTracker.Application.Dtos.User;
using ExpenseTracker.Application.Operations.Users.Commands;
using ExpenseTracker.Application.Persistence;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Application.Handlers.Users.Commands;
public class CreateUserHandler : ICommandHandler<CreateUser, UserResponseDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CreateUserHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<UserResponseDto> HandleAsync(CreateUser command, CancellationToken ct = default)
    {
        var user = await _unitOfWork.Users.FilterSingleAsync(x => x.LoginId == command.LoginId, ct);

        if (user != null)
            return _mapper.Map<UserResponseDto>(user);

        var userEntity = new User(command.FirstName, command.LastName, command.LoginId);

        _unitOfWork.Users.Add(userEntity);

        await _unitOfWork.SaveChangesAsync();

        var addedUser = await _unitOfWork.Users.FilterSingleAsync(x => x.LoginId == command.LoginId, ct);

        return _mapper.Map<UserResponseDto>(addedUser!);
    }
}
