using ExpenseTracker.Application.Definitions;
using ExpenseTracker.Application.Dtos.Category;

namespace ExpenseTracker.Application.Operations.Categories.Commands;
public record AddCategory(CategoryRequestDto Payload) : ICommand<CategoryResponseDto>;
