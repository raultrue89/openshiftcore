using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using aponshiftcore;

namespace aponshiftcore.Data
{
    public class aponshiftcoreContext : DbContext
    {
        public aponshiftcoreContext (DbContextOptions<aponshiftcoreContext> options)
            : base(options)
        {
        }

        public DbSet<aponshiftcore.Cliente> Cliente { get; set; }
    }
}
