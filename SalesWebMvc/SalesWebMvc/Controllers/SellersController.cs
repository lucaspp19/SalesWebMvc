using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Controllers
{
    
    public class SellersController : Controller
    {

        public readonly SellersService _sellersService;

        public SellersController(SellersService sellersService)
        {

            _sellersService = sellersService;

        }


        public IActionResult Index()
        {
            var list = _sellersService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {

            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Seller seller)
        {
            _sellersService.Insert(seller);
            return RedirectToAction("Index");
        }
    }
}
