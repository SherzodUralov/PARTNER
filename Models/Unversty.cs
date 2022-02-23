using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Unversty
    {
        public int UnverstyId { get; set; }
        [Required]
        [MaxLength(40)]
        public string UnverstyName { get; set; }
        public int RegionId { get; set; }
        public virtual Region Region { get; set; }

    }
}
