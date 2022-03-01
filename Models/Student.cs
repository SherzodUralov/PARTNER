using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(30)]
        public string SureName { get; set; }
        public DateTime Birthday { get; set; }
        [Required]
        [MaxLength(30)]
        public string Passport { get; set; }
        public Genders? Gender { get; set; }
        [Required]
        [MaxLength(30)]
        public string MobileNamber { get; set; }
        public string TelegramNamber { get; set; }
        public Nations? Nation { get; set; }
        public int ParentsId { get; set; }
        public virtual Parents Parents { get; set; }
        public int InteristId { get; set; }
        public virtual Interist Interist { get; set; }
        public string RegionCode { get; set; }
        public virtual Region Region { get; set; }
        public string DistrictCode { get; set; }
        public virtual District District { get; set; }
        public string Mahalla { get; set; }
        public string UnverstyCode { get; set; }
        public virtual Unversty Unversty { get; set; }
        public string FacultyCode { get; set; }
        public virtual Faculty Faculty { get; set; }
        public string BranchCode { get; set; }
        public virtual Branch Branch { get; set; }
        public string GroupCode { get; set; }
        public virtual Group Group { get; set; }
        public int Cours { get; set; }
        public string LiveReadyCode { get; set; }
        public virtual LiveReady LiveReady { get; set; }
        public Contracts? Contract { get; set; }
        public Famillys? Familly { get; set; }
        public KamTams? KamTam { get; set; }
        public Boquvchis? Boquvchi { get; set; }
        public string NogironCode { get; set; }
        public virtual Nogiron Nogiron { get; set; }
        public Degrees? Degree { get; set; }



    }
}
