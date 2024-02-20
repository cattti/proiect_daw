using System;
using proiect_daw.Models;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace proiect_daw.Data
{
    public class clasaContext : DbContext
    {


        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Collaborator> Collaborators { get; set; }
        public DbSet<Project_Collaborator> ProjectCollaborators { get; set; }
        public DbSet<Artwork> Artworks { get; set; }
        public DbSet<Istoric> Istorics { get; set; }



        public clasaContext(DbContextOptions<clasaContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {



            //one to one

            modelbuilder.Entity<Artwork>()
                .HasOne(a => a.Istoric)
                .WithOne(i => i.Artwork)
                .HasForeignKey<Istoric>(i => i.ArtworkId);



            //many to many

            modelbuilder.Entity<Project_Collaborator>()
                .HasKey(pc => new { pc.CollaboratorId, pc.ProjectId });

            modelbuilder.Entity<Project_Collaborator>()
                .HasOne(pc => pc.Collaborator)
                .WithMany(c => c.Project_Collaborators)
                .HasForeignKey(pc => pc.CollaboratorId);

            modelbuilder.Entity<Project_Collaborator>()
             .HasOne(pc => pc.Project)
             .WithMany(p => p.Project_Collaborators)
             .HasForeignKey(pc => pc.ProjectId);



            //one to many


            modelbuilder.Entity<Project>()
                .HasMany(p => p.Comments)
                .WithOne(c => c.Project);

            modelbuilder.Entity<User>()
                .HasMany(u => u.Comments)
                .WithOne(c => c.User);

            modelbuilder.Entity<User>()
                .HasMany(u => u.Projects)
                .WithOne(p => p.User);

            modelbuilder.Entity<Project>()
                .HasMany(p => p.Artworks)
                .WithOne(a => a.Project);




  

            base.OnModelCreating(modelbuilder);

            SeedRoles(modelbuilder);



        }



        private static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData
                (
                new IdentityRole() { Name= "Admin", ConcurrencyStamp="1", NormalizedName="Admin"},
                new IdentityRole() { Name= "User", ConcurrencyStamp="2", NormalizedName="User"}
                );
        }



    }
}

