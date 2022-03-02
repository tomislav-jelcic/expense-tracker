using ExpenseTracker.Application.Definitions;
using ExpenseTracker.Application.Dtos.Category;

namespace ExpenseTracker.Application.Operations.Categories.Queries;
public record GetCategories : IQuery<IReadOnlyCollection<CategoryResponseDto>>;
