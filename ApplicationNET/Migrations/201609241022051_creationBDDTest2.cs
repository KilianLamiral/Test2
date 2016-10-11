namespace ApplicationNET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creationBDDTest2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategorieID = c.Int(nullable: false, identity: true),
                        NomCategorie = c.String(),
                    })
                .PrimaryKey(t => t.CategorieID);
            
            CreateTable(
                "dbo.Magasins",
                c => new
                    {
                        MagasinID = c.Int(nullable: false, identity: true),
                        NomMagasin = c.String(),
                    })
                .PrimaryKey(t => t.MagasinID);
            
            CreateTable(
                "dbo.Produits",
                c => new
                    {
                        ProduitID = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prix = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ProduitID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produits");
            DropTable("dbo.Magasins");
            DropTable("dbo.Categories");
        }
    }
}
