using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareEFCore.Models
{
    public class Drive
    {
        public int DriveId { get; set; }

        [Required(ErrorMessage = "Please enter a manufacturer")]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "Please enter a model")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Please specify an interface")]
        public string Interface { get; set; }

        [Required(ErrorMessage = "Please specify a storage size")]
        public int SizeInGB { get; set; }

        [Required(ErrorMessage = "Please specify the transfer protocol")]
        public string TransferProtocol { get; set; }

        //Associations
        public int? ComputerId { get; set; }
        public Computer Computer { get; set; }
    }
}
