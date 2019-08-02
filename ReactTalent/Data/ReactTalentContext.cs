using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ReactTalent.Models
{
    public class ReactTalentContext : DbContext
    {
        public ReactTalentContext (DbContextOptions<ReactTalentContext> options)
            : base(options)
        {
        }

        public DbSet<ReactTalent.Models.Store> Store { get; set; }
    }
}
