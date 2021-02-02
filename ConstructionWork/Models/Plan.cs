using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConstructionWork.Models
{
    public class Plan
    {    
        [Key]
        public int ID { get; set; }
        public int PlanCode { get; set; }
        public String Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
