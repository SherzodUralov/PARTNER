using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Speciality
    {
        public int SpecialityId { get; set; }
        [MaxLength(40)]
        public string SpecialityName { get; set; }
        [MaxLength(18)]
        public string Years { get; set; }
        public int TyutorId { get; set; }
        public virtual Tyutor Tyutor { get; set; }
    }
}
