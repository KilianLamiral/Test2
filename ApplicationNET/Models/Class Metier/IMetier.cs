using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationNET.Models.Class_Metier
{
    public interface IMetier
    {
        Produit AjouterProduit(Produit prod);

        Magasin AjouterMagasin(Magasin mag);

        ICollection<Produit> ReturnAll();
        ICollection<Categorie> ReturnAllCat();
        ICollection<Magasin> ReturnAllMag();

        Categorie AjouterCategorie(Categorie cat);

        void SupprimerProduit(int prodID);

        Produit Update(Produit prod);
        Produit RechercherRefProduit(int prodID);
    }
}
