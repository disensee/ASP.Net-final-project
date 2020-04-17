using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HardwareEFCore.Models
{
    public class EFDriveRepository : IDriveRepository
    {
        private HardwareDbContext context;
        public IEnumerable<Drive> Drives => context.Drives;

        public EFDriveRepository(HardwareDbContext context)
        {
            this.context = context;
        }

       public void SaveDrive(Drive drive)
        {
            if(drive.DriveId == 0)
            {
                context.Drives.Add(drive);
            }
            else
            {
                Drive dbEntry = context.Drives.FirstOrDefault(d => d.DriveId == drive.DriveId);
                if(dbEntry != null)
                {
                    dbEntry.Manufacturer = drive.Manufacturer;
                    dbEntry.Model = drive.Model;
                    dbEntry.Interface = drive.Interface;
                    dbEntry.SizeInGB = drive.SizeInGB;
                    dbEntry.TransferProtocol = drive.TransferProtocol;
                }
            }

            context.SaveChanges();
        }

        public Drive DeleteDrive(int driveId)
        {
            Drive efDrive = context.Drives.FirstOrDefault(d => d.DriveId == driveId);
            if(efDrive != null)
            {
                context.Drives.Remove(efDrive);
                context.SaveChanges();
            }

            return efDrive;
        }
    }
}
