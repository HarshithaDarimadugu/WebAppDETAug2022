using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDoAPI11.Models;

namespace ToDoAPI11.Data
{
    public class ToDoAPI11Context : DbContext
    {
        public ToDoAPI11Context (DbContextOptions<ToDoAPI11Context> options)
            : base(options)
        {
        }

        public DbSet<ToDoAPI11.Models.ToDoItem> ToDoItem { get; set; } = default!;
    }
}
