using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareEFCore.Models.ViewModels
{
    public class DriveListViewModel
    {
        public IEnumerable<Drive> Drives { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentInterface { get; set; }
    }
}
