using AutoMapper;
using ExpenseTracker.Application.Dtos.Category;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Implementation.Mappings.Categories;
public class CategoryProfile : Profile
{
    public CategoryProfile()
    {
        CreateMap<Category, CategoryResponseDto>();
    }
}
