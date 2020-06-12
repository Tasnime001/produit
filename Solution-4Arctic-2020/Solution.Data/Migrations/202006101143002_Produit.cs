namespace Solution.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Produit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Objet_a_vendre = c.String(),
                        Image = c.String(),
                        Categorie = c.String(),
                        Description = c.String(),
                        Prix = c.Double(nullable: false),
                        Code_a_barre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produits");
        }
    }
}
