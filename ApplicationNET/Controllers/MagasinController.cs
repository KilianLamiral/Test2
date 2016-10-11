using ApplicationNET.Models.Class_Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationNET.Controllers
{
    public class MagasinController : Controller
    {
        public IMetier Imetier = new MetierImplemente();
        // GET: Magasin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AjoutMagasin(Magasin mag)
        {
            Imetier.AjouterMagasin(mag);
            return View();

        }

        public ActionResult AfficherListeMagasin()
        {
            ICollection<Magasin> listeMagasin = Imetier.ReturnAllMag();
            return View(listeMagasin);
        }
    }
}