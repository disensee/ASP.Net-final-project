using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HardwareEFCore.Infrastructure;
using HardwareEFCore.Models;
using HardwareEFCore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace HardwareEFCore.Controllers
{
    public class CartController : Controller
    {
        private IDriveRepository repository;
        private Cart cart;

        public CartController(IDriveRepository repo, Cart cartService)
        {
            repository = repo;
            cart = cartService;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToCart(int driveId, string returnUrl)
        {
            Drive drive = repository.Drives.FirstOrDefault(d => d.DriveId == driveId);

            if (drive != null)
            {
                cart.AddItem(drive, 1);
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int driveId, string returnUrl)
        {
            Drive drive = repository.Drives.FirstOrDefault(d => d.DriveId == driveId);

            if (drive != null)
            {
                cart.RemoveLine(drive);
            }

            return RedirectToAction("Index", new { returnUrl });
        }
    }
}
