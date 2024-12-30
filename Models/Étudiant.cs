namespace GestionEcole.Models;
public class Etudiant
{
    public int Id { get; set; }
    public string Matricule { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Adresse { get; set; }
    public DateTime DateNaissance { get; set; }

    public ICollection<Cours> Cours { get; set; }
    public ICollection<Absence> Absences { get; set; }
}