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
        public int BranchId { get; set; }
        [Required]
        [MaxLength(40)]
        [Display(Name ="BranchName")]
        public string BranchName { get; set; }
        [ForeignKey("Faculty")]
        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
    }
}
