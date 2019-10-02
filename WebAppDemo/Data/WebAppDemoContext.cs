using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppDemo.Models
{
    public class WebAppDemoContext : DbContext
    {
        public WebAppDemoContext (DbContextOptions<WebAppDemoContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppDemo.Models.Movies> Movies { get; set; }
    }
}
