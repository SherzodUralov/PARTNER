using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PARTNER.Models;
using PARTNER.Servess;
using PARTNER.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRegionRepository repository;

        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(IRegionRepository regionRepository)
        {
            this.repository = regionRepository;
        }

        public ViewResult Index() 
        {
            HomeIndexViewModel homeIndex = new HomeIndexViewModel()
            {
                regions = repository.getall()
            };
            return View(homeIndex);
        }
       
        public IActionResult Privacy()
        {
           
            return View();
        }
      
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
