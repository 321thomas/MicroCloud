using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MircoCloud.DAL.Models;

namespace MircoCloud.DAL
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public new DbSet<ApplicationUser> Users { get; set; }
        public DbSet<Device> Devices { get; set; }
    }
}
