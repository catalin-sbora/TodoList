using Microsoft.EntityFrameworkCore;
using TodoListApp.DataAccess.Abstractions;
using TodoListApp.DataAccess.Model;

namespace TodoListApp.DataAccess.EF
{
    public class BaseRepository<T> : IAsyncRepository<T> where T : BaseEntity
    {
        protected readonly TodoAppDbContext dbContext;

        public BaseRepository(TodoAppDbContext dbContext) 
        {
            this.dbContext = dbContext;
        }

        public async Task<T> Add(T entity, CancellationToken cancellationToken)
        {
            var returnEntity =  dbContext.Set<T>().Add(entity);
            await dbContext.SaveChangesAsync();
            return returnEntity.Entity;
        }

        public async Task DeleteById(int id, CancellationToken cancellationToken)
        {
            var entityToRemove = await dbContext.Set<T>()
                                .FirstAsync(x => x.Id == id);            
            dbContext.Set<T>().Remove(entityToRemove);
            await dbContext.SaveChangesAsync();
            
        }

        public async Task<T> GetById(int id, CancellationToken cancellationToken)
        {
           return await dbContext.Set<T>()
                            .FirstAsync(x => x.Id == id);   
        }

        public async Task SaveChanges(CancellationToken cancellationToken)
        {
           await dbContext.SaveChangesAsync();
        }
    }
}
