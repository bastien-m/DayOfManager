using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DayOffManager.Models
{
    public class DayOffManagerContext : DbContext
    {
        public DayOffManagerContext()
            : base("name=DayOffManager" + SPBTools.Utils.Environnement.LoadEnvironment(SPBTools.Utils.Environnement.EnumParamEnvironnement.Sql))
        {
        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<DateAsked> DateAskeds { get; set; }
        
    }
}