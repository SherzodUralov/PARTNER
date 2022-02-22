using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Unversty
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("UnverstyId")]
        [Display(Name ="UnverstyId")]
        public int UnverstyId { get; set; }
        [Column("UnverstyName")]
        [Display(Name ="UnverstyName")]
        [MaxLength(35)]
        public string UnverstyName { get; set; }
        [ForeignKey("RegionId")]
        [Column("RegionId")]
        [Display(Name ="RegionId")]
        public virtual Region RegionId { get; set; }

    }
}
