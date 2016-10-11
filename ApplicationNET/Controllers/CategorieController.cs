using ApplicationNET.Models.Class_Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationNET.Controllers
{
    public class CategorieController : Controller
    {
        public IMetier Imetier = new MetierImplemente();
        // GET: Categorie
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AjouterCategorie(Categorie cat)
        {
            Imetier.AjouterCategorie(cat);
            return View();
        }

        public ActionResult AfficherListeCategorie()
        {
            ICollection<Categorie> listeCategorie = Imetier.ReturnAllCat();
            return View(listeCategorie);
        }

       
    }
}