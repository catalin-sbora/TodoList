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
                .HasData(new TodoList
                {
                    Id = 1,
                    Title = "First Todo List",
                    Description = "Sample todo list description",
                    Owner = "1"
                    
                });
            

            base.OnModelCreating(modelBuilder);
        }


    }
}
