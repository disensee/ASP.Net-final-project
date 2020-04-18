using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareEFCore.Models
{
    public class EFComputerRepository : IComputerRepository
    {
        private HardwareDbContext context;

        public IEnumerable<Computer> Computers => context.Computers
            .Include(cpu => cpu.Cpus)
            .Include(r => r.Ram)
            .Include(d => d.Drives);

        public EFComputerRepository(HardwareDbContext context)
        {
            this.context = context;
        }

        public void SaveComputer(Computer computer)
        {
            Computer dbEntry = context.Computers.FirstOrDefault(c => c.ComputerId == computer.ComputerId);
            if(dbEntry != null)
            {
                dbEntry.ImagePath = computer.ImagePath;
            }

            context.SaveChanges();
        }
    }

}
