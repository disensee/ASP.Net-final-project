using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HardwareEFCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace HardwareEFCore.Controllers
{
    public class BuildOrderController : Controller
    {
        private IBuildOrderRepository repository;
        private Cart cart;

        public BuildOrderController(IBuildOrderRepository repoService, Cart cartService)
        {
            repository = repoService;
            cart = cartService;
        }

        public ViewResult List() => View(repository.BuildOrders.Where(bo => !bo.Shipped));

        [HttpPost]
        public IActionResult MarkShipped(int buildOrderId)
        {
            BuildOrder buildOrder = repository.BuildOrders.FirstOrDefault(bo => bo.BuildOrderId == buildOrderId);

            if (buildOrder != null)
            {
                buildOrder.Shipped = true;
                repository.SaveBuildOrder(buildOrder);
            }

            return RedirectToAction(nameof(List)); 
        }

        public ViewResult Checkout() => View(new BuildOrder());

        [HttpPost]
        public IActionResult Checkout(BuildOrder buildOrder)
        {
            if (cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }

            if (ModelState.IsValid)
            {
                //Now we associate the CartLines with the Order
                buildOrder.Lines = cart.Lines.ToArray();
                repository.SaveBuildOrder(buildOrder);
                return RedirectToAction(nameof(Completed));
            }
            else
            {
                return View(buildOrder);
            }
        }

        public ViewResult Completed()
        {
            cart.Clear();
            return View();
        }
    }
}