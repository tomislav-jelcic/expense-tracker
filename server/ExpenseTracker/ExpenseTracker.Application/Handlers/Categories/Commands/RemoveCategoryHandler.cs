using ExpenseTracker.Application.Definitions;
using ExpenseTracker.Application.Exceptions;
using ExpenseTracker.Application.Operations.Categories.Commands;
using ExpenseTracker.Application.Persistence;

namespace ExpenseTracker.Application.Handlers.Categories.Commands;

public class RemoveCategoryHandler : ICommandHandler<RemoveCategory>
{
    private IUnitOfWork _unitOfWork;

    public RemoveCategoryHandler(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task HandleAsync(RemoveCategory command)
    {
        var category = await _unitOfWork.Categories.GetAsync(command.Id);

        if (category == null)
            throw new ObjectNotFoundException($"Category with id {command.Id} was not found in the system");

        _unitOfWork.Categories.Delete(category);

        await _unitOfWork.SaveChangesAsync();
    }
}
