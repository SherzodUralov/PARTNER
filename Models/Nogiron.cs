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
        [Key]
        public string Code { get; set; }
        [MaxLength(30)]
        public int NogironName { get; set; }
        public Typeees? Typeee { get; set; }
    }
}
