using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class District
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("DistrictId")]
        [Display(Name ="DistrictId")]
        public int DistrictId { get; set; }
        [Column("DistrictName")]
        [Display(Name ="DistrictName")]
        [MaxLength(25)]
        public string DistrictName { get; set; }
        [ForeignKey("RegionId")]
        [Column("RegionId")]
        [Display(Name ="RegionId")]
        public virtual Region RegionId { get; set; }


    }
}
