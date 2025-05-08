using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApp.DataAccess.Model;

namespace TodoListApp.DataAccess.Abstractions
{
    public interface ITodoListRepository:IAsyncRepository<TodoList>
    {
        Task<IEnumerable<TodoList>> GetByOwner(string ownerId);
    }
}
