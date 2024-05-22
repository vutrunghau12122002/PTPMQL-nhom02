using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCoreMVC.Models;
using NetCoreMvc.Models;

namespace NetCoreMVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NetCoreMVC.Models.Person> Person { get; set; } = default!;
        public DbSet<NetCoreMvc.Models.Employee> Employee { get; set; } = default!;
    }
}
