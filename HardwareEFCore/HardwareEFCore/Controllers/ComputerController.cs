using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HardwareEFCore.Models;
using HardwareEFCore.Models.ViewModels;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Web.Helpers;
using Microsoft.AspNetCore.Http;

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
        public IActionResult UploadImage(Computer computer)
        {
            var photos = HttpContext.Request.Form.Files;
            if (photos != null)
            {
                foreach (var image in photos)
                {
                    if (image != null)
                    {
                        string imgName = Path.GetFileName(image.FileName);
                        string imgExt = Path.GetExtension(imgName);

                        FileStream file = new FileStream(@"C:\Users\Dylan\Documents\School\ASP\labRepos\asp_lab12\HardwareEFCore\HardwareEFCore\wwwroot\Images\" + imgName, FileMode.Create);
                        using(var ms = new MemoryStream())
                        {
                            image.CopyTo(ms);
                            ms.WriteTo(file);
                            file.Close();
                            ms.Close();

                            computer.ImagePath = "/Images/" + imgName;
                        }
                    computerRepo.SaveComputer(computer);
                    }
                }
            }
            else
            {
                return View("List");
            }

            return RedirectToAction("List");
        }

        [HttpPost]
        public IActionResult DeleteImage(int computerId)
        {
            Computer computer = computerRepo.Computers.FirstOrDefault(c => c.ComputerId == computerId);
            computer.ImagePath = null;
            computerRepo.SaveComputer(computer);

            return RedirectToAction("List");
        }
        
    }
}