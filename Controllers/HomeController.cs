using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PARTNER.Models;
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
        //private readonly ILogger<HomeController> _logger;
        private readonly IStudentRepository repository;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        public HomeController(IStudentRepository repository)
        {
            this.repository = repository;
        }

        public ViewResult Index() 
        {
            HomeIndexViewModel viewModel = new HomeIndexViewModel()
            {
                students = repository.GETALL()
            };

            return View(viewModel);
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
