using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareEFCore.Models
{
    public class HardwareDbContext : DbContext
    {
        public HardwareDbContext(DbContextOptions<HardwareDbContext> options) : base(options)
        {

        }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<CPU> Cpus { get; set; }
        public DbSet<Drive> Drives { get; set; }
        public DbSet<RAM> Ram { get; set; }
        public DbSet<BuildOrder> BuildOrders { get; set; }
    }
}
