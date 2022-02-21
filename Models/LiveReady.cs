using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class LiveReady
    {
        public int LiveReadyId { get; set; }
        public string Mahalla { get; set; }
        public int DistrictId { get; set; }
        public LiveTypes? LiveType { get; set; }

    }
}
