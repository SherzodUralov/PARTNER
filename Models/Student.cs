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
        [Display(Name = "FirstName")]
        [MaxLength(18)]
        public string FirstName { get; set; }
        [Required]
        [Column("LastName")]
        [Display(Name = "LastName")]
        [MaxLength(18)]
        public string LastName { get; set; }
        [Required]
        [Column("SureName")]
        [Display(Name = "SureName")]
        [MaxLength(18)]
        public string SureName { get; set; }
        [Required]
        [Column("Birthday")]
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }
        [Required]
        [Column("Passport")]
        [Display(Name = "Passport")]
        [MaxLength(18)]
        public string Passport { get; set; }
        [Required]
        [Column("Gender")]
        [Display(Name = "Gender")]
        public Genders? Gender { get; set; }
        [Required]
        [Column("MobileNamber")]
        [Display(Name = "MobileNamber")]
        [MaxLength(15)]
        public string MobileNamber { get; set; }
        [Required]
        [Column("TelegramNamber")]
        [Display(Name = "Telegram")]
        [MaxLength(15)]
        public string TelegramNamber { get; set; }
        [Required]
        [Column("Nation")]
        [Display(Name = "Nation")]
        public Nations? Nation { get; set; }
        [ForeignKey("ParentsId")]
        [Column("ParentsId")]
        [Display(Name = "Parents")]
        public virtual Parents ParentsId { get; set; }
        [Required]
        [ForeignKey("InteristId")]
        [Column("InteristId")]
        [Display(Name = "InteristId")]
        public virtual Interist InteristId { get; set; }
        [Required]
        [ForeignKey("RegionId")]
        [Column("RegionId")]
        [Display(Name ="RegionId")]
        public int RegionId { get; set; }
        [Required]
        [ForeignKey("DistrictId")]
        [Column("DistrictId")]
        [Display(Name ="DistrictId")]
        public int DistrictId { get; set; }
        [Column("Mahalla")]
        [Display(Name ="Mahalla")]
        [MaxLength(30)]
        public string Mahalla { get; set; }
        [Required]
        [ForeignKey("GroupId")]
        [Column("GroupId")]
        [Display(Name ="GroupId")]
        public virtual Group GroupId { get; set; }
        [Required]
        [Column("Cours")]
        [Display(Name ="Cours")]
        public int Cours { get; set; }
        [ForeignKey("LiveReadyId")]
        [Column("LiveReadyId")]
        [Display(Name ="LiveReadyId")]
        public int LiveReadyId { get; set; }
        [Required]
        [Column("Contract")]
        [Display(Name ="Contract")]
        public Contracts? Contract { get; set; }
        [Required]
        [Column("Familly")]
        [Display(Name ="Familly")]
        public Famillys? Familly { get; set; }
        [Required]
        [Column("KamTam")]
        [Display(Name ="KamTam")]
        public KamTams? KamTam { get; set; }
        [ForeignKey("")]
        [Column("BoquvchiId")]
        [Display(Name ="BoquvchiId")]
        public Boquvchis? Boquvchi { get; set; }
        [ForeignKey("NogironId")]
        [Column("NogironId")]
        [Display(Name ="NogironId")]
        public virtual Nogiron NogironID { get; set; }
        [Column("Degree")]
        [Display(Name ="Degree")]
        public Degrees? Degree { get; set; }



    }
}
