using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareEFCore.Models.ViewModels
{
    public class ComputerListViewModel
    {
        public IEnumerable<Computer> Computers { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
