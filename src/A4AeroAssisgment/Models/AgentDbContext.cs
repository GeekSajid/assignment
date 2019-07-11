using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace A4AeroAssisgment.Models
{
    public class AgentDbContext : DbContext
    {
        public DbSet<BusinessEntities> Agents { get; set; }

    }
}