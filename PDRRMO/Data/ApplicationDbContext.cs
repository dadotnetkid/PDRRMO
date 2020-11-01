using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PDRRMO.Data
{
    public class ApplicationDbContext : DbContext
    {
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
