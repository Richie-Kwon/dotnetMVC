using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoList.Models;

    public class ItemsContext : DbContext
    {
        public ItemsContext (DbContextOptions<ItemsContext> options)
            : base(options)
        {
        }

        public DbSet<TodoList.Models.Item> Item { get; set; }
    }
