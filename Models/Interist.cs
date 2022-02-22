using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Interist
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("InteristId")]
        [Display(Name ="InterisitId")]
        public int InteristId { get; set; }
        [Required]
        [Column("Music")]
        [Display(Name ="Music")]
        public Musics? Music { get; set; }
        [Required]
        [Column("Art")]
        [Display(Name ="Art")]
        public Arts? Art { get; set; }
        [Required]
        [Column("Sport")]
        [Display(Name ="Sport")]
        public Sports? Sport { get; set; }
        [Required]
        [Column("Scientific")]
        [Display(Name ="Scientific")]
        public Scientifics? Scientific { get; set; }
        [Required]
        [Column("BoshqaSoxa")]
        [Display(Name ="BoshqaSoxa")]
        public string BoshqaSoxa { get; set; }
    }
}
