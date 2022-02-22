using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Faculty
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("FacultyId")]
        [Display(Name ="FacultyId")]
        public int FacultyId { get; set; }
        [Column("FacultyName")]
        [Display(Name ="FacultyName")]
        [MaxLength(35)]
        public string FacultyName { get; set; }
        [ForeignKey("UnverstyId")]
        [Column("UnverstyId")]
        [Display(Name ="UnverstyId")]
        public virtual Unversty UnverstyId { get; set; }

    }
}
