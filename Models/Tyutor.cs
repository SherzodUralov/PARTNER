using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Tyutor
    {
        public int TyutorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SureName { get; set; }
        public DateTime Birthday { get; set; }
        public int Staj { get; set; }
        public string MobileNamber { get; set; }
        public string TelegramNamber { get; set; }
        public int Image { get; set; }
        public string Resime { get; set; }
        public Genders? Gender { get; set; }
        public Degrees? Degree { get; set; }

    }
}
