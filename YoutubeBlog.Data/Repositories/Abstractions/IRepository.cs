using System.Linq.Expressions;
using YoutubeBlog.Core.Entities;

namespace YoutubeBlog.Data.Repositories.Abstractions
{
    public interface IRepository<T> where T : class, IEntityBase,new()
    {
        Task AddAsync(T entity);
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties); //Bir tane dönebileceğimiz bir T nesnesi içindir
        Task<T> GetByGuidAsync(Guid id);
        Task UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate  =null);
    }
}
