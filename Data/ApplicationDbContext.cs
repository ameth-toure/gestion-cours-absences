using Microsoft.EntityFrameworkCore;
using GestionEcole.Models;

namespace GestionEcole.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Etudiant> Etudiants { get; set; }
        public DbSet<Cours> Cours { get; set; }
        public DbSet<Absence> Absences { get; set; }
    }
}
