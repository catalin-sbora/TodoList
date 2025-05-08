using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using TodoListApp.DataAccess.Model;

namespace TodoListApp.DataAccess.EF
{
    public class TodoAppDbContext: DbContext
    {
        public DbSet<TodoList> TodoLists { get; set; }
        public TodoAppDbContext(DbContextOptions<TodoAppDbContext> options) : base(options)
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoList>()
                        .HasKey(x => x.Id);

            modelBuilder.Entity<TodoList>()
                        .HasMany<TodoItem>();

            base.OnModelCreating(modelBuilder);
        }


    }
}
