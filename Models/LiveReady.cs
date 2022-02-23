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
        [Key]
        public string Code { get; set; }
        public string Mahalla { get; set; }
        public string DistrictCode { get; set; }
        public virtual District District { get; set; }
        public LiveTypes? LiveType { get; set; }

    }
}
