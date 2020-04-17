using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareEFCore.Models
{
    public class CPU
    {
        public int CpuId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int CoreCount { get; set; }
        public int ThreadCount { get; set; }
        public decimal BaseClock { get; set; }
        public decimal BoostClock { get; set; }

        //Associations
        public int ComputerId { get; set; }
        public Computer Computer { get; set; }

    }
}
