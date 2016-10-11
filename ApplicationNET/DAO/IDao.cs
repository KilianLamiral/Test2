using ApplicationNET.Models.Class_Metier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationNET.Models.DAO
{
  public interface IDao
    {
        Produit AjouterProduit(Produit prod);

        void SupprimerProduit(int prodID);

        Produit RechercherRefProduit(int prodID);

        ICollection<Produit> ReturnAll();
        ICollection<Categorie> ReturnAllCat();
        ICollection<Magasin> ReturnAllMag();

        Produit RechercherProduitParNom(string nom);

        Magasin AjouterMagasin(Magasin mag);

        Produit Update(Produit prod);

        Categorie AjouterCategorie(Categorie cat);
    }
}
