using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using TrackerModuleV1._0.Models.PTM;

namespace TrackerModuleV1._0.Data
{
    public class PTMContex :DbContext
    {
        public PTMContex():base("DefaultConnection")
        {

        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            ///// MANY TO MANY >>> USER(M)---PROJECT(M)
            modelBuilder.Entity<User>()
                .HasMany(i => i.projects)
                .WithMany(u => u.users)
                .Map(m =>
                {
                    m.ToTable("ProjectUser");
                    m.MapLeftKey("User_UserId");
                    m.MapRightKey("Project_ProjectId");
                });


            ///// MANY TO MANY >>> PROJECT(M)----PART(M)
            modelBuilder.Entity<Project>()
                .HasMany(i => i.parts)
                .WithMany(p => p.Projects)
                .Map(m =>
                {
                    m.ToTable("ProjectPart");
                    m.MapLeftKey("Project_ProjectId");
                    m.MapRightKey("Part_PartId");
                });

            /////// MANY TO MANY >>> Level(M)----PART(M)
            modelBuilder.Entity<Part>()
                .HasMany(p => p.Levels)
                .WithMany(l => l.parts)
                .Map(m =>
                {
                    m.ToTable("PartLevel");
                    m.MapLeftKey("Part_PartId");
                    m.MapRightKey("Level_levelId");
                });

            /////ONE TO MANY RELATIONSHIP >>>> PROJECT(O)---LEVEL(M)
            modelBuilder.Entity<Level>()
                .HasRequired<Project>(l => l.project)
                .WithMany(p => p.Levels)
                .HasForeignKey<string>(l => l.projectId);

            ///// ONE TO MANY RELATIONSHIP >>>> USER(O)--- PART(M)
            modelBuilder.Entity<Part>()
                .HasRequired<User>(p => p.CreatedBy)
                .WithMany(u => u.Parts)
                .HasForeignKey<string>(p => p.CreatedUserId);
                

           

            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Project>()
            //    .HasMany(c => c.users).WithMany(i => i.projects)
            //    .Map(t => t.MapLeftKey("ProjectId")
            //        .MapRightKey("UserId")
            //        .ToTable("ProjectIdUserId"));
        }
    }
}