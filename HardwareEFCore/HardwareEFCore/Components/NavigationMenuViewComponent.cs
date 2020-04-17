using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HardwareEFCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace HardwareEFCore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IDriveRepository repository;

        public NavigationMenuViewComponent(IDriveRepository repo)
        {
            repository = repo;
        }
        
        public IViewComponentResult Invoke() 
        {
            ViewBag.SelectedDriveInterface = RouteData?.Values["driveInterface"];
            return View(repository.Drives
                .Select(x => x.Interface)
                .Distinct()
                .OrderBy(x => x));
        }

    }
}
