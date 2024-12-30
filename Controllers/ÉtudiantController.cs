using Microsoft.AspNetCore.Mvc;
using GestionEcole.Services;

namespace GestionEcole.Controllers
{
    public class EtudiantController : Controller
    {
        private readonly EtudiantService _etudiantService;

        public EtudiantController(EtudiantService etudiantService)
        {
            _etudiantService = etudiantService;
        }

        public IActionResult Index()
        {
            var etudiants = _etudiantService.GetAllEtudiants();
            return View(etudiants);
        } 

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Etudiant etudiant)
        {
            if (ModelState.IsValid)
            {
                _etudiantService.AddEtudiant(etudiant);
                return RedirectToAction("Index");
            }
            return View(etudiant);
        }
    }
}
