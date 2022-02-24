using PARTNER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Student> students { get; set; }
        public IEnumerable<Tyutor> tyutors { get; set; }
    }
}
