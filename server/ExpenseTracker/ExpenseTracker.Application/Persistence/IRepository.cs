using System.Linq.Expressions;

namespace ExpenseTracker.Application.Definitions.Persistence;

public interface IRepository<T> where T : class
{
    /// <summary>
    /// Retrieves an entity based on an id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task<T?> GetAsync(int id, CancellationToken ct = default);

    /// <summary>
    /// Retrieves all entities of a given type
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<T>> GetAllAsync(CancellationToken ct = default);

    /// <summary>
    /// Adds a new entry of a given entity
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    void Add(T entity);

    /// <summary>
    /// Removes a entity based on an id
    /// </summary>
    /// <param name="T"></param>
    /// <returns></returns>
    void Delete(T entity);

    /// <summary>
    /// Updates an entity
    /// </summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    void Update(T entity);

    /// <summary>
    /// Filters the given repository by a specified condition
    /// </summary>
    /// <param name="filter"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task<ICollection<T>> FilterAsync(Expression<Func<T, bool>> filter, CancellationToken ct);

    /// <summary>
    /// Filters the given repository by a specified condition
    /// </summary>
    /// <param name="filter"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task<T?> FilterSingleAsync(Expression<Func<T, bool>> filter, CancellationToken ct);

    /// <summary>
    /// Checks if an entity for a given condition exist in a repository
    /// </summary>
    /// <param name="filter"></param>
    /// <param name="ct"></param>
    /// <returns></returns>
    Task<bool> ExistsAsync(Expression<Func<T, bool>> filter, CancellationToken ct);
}
