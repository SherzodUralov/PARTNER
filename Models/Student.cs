using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SureName { get; set; }
        public DateTime Birthday { get; set; }
        public string Passport { get; set; }
        public Genders? Gender { get; set; }
        public string MobileNamber { get; set; }
        public string TelegramNamber { get; set; }
        public Nations? Nation { get; set; }
        public string ParentsId { get; set; }
        public string InteristId { get; set; }
        public int DistrictId { get; set; }
        public string Mahalla { get; set; }
        public int GroupId { get; set; }
        public int Cours { get; set; }
        public int LiveId { get; set; }
        public Contracts? Contract { get; set; }
        public Famillys? Familly { get; set; }
        public KamTams? KamTam { get; set; }
        public string BoquvchiId { get; set; }
        public int NogironID { get; set; }
        public int DegreeId { get; set; }



    }
}
