using GestionEcole.Models;
using GestionEcole.Repositories;

namespace GestionEcole.Services
{
    public class EtudiantService
    {
        private readonly IGenericRepository<Etudiant> _repository;

        public EtudiantService(IGenericRepository<Etudiant> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Etudiant> GetAllEtudiants()
        {
            return _repository.GetAll();
        }

        public void AddEtudiant(Etudiant etudiant)
        {
            _repository.Add(etudiant);
        }
    }
}
