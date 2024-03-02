using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace OrderSystem.Data
{
    public class OrderSystemContext : DbContext
    {
        public OrderSystemContext (DbContextOptions<OrderSystemContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Model.Order> Order { get; set; } = default!;
    }
}
