using ExpenseTracker.Application.Definitions;
using ExpenseTracker.Application.Dtos.Category;
using ExpenseTracker.Application.Operations.Categories.Commands;
using ExpenseTracker.Application.Persistence;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Application.Handlers.Categories.Commands;
public class AddCategoryHandler : ICommandHandler<AddCategory, CategoryResponseDto>
{
    private readonly IUnitOfWork _unitOfwork;
    private readonly IMapper _mapper;

    public AddCategoryHandler(IUnitOfWork unitOfwork, IMapper mapper)
    {
        _unitOfwork = unitOfwork;
        _mapper = mapper;
    }

    public async Task<CategoryResponseDto> HandleAsync(AddCategory command)
    {
        var categoryEntity = new Category(command.Payload.Name);

        _unitOfwork.Categories.Add(categoryEntity);

        await _unitOfwork.SaveChangesAsync();

        return _mapper.Map<CategoryResponseDto>(categoryEntity);
    }
}
