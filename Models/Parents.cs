using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Parents
    {
        [Column("ParentsId")]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ParentsId { get; set; }
        [Required]
        [MaxLength(18)]
        [Column("FirstName")]
        [Display(Name ="FirstName")]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(18)]
        [Column("LastName")]
        [Display(Name ="LastName")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(18)]
        [Column("SureName")]
        [Display(Name ="SureName")]
        public string SureName { get; set; }
        [Required]
        [Column("Birthday")]
        [Display(Name ="Birthday")]
        public DateTime Birthday { get; set; }
        [Required]
        [MaxLength(20)]
        [Column("MobileNamber")]
        [Display(Name ="MobileNamber")]
        public string MobileNamber { get; set; }
        [MaxLength(20)]
        [Column("TelegramNamber")]
        [Display(Name ="TelegramNamber")]
        public string TelegramNamber { get; set; }
        [ForeignKey("RegionId")]
        [Column("RegionId")]
        [Display(Name ="RegionId")]
        public virtual Region RegionId { get; set; }
        [ForeignKey("DistrictId")]
        [Column("DistrictId")]
        [Display(Name ="DistrictId")]
        public virtual District DistrictId { get; set; }
        [ForeignKey("NogironId")]
        [Column("NogironId")]
        [Display(Name ="NogironId")]
        public virtual Nogiron NogironId { get; set; }
        [MaxLength(28)]
        [Column("Mahalla")]
        [Display(Name ="Mahalla")]
        public string Mahalla { get; set; }
        [Required]
        [Column("Job")]
        [Display(Name ="Job")]
        public Jobs? Job { get; set; }


    }
}
