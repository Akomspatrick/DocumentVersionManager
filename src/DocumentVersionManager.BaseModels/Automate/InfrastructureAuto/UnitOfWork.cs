using LanguageExt;
using DocumentVersionManager.Domain.Errors;
using Microsoft.EntityFrameworkCore;
using DocumentVersionManager.Domain.Interfaces;

namespace DocumentVersionManager.Infrastructure.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public readonly DocumentVersionManagerContext _ctx;
        public UnitOfWork(DocumentVersionManagerContext ctx) { _ctx = ctx;  }

        public async Task<Either<GeneralFailure, int>> CommitAllChanges(CancellationToken cancellationToken)
        {
        // I am not even using this for now each repo has savechanges
        //but might be useful if i have something to centrally do before saving else i should remove it
            try
            {
                return await _ctx.SaveChangesAsync(cancellationToken);
            }
            catch (DbUpdateException ex)
            {
                return GeneralFailures.ProblemAddingEntityIntoDbContext("Problem Saving Data");
            }
            catch (Exception ex)
            {
                return GeneralFailures.ExceptionThrown("GenericRepository-AddAsync", "Problem Saving Data", ex?.InnerException?.Message);
            }
        }
        public void Dispose(){_ctx?.Dispose();  GC.SuppressFinalize(this); }
    }
}