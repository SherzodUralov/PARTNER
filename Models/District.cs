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
        [Key]
        public string Code { get; set; }
        [Required]
        [MaxLength(25)]
        [Display(Name ="DistrictName")]
        public string DistrictName { get; set; }
        [ForeignKey("Region")]
        public string RegionCode { get; set; }
        public virtual Region Region { get; set; }


    }
}
