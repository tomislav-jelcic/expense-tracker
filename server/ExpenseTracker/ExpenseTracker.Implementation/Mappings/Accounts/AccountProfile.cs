using AutoMapper;
using ExpenseTracker.Application.Dtos.Account;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Implementation.Mappings.Accounts;

public class AccountProfile : Profile
{
    public AccountProfile()
    {
        CreateMap<AccountRequestDto, Account>();
        CreateMap<Account, AccountResponseDto>();
    }
}
