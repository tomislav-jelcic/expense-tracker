using ExpenseTracker.Application.Definitions;

namespace ExpenseTracker.Application.Operations.Categories.Commands;
public record RemoveCategory(int Id) : ICommand;
