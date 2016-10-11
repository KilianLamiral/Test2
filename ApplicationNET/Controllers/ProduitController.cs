using ApplicationNET.Models.Class_Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApplicationNET.Controllers
{
    public class ProduitController : Controller
    {
        public IMetier Imetier = new MetierImplemente();
        // GET: Produit
        public ActionResult Index()
        {
            return View();
        }
        //action qui va afficher le formulaire ajouter produit il est sans arguments
        public ActionResult AjouterProduit()
        {
            return View();
        }
        //action qui va ajouter un produit en base, on creer un objet prod qui va permettre l'ajout
        [HttpPost] //on met httpPost pour specifier que c'est de type post ==> lui dit va en base. Si on veut que afficher on peut mettre GET
        public ActionResult AjouterProduit(Produit prod)
        {
            Imetier.AjouterProduit(prod);
            return RedirectToAction("AfficherListeproduit");
        }

        //liste de produit
        public ActionResult AfficherListeProduit()
        {
            ICollection<Produit> listeProduit = Imetier.ReturnAll();
            return View(listeProduit);
        }

        //Supprimer des produit
        public ActionResult SupprimerProduit(int prodID)
        {
            Imetier.SupprimerProduit(prodID);
            return RedirectToAction("AfficherListeProduit");
        }
        //UPDATE
        public ActionResult UpdateProduit (int prodID)
        {
            Produit prod = Imetier.RechercherRefProduit(prodID);
            return View(prod);
        }
        [HttpPost]
        public ActionResult UpdateProduit(Produit prod)
        {
            Imetier.Update(prod);
            return RedirectToAction("AfficherListeProduit");
        }
    }
}