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
        public int FacultyId { get; set; }
        [Required]
        [MaxLength(30)]
        [Display(Name ="FacultyName")]
        public string FacultyName { get; set; }
        [ForeignKey("Unversty")]
        public int UnverstyId { get; set; }
        public virtual Unversty Unversty { get; set; }

    }
}
