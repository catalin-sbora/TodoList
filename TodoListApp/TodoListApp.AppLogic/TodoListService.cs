using TodoListApp.DataAccess.Abstractions;
using TodoListApp.DataAccess.Model;

namespace TodoListApp.AppLogic
{
    public class TodoListService
    {
        ITodoListRepository _dataRepository { get; set; }

        public TodoListService(ITodoListRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public async Task<IEnumerable<TodoList>> GetUserListsAsync(string userId, CancellationToken cancellationToken)
        {

            return await _dataRepository.GetByOwner(userId, cancellationToken);          
        }

    }
}
