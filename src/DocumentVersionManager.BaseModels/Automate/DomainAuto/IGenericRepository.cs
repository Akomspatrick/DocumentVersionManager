using LanguageExt;
using DocumentVersionManager.DomainBase;
using DocumentVersionManager.Domain.Errors;
namespace DocumentVersionManager.Domain.Interfaces
{

    public interface IGenericRepository<T> where T : BaseEntity

    {
        Task<Result<GeneralFailure, int>> AddAsync(T entity, CancellationToken cancellationToken);
        Task<Result<GeneralFailure, int>> UpdateAsync(T entity, CancellationToken cancellationToken);
        Task<Result<GeneralFailure, int>> DeleteAsync(T entity, CancellationToken cancellationToken);
        Task<Result<GeneralFailure, List<T>>> GetAllAsync(System.Linq.Expressions.Expression<Func<T, bool>> expression= null,List<string> includes = null,Func<IQueryable<T>,IOrderedQueryable<T>> orderBy= null,CancellationToken cancellationToken =default);
        Task<Result<GeneralFailure, T>> GetMatch(System.Linq.Expressions.Expression<Func<T, bool>> expression,List<string> includes= null , CancellationToken cancellationToken= default);
        Task<Result<GeneralFailure, T>> GetByGuidAsync(Guid guid, CancellationToken cancellationToken=default);
    }
}