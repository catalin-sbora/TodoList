using TodoListApp.DataAccess.Model;

namespace TodoListApp.UI.Models
{
    public class TodoListHomeViewModel
    {
        public IEnumerable<TodoList>? TodoLists { get; set; }
    }
}
