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
        [Required]
        [Column("StudentId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { get; set; }
        [Required]
        [Column("FirstName")]
        [Display(Name ="FirstName")]
        [MaxLength(18)]
        public string FirstName { get; set; }
        [Required]
        [Column("LastName")]
        [Display(Name ="LastName")]
        [MaxLength(18)]
        public string LastName { get; set; }
        [Required]
        [Column("SureName")]
        [Display(Name ="SureName")]
        [MaxLength(18)]
        public string SureName { get; set; }
        [Required]
        [Column("Birthday")]
        [Display(Name ="Birthday")]
        public DateTime Birthday { get; set; }
        [Required]
        [Column("Passport")]
        [Display(Name ="Passport")]
        [MaxLength(18)]
        public string Passport { get; set; }
        [Required]
        [Column("Gender")]
        [Display(Name ="Gender")]
        public Genders? Gender { get; set; }
        [Required]
        [Column("MobileNamber")]
        [Display(Name ="MobileNamber")]
        [MaxLength(15)]
        public string MobileNamber { get; set; }
        [Required]
        [Column("TelegramNamber")]
        [Display(Name ="Telegram")]
        [MaxLength(15)]
        public string TelegramNamber { get; set; }
        [Required]
        public Nations? Nation { get; set; }
        public string ParentsId { get; set; }
        public string InteristId { get; set; }
        public int RegionId { get; set; }
        public int DistrictId { get; set; }
        public string Mahalla { get; set; }
        public int GroupId { get; set; }
        public int Cours { get; set; }
        public int LiveReadyId { get; set; }
        public Contracts? Contract { get; set; }
        public Famillys? Familly { get; set; }
        public KamTams? KamTam { get; set; }
        public string BoquvchiId { get; set; }
        public int NogironID { get; set; }
        public Degrees? Degree { get; set; }



    }
}
