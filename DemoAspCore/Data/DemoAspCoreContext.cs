using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DemoAspCore.Models
{
    public class DemoAspCoreContext : DbContext
    {
        public DemoAspCoreContext (DbContextOptions<DemoAspCoreContext> options)
            : base(options)
        {
        }

        public DbSet<DemoAspCore.Models.Categoria> Categoria { get; set; }
    }
}
