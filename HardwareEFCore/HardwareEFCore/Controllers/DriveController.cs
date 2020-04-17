using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HardwareEFCore.Models;
using HardwareEFCore.Models.ViewModels;


namespace HardwareEFCore.Controllers
{
    public class DriveController : Controller
    {
        private IDriveRepository driveRepo;
        private int pageSize = 5;
        public DriveController(IDriveRepository driveRepo)
        {
            this.driveRepo = driveRepo;
        }

        public IActionResult List(string driveInterface, int pageId = 1)
        {
            DriveListViewModel vModel = new DriveListViewModel();

            IEnumerable<Drive> drives = driveRepo.Drives
                .Where(d=>driveInterface == null || d.Interface == driveInterface)
                .OrderBy(d => d.DriveId)
                .Skip((pageId - 1) * pageSize)
                .Take(pageSize);

            vModel.Drives = drives;
            PagingInfo pInfo = new PagingInfo()
            {
                CurrentPage = pageId,
                ItemsPerPage = pageSize,
                TotalItems = driveInterface == null ?
                    driveRepo.Drives.Count() :
                    driveRepo.Drives
                    .Where(e => e.Interface == driveInterface).Count()
            };

            vModel.CurrentInterface = driveInterface;
            vModel.PagingInfo = pInfo;
            return View(vModel);
        }

    }
}