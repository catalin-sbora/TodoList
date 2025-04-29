namespace TodoListApp.DataAccess.Model
{
    public class TodoList
    {
        int Id { get; set; }
        public string Title { get; set; } = "Empty List";
        public string? Description { get; set; }
        public string Owner { get; set; } = string.Empty;
        public List<TodoItem> Items { get; } = new List<TodoItem>();
 
    }
}
