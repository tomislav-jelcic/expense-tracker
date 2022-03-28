using AutoMapper;
using ExpenseTracker.Application.Dtos.User;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Implementation.Mappings.Users;
public class UserProfile : Profile {
    public UserProfile()
    {
        CreateMap<UserRequestDto, User>();
        CreateMap<User, UserResponseDto>();
    }
}
