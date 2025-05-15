using TodoListApp.DataAccess.Model;

namespace TodoListApp.DataAccess.Abstractions
{
    public interface IAsyncRepository <T> where T : BaseEntity
    {
        public Task<T> GetById (int id, CancellationToken cancellationToken);
        public Task<T> Add (T entity, CancellationToken cancellationToken);
        public Task SaveChanges (CancellationToken cancellationToken);
        public Task DeleteById (int id, CancellationToken cancellationToken);

    }
}
