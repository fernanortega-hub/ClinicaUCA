using Microsoft.EntityFrameworkCore;
using Parcial02.Models.Reservations;
using Parcial02.Models.Security_Questions;
using Parcial02.Models.Specialities;
using Parcial02.Models.Users;

namespace Parcial02.Context
{
    public class ParcialContext : DbContext
    {
        // Declarando entidades
        public DbSet<User> Users { get; set; }
        public DbSet<Security_Question> SecurityQuestions { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=parcialDb;Trusted_Connection=true");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasKey(u => u.CarnetId);
            
            modelBuilder.Entity<Reservation>()
                .Property(r => r.Id)
                .ValueGeneratedOnAdd();
            
            modelBuilder.Entity<Security_Question>().HasData(
                new Security_Question()
                {
                    Id = 1,
                    Question = "¿En qué año naciste?"
                },
                new Security_Question()
                {
                    Id = 2,
                    Question = "¿Cómo se llamó tu primer mascota?"
                },
                new Security_Question() 
                {
                    Id = 3,
                    Question = "¿De qué colegio te graduaste de bachiller?"
                },
                new Security_Question() 
                {
                    Id = 4,
                    Question = "¿Nombre de tu película favorita?"
                }
            );

            modelBuilder.Entity<Speciality>().HasData(
                new Speciality()
                {
                    id = 1, SpecialityName = "Medicina General"
                },
                new Speciality()
                {
                    id = 2, SpecialityName = "Odontología"
                },
                new Speciality()
                {
                    id = 3, SpecialityName = "Psicología"
                },
                new Speciality()
                {
                    id = 4, SpecialityName = "Oftalmología"
                }
                );

        }
        
    }
}