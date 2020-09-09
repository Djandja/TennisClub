using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennisClub.Models;
using TennisClub.Models.TurnirsViewModel;

namespace TennisClub.Data.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }

        public DbSet<Reservations> Reservations { get; set; }

        public DbSet<Turnirs> Turnirs { get; set; }
        
        


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            builder.Entity<Reservations>()
                .HasOne(p => p.User)
                .WithMany(b => b.Reservations)
                .HasForeignKey(p => p.UserID);


            builder.Entity<Turnirs>()
                .HasOne(p => p.User)
                .WithMany(b => b.Turnirs)
                .HasForeignKey(p => p.UserID);



        }
    }
}
