using ExpenseTracker.Application.Definitions;
using ExpenseTracker.Application.Dtos.Category;

namespace ExpenseTracker.Application.Operations.Categories.Commands;
public record UpdateCategory(int CategoryId, CategoryRequestDto Payload) : ICommand<CategoryResponseDto>;