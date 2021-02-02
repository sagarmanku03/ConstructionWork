using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConstructionWork.Models;

namespace ConstructionWork.Data
{
    public class ConstructionWorkContext : DbContext
    {
        public ConstructionWorkContext (DbContextOptions<ConstructionWorkContext> options)
            : base(options)
        {
        }

        public DbSet<ConstructionWork.Models.Vaccencie> Vaccencie { get; set; }

        public DbSet<ConstructionWork.Models.Worker> Worker { get; set; }

        public DbSet<ConstructionWork.Models.Plan> Plan { get; set; }

        public DbSet<ConstructionWork.Models.Location> Location { get; set; }
    }
}
