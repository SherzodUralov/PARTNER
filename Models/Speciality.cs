using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Speciality
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SpecialityId")]
        [Display(Name ="SpecialityId")]
        public int SpecialityId { get; set; }
        [Required]
        [Column("SpecialityName")]
        [Display(Name ="SpecialityName")]
        [MaxLength(25)]
        public int SpecialityName { get; set; }
        [Required]
        [Column("Years")]
        [Display(Name ="Years")]
        [MaxLength(10)]
        public string Years { get; set; }
        [ForeignKey("TyutorId")]
        [Column("TyutorId")]
        [Display(Name ="TyutorId")]
        public virtual Tyutor TyutorId { get; set; }
    }
}
