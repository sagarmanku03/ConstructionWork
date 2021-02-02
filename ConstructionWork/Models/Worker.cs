using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionWork.Models
{
    public class Worker
    {
        [Key]
        public int StaffID { get; set; }
        public string Staffname { get; set; }

        public string StaffDoB { get; set; }

        public string StaffAddress { get; set; }
    }
}
