using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class LiveReady
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("LiveReadyId")]
        [Display(Name ="LiveReadyId")]
        public int LiveReadyId { get; set; }
        [Column("Mahalla")]
        [Display(Name ="Mahalla")]
        [MaxLength(35)]
        public string Mahalla { get; set; }
        [ForeignKey("DistrictId")]
        [Column("DistrictId")]
        [Display(Name ="DistricId")]
        public virtual District DistrictId { get; set; }
        [Required]
        [Column("LiveType")]
        [Display(Name ="LiveType")]
        public LiveTypes? LiveType { get; set; }

    }
}
