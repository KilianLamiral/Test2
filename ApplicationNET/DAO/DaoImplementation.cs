using ApplicationNET.Models.Class_Metier;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApplicationNET.Models.DAO
{
    public class DaoImplementation : IDao
    {
        public Produit AjouterProduit(Produit prod)
        {
            //initialisation du contexte
            using (var db = new DAO.ApplicationContext())
            {
                //ajout de l'objet produit au DbSet (db)
                db.produits.Add(prod);

                //mise a jour de la BDD
                db.SaveChanges();

                return prod;
            }
        }

        public Produit RechercherRefProduit(int prodID)
        {
            //initialisation du contexte
            using (var db = new DAO.ApplicationContext())
            {
                //ajout de l'objet produit au DbSet (db)
                return db.produits.Find(prodID);
            }
        }

        public ICollection<Produit> RechercherProduitParNom(string nom)
        {
            using (var db = new DAO.ApplicationContext())
            {
                // return db.produits.Where(p => p.Nom == nom).ToList();
                var req = from p in db.produits
                          where p.Nom.Contains("%" + nom + "%")
                          select p;

                    return req.ToList();
            }
        }


        public ICollection<Produit> ReturnAll()
        {
            using (var db = new DAO.ApplicationContext())
            {
                return db.produits.ToList();
            }
        }

        public ICollection<Categorie> ReturnAllCat()
        {
            using (var db = new DAO.ApplicationContext())
            {
                return db.categories.ToList();
            }
        }

        public ICollection<Magasin> ReturnAllMag()
        {
            using (var db = new DAO.ApplicationContext())
            {
                return db.magasins.ToList();
            }
        }

        public void SupprimerProduit(int prodID)
        {
            //initialisation du contexte
            using (var db = new DAO.ApplicationContext())
            {
                //besoin de trouver le produit a supprimer 
                Produit element = db.produits.Find(prodID);
                //supprimer de l'objet produit au DbSet (db)
                db.produits.Remove(element);

                db.SaveChanges();
            }
        }

        

        Produit IDao.RechercherProduitParNom(string nom)
        {
            throw new NotImplementedException();
        }


        public Produit Update (Produit prod)
        {
            using (var db = new ApplicationContext())
            {
                db.Entry(prod).State = EntityState.Modified;
                db.SaveChanges();
                return prod;
            }
        }


        /*******METHODE DE MAGASIN********/
        public Magasin AjouterMagasin(Magasin mag)
        {
            //initialisation du contexte
            using (var db = new DAO.ApplicationContext())
            {
                //ajout de l'objet produit au DbSet (db)
                db.magasins.Add(mag);

                //mise a jour de la BDD
                db.SaveChanges();

                return mag;
            }
        }

        /**********METHODE DE CATEGORIE***************/
        public Categorie AjouterCategorie(Categorie cat)
        {
            //initialisation du contexte
            using (var db = new DAO.ApplicationContext())
            {
                //ajout de l'objet produit au DbSet (db)
                db.categories.Add(cat);

                //mise a jour de la BDD
                db.SaveChanges();

                return cat;
            }
        }

       
    }
}