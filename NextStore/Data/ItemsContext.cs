using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NextStore.Models;

namespace NextStore.Data
{
    public class ItemsContext : DbContext
    {
        public ItemsContext (DbContextOptions<ItemsContext> options)
            : base(options)
        {
        }

        public DbSet<NextStore.Models.Items> Items { get; set; }
    }
}
