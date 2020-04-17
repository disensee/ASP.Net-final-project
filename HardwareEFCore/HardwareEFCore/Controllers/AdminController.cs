using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HardwareEFCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace HardwareEFCore.Controllers
{
    public class AdminController : Controller
    {
        private IDriveRepository repository;

        public AdminController(IDriveRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index() => View(repository.Drives);

        public ViewResult Edit(int driveId) => View(repository.Drives.FirstOrDefault(d => d.DriveId == driveId));

        [HttpPost]
        public IActionResult Edit(Drive drive)
        {
            if (ModelState.IsValid)
            {
                repository.SaveDrive(drive);
                TempData["message"] = $"{drive.Manufacturer} {drive.Model} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                return View(drive);
            }
        }

        public ActionResult Create() => View("Edit", new Drive());

        [HttpPost]
        public IActionResult Delete(int driveId)
        {
            Drive deletedDrive = repository.DeleteDrive(driveId);
            if (deletedDrive != null)
            {
                TempData["message"] = $"{deletedDrive.Manufacturer} {deletedDrive.Model} was deleted";
            }

            return RedirectToAction("Index");
        }
    }
}