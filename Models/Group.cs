using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PARTNER.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int BranchId { get; set; }
        public int TyutorId { get; set; }

    }
}
