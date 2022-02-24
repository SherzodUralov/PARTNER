using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public interface IStudentRepository
    {
        Student GET(int id);
        IEnumerable<Student> GETALL();

    }
}
