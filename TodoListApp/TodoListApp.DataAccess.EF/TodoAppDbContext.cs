using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace TodoListApp.DataAccess.EF
{
    public class TodoAppDbContext: DbContext
    {
        public TodoAppDbContext(DbContextOptions<TodoAppDbContext> options) : base(options)
        { 
        }

    }
}
