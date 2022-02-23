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
        public int InteristId { get; set; }
        public Musics? Music { get; set; }
        public Arts? Art { get; set; }
        public Sports? Sport { get; set; }
        public Scientifics? Scientific { get; set; }
        public string BoshqaSoxa { get; set; }
    }
}
