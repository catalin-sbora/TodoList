using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp.DataAccess.Abstractions
{
    public interface IDataContextInitializer
    {
        public Task Initialize(IServiceCollection serviceCollection, IConfiguration configuration);
    }
}
