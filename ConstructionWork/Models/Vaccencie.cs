using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionWork.Models
{
    public class Vaccencie
    {
        [Key]
        public int JobID { get; set; }
        public string JobType { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }
    }
}
