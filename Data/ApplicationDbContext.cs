using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Authtest.Models;

namespace Authtest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Authtest.Models.Sample> Sample { get; set; }
        public DbSet<Authtest.Models.Product> Product { get; set; }
        public DbSet<Authtest.Models.Order> Order { get; set; }
    }
}
