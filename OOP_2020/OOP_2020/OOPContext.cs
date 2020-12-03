using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2020
{
    public class OOPContext: DbContext
    {
        public OOPContext():base()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Discipline>().Property(d => d.Name).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Discipline>()
                .HasMany(d => d.Specialities)
                .WithMany(s => s.Disciplines);

            modelBuilder.Entity<Speciality>().Property(s => s.Name).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Speciality>()
                .HasMany(s => s.Groups)
                .WithRequired(g => g.Speciality);
        }

        public virtual DbSet<Human> Humans { get; set; }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Group> Groups { get; set; }

        public virtual DbSet<Speciality> Specialities { get; set; }

        public virtual DbSet<Discipline> Disciplines { get; set; }
    }
}
