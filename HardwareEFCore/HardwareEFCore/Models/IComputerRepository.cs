using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareEFCore.Models
{
    public interface IComputerRepository
    {
        IEnumerable<Computer> Computers { get; }

        void SaveComputer(Computer computer);
    }
}
