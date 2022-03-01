using Microsoft.AspNetCore.Mvc;
using PARTNER.Servess;
using PARTNER.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Controllers
{
    public class TyutorController : Controller
    {
        private readonly ITyutorRepository repositoryy;

        public TyutorController(ITyutorRepository repository)
        {
            this.repositoryy = repository;
        }
        public ViewResult Index()
        {
            HomeIndexViewModel viewModel = new HomeIndexViewModel() 
            {
                tyutors = repositoryy.GetAlll()
            };
            return View(viewModel);
        }
    }
}
