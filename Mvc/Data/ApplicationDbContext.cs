using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SportProject.Models;

namespace SportProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<Member>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Sports> Sports { get; set; }
        public DbSet<Comment> Comment { get; set; }
        public DbSet<Courses> Courses { get; set; }
    }
}
