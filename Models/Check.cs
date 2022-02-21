using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Check
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("CheckId")]
        [Display(Name = "CheckId")]
        public int CheckId { get; set; }
        [Required]
        [Column("YearMonth")]
        [Display(Name = "YearMonth")]
        public string YearMonth { get; set; }
        [Required]
        [Column("Timee")]
        [Display(Name = "Timee")]
        public int Timee { get; set; }
        [Required]
        [Column("Uzlashtirish")]
        [Display(Name = "Uzlashtirish")]
        public Uzlashtrish? Uzlashtirish { get; set; }
    }
}
