using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Tyutor
    {
        [Required]
        [Column("TyutorId")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TyutorId { get; set; }
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
        [Column("SurName")]
        [Display(Name ="SurName")]
        [MaxLength(18)]
        public string SureName { get; set; }
        [Required]
        [Column("Birthday")]
        [Display(Name ="Birthday")]
        public DateTime Birthday { get; set; }
        [ForeignKey("RegionId")]
        [Column("RegionId")]
        [Display(Name ="RegionId")]
        public virtual Region RegionId { get; set; }
        [ForeignKey("DistrictId")]
        [Column("DistrictId")]
        [Display(Name ="DistrictId")]
        public virtual District DistrictId { get; set; }
        [Required]
        [Column("Staj")]
        [Display(Name ="Staj")]
        public int Staj { get; set; }
        [Required]
        [Column("MobileNamber")]
        [Display(Name ="MobileNamber")]
        [MaxLength(15)]
        public string MobileNamber { get; set; }
        [Required]
        [Column("TelegramNamber")]
        [Display(Name = "TelegramNamber")]
        [MaxLength(15)]
        public string TelegramNamber { get; set; }
        [Column("Image")]
        [Display(Name = "Image")]
        public string PhotoFilePath { get; set; }
        [Column("Resime")]
        [Display(Name = "Resime")]
        public string Resime { get; set; }
        [Required]
        [Column("Gender")]
        [Display(Name = "Gender")]
        public Genders? Gender { get; set; }
        [Required]
        [Column("Degree")]
        [Display(Name = "Degree")]
        public Degrees? Degree { get; set; }

    }
}
