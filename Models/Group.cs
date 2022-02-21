using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Group
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("GroupId")]
        [Display(Name ="GroupId")]
        public int GroupId { get; set; }
        [Column("GroupName")]
        [Display(Name ="GroupName")]
        [MaxLength(35)]
        public string GroupName { get; set; }
        [ForeignKey("BranchId")]
        [Column("BranchId")]
        [Display(Name ="BranchId")]
        public virtual Branch BranchId { get; set; }
        [ForeignKey("TyutorId")]
        [Column("TyutorId")]
        [Display(Name ="TyutorId")]
        public virtual Tyutor TyutorId { get; set; }

    }
}
