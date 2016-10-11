namespace ApplicationNET.Models.DAO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using Class_Metier;

    public  class ApplicationContext : DbContext
    {
       
        public ApplicationContext():base("BaseProduit")
        {
            
        }

        public DbSet<Produit> produits { get; set; }
        public DbSet<Magasin> magasins { get; set; }

        public DbSet<Categorie> categories { get; set; }
    }
}
