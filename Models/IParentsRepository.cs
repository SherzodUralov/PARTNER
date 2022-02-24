using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public interface IParentsRepository
    {
        Parents GET(int id);
        IEnumerable<Parents> GETALL();
    }
}
