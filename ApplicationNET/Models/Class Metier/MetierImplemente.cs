using ApplicationNET.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplicationNET.Models.Class_Metier
{
    public class MetierImplemente : IMetier
    {
        public IDao Idao = new DaoImplementation();
        //Methode de produit
        public Produit AjouterProduit(Produit prod)
        {
            return Idao.AjouterProduit(prod);
        }

        //methodes de magasin
        public ICollection<Produit> ReturnAll()
        {
            return Idao.ReturnAll();
        }

        public Magasin AjouterMagasin(Magasin mag)
        {
            return Idao.AjouterMagasin(mag);
        }

        public ICollection<Magasin> ReturnAllMag()
        {
            return Idao.ReturnAllMag();
        }

        //methode de categorie
        public Categorie AjouterCategorie(Categorie cat)
        {
            return Idao.AjouterCategorie(cat);
        }

        public ICollection<Categorie> ReturnAllCat()
        {
            return Idao.ReturnAllCat();
        }


       public Produit RechercherRefProduit(int prodID)
        {
            return Idao.RechercherRefProduit(prodID);
        }



        public void SupprimerProduit(int prodID)
        {
            Idao.SupprimerProduit(prodID);
        }

        public Produit Update (Produit prod)
        {
           return Idao.Update(prod);
        } 

      
    }
}