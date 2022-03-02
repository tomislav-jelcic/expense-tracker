using ExpenseTracker.Application.Definitions;
using ExpenseTracker.Application.Dtos.Category;
using ExpenseTracker.Application.Operations.Categories.Commands;

namespace ExpenseTracker.Application.Handlers.Categories.Commands;
public class AddCategoryHandler : ICommandHandler<AddCategory, CategoryResponseDto>
{
    public Task<CategoryResponseDto> HandleAsync(AddCategory command)
    {
        throw new NotImplementedException();
    }
}
