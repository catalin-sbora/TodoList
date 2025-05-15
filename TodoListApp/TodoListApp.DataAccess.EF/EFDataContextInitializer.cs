using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoListApp.DataAccess.Abstractions;

namespace TodoListApp.DataAccess.EF
{
    public class EFDataContextInitializer : IDataContextInitializer
    {
        public async Task Initialize(IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            serviceCollection.AddDbContext<TodoAppDbContext>(options =>
                options.UseSqlServer(connectionString));

            using (var scope = serviceCollection.BuildServiceProvider().CreateScope())
            { 
                var dbContext = scope.ServiceProvider
                                     .GetRequiredService<TodoAppDbContext>();

                await dbContext.Database.EnsureCreatedAsync();
            }
            serviceCollection.AddScoped<ITodoListRepository,  TodoListRepository>();    
        }
    }
}
