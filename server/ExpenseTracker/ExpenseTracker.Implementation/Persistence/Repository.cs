using ExpenseTracker.Domain.Entities;
using ExpenseTracker.Persistence;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ExpenseTracker.Application.Persistence;

public class Repository<T> : IRepository<T> where T : class, IEntity
{
    private readonly ExpenseTrackerContext _context;

    public Repository(ExpenseTrackerContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Retrieves an entity based on an id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<T?> GetAsync(int id, CancellationToken ct = default) => await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(x => x.Id == id, ct);

    /// <summary>
    /// Retrieves all entities of a given type
    /// </summary>
    /// <returns></returns>
    public async Task<IReadOnlyCollection<T>> GetAllAsync(CancellationToken ct = default) => await _context.Set<T>().AsNoTracking().ToListAsync();

    /// <summary>
    /// Adds a new entry of a given entity
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public void Add(T entity) => _context.Add(entity);

    /// <summary>
    /// Removes a entity based on an id
    /// </summary>
    /// <param name="T"></param>
    /// <returns></returns>
    public void Delete(T entity) => _context.Remove(entity);

    /// <summary>
    /// Updates an entity
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public void Update(T entity) => _context.Update(entity);

    /// <summary>
    /// Filters the given repository by a specified condition
    /// </summary>
    /// <param name="filter"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<IReadOnlyCollection<T>> FilterAsync(Expression<Func<T, bool>> filter, CancellationToken ct) => await _context.Set<T>().AsNoTracking().Where(filter).ToListAsync(ct);

    /// <summary>
    /// Filters the given repository by a specified condition
    /// </summary>
    /// <param name="filter"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<T?> FilterSingleAsync(Expression<Func<T, bool>> filter, CancellationToken ct) => await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(filter, ct);

    /// <summary>
    /// Checks if an entity for a given condition exist in a repository
    /// </summary>
    /// <param name="filter"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    public async Task<bool> ExistsAsync(Expression<Func<T, bool>> filter, CancellationToken ct) => await _context.Set<T>().AsNoTracking().AnyAsync(filter, ct);
}
