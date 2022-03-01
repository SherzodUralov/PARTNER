using Microsoft.AspNetCore.Mvc;
using PARTNER.Servess;
using PARTNER.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepo;

        public StudentController(IStudentRepository studentRepo)
        {
            this.studentRepo = studentRepo;
        }
        public ViewResult Index()
        {
            HomeIndexViewModel homeIndex = new HomeIndexViewModel()
            {
                students = studentRepo.GetAll()
            };
            return View(homeIndex);
        }
    }
}
