using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploAspNetCoreApi.Models
{
    public class ExWebApiDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public ExWebApiDbContext()
        {

        }

        public ExWebApiDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
