#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EazyTodo.Models;

namespace EazyTodo.Data
{
    public class EazyTodoContext : DbContext
    {
        public EazyTodoContext (DbContextOptions<EazyTodoContext> options)
            : base(options)
        {
        }

        public DbSet<EazyTodo.Models.TodoItem> TodoItem { get; set; }
    }
}
