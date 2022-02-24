using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Controllers
{
    public class TyutorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
