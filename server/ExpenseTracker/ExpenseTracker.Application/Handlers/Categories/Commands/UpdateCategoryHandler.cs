using ExpenseTracker.Application.Definitions;
using ExpenseTracker.Application.Dtos.Category;
using ExpenseTracker.Application.Exceptions;
using ExpenseTracker.Application.Operations.Categories.Commands;
using ExpenseTracker.Application.Persistence;

namespace ExpenseTracker.Application.Handlers.Categories.Commands;

public class UpdateCategoryHandler : ICommandHandler<UpdateCategory, CategoryResponseDto>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public UpdateCategoryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<CategoryResponseDto> HandleAsync(UpdateCategory command)
    {
        var category = await _unitOfWork.Categories.GetAsync(command.CategoryId);

        if (category == null)
            throw new ObjectNotFoundException($"Category with id {command.CategoryId} was not found in the system");

        category.UpdateName(command.Payload.Name);

        _unitOfWork.Categories.Update(category);

        await _unitOfWork.SaveChangesAsync();

        category = await _unitOfWork.Categories.GetAsync(command.CategoryId);

        return _mapper.Map<CategoryResponseDto>(category);
    }
}
