using AutoMapper;
using ExpenseTracker.Application.Handlers.Users.Commands;
using ExpenseTracker.Application.Handlers.Users.Queries;

namespace ExpenseTracker.Implementation.Mappings.Account;

public class AccountProfile : Profile
{
    public AccountProfile()
    {
        CreateMap<CreateUserAccountRequestDto, Domain.Entities.Account>();
        CreateMap<Domain.Entities.Account, CreateUserAccountResponseDto>();
        CreateMap<Domain.Entities.Account, UserAccountResponseDto>();
    }
}
