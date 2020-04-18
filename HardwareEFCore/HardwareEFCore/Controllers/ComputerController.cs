using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HardwareEFCore.Models;
using HardwareEFCore.Models.ViewModels;

namespace HardwareEFCore.Controllers
{
    public class ComputerController : Controller
    {
        private IComputerRepository computerRepo;
        private int pageSize = 10;

        public ComputerController(IComputerRepository computerRepo)
        {
            this.computerRepo = computerRepo;
        }

        public IActionResult List(int page = 1)
        {
            ComputerListViewModel vModel = new ComputerListViewModel();

            IEnumerable<Computer> computers = computerRepo.Computers
                .OrderBy(c => c.ComputerId)
                .Skip((page - 1) * pageSize)
                .Take(pageSize);

            vModel.Computers = computers;
            PagingInfo pInfo = new PagingInfo()
            {
                CurrentPage = page,
                ItemsPerPage = pageSize,
                TotalItems = computerRepo.Computers.Count()
            };

            vModel.PagingInfo = pInfo;
            return View(vModel);
        }

        [HttpPost]
        public IActionResult UploadImage()
        {
            foreach(var image in Request.Form.Files)
            {
                
            }

            return null;
        }
        
    }
}