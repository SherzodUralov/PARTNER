using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public interface ITyutorRepository
    {
        Tyutor GET(int id);
        IEnumerable<Tyutor> GETALL();
    }
}
