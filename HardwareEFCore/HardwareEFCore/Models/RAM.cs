using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareEFCore.Models
{
    public class RAM
    {
        public int RamId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int SpeedInMhz { get; set; }

        //Associations
        public int ComputerId { get; set; }
        public Computer Computer { get; set; }
    }
}
