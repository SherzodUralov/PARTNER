using PARTNER.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Parents
    {
       
        public int ParentsId { get; set; }
        [Required]
        [MaxLength(30)]
        public ParentsType ParentsType { get; set; }
        public string FirstName { get; set; }
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(30)]
        public string SureName { get; set; }
        public DateTime Birthday { get; set; }
        [Required]
        [MaxLength(20)]
        public string MobileNamber { get; set; }
        public string TelegramNamber { get; set; }
        public string RegionCode { get; set; }
        public virtual Region Region { get; set; }
        public string DistrictCode { get; set; }
        public virtual District District { get; set; }
        public string NogironCode { get; set; }
        public virtual Nogiron Nogiron { get; set; }
        public string Mahalla { get; set; }
        public Jobs? Job { get; set; }


    }
}
