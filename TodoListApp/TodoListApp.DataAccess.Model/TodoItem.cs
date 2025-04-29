using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListApp.DataAccess.Model
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Empty Item";
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public DateTime DueDate { get; set; }

    }
}
