using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareEFCore.Models
{
    public interface IDriveRepository
    {
        IEnumerable<Drive> Drives { get; }

        void SaveDrive(Drive drive);

        Drive DeleteDrive(int driveId);
    }
}
