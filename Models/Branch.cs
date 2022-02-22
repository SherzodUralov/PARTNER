using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Branch
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("BranchId")]
        [Display(Name ="BranchId")]
        public int BranchId { get; set; }
        [Column("BranchName")]
        [Display(Name ="BranchName")]
        [MaxLength(35)] 
        public string BranchName { get; set; }
        [ForeignKey("FacultyId")]
        [Column("FacultyId")]
        [Display(Name ="FacultyId")]
        public virtual Faculty FacultyId { get; set; }
    }
}
