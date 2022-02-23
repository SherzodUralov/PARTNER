using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    [Table("CHECK")]
    public class Check
    {
        public int CheckId { get; set; }
        [Required]
        [MaxLength(19)]
        [Display(Name ="YearMonth")]
        public string YearMonth { get; set; }
        [Required]
        [Display(Name ="Timee")]
        public int Timee { get; set; }   
        public Uzlashtrish? Uzlashtirish { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }   
        public virtual Student Student { get; set; }

    }
}
