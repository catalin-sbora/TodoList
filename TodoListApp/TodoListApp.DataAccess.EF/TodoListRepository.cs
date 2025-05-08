using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApp.DataAccess.Abstractions;
using TodoListApp.DataAccess.Model;

namespace TodoListApp.DataAccess.EF
{
    public class TodoListRepository : BaseRepository<TodoList>, ITodoListRepository
    {
        
        public TodoListRepository(TodoAppDbContext dbContext) :base(dbContext)
        {
            
        }
        public async Task<IEnumerable<TodoList>> GetByOwner(string ownerId)
        {
            throw new NotImplementedException();
        }
    }
}
