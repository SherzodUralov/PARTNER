using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Speciality
    {
        public int SpecialityId { get; set; }
        public int SpecialityName { get; set; }
        public string Years { get; set; }
        public int TyutorId { get; set; }
    }
}
