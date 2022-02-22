using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Nogiron
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("NogironId")]
        [Display(Name ="NogironId")]
        public int NogironId { get; set; }
        [Column("NogironName")]
        [Display(Name ="NogironName")]
        [MaxLength(25)]
        public int NogironName { get; set; }
        [Required]
        [Column("Typeee")]
        [Display(Name ="Typeee")]
        public Typeees? Typeee { get; set; }
    }
}
