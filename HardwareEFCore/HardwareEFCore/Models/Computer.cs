using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareEFCore.Models
{
    public class Computer
    {
        public int ComputerId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Nickname { get; set; }
        public string ImagePath { get; set; }

        //Associations
        public List<CPU> Cpus { get; set; }
        public List<Drive> Drives { get; set; }
        public List<RAM> Ram { get; set; }
    }
}
