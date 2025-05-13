using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApp.DataAccess.Abstractions;
using TodoListApp.DataAccess.Model;

namespace TodoListApp.UnitTests.DummyImplementation
{
    internal class TodoListRepositoryFakeImplementation : ITodoListRepository
    {
        public Task<TodoList> Add(TodoList entity, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task DeleteById(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<TodoList> GetById(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TodoList>> GetByOwner(string ownerId, CancellationToken cancellationToken)
        {
            TodoList[] todoLists = [
                    new TodoList{
                        Owner = "2",
                        Id = 1,
                        Description = "Lista1",
                        Title = "Lista 1",                    
                       
                    }               
                ];
           return todoLists;
        }

        public Task SaveChanges(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
