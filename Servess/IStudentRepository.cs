using PARTNER.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Servess
{
    public interface IStudentRepository 
    {
        Student Get(int id);
        IEnumerable<Student> GetAll();
    }
}
