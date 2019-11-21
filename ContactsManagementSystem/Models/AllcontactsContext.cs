using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactsManagementSystem.Models
{
    public class AllcontactsContext:DbContext
    {
        public AllcontactsContext(DbContextOptions<AllcontactsContext> options):base(options)
        {
        }

        public DbSet<Allcontacts> Allcontacts { get; set; }
        public DbSet<Gender> Gender { get; set; }
    }
}
