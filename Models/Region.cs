using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Region
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("RegionId")]
        [Display(Name ="RegionId")]
        public int RegionId { get; set; }
        [Column("RegionName")]
        [Display(Name ="RegionName")]
        [MaxLength(25)]
        public string RegionName { get; set; }

    }
}
