namespace Solution.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cloud : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Publicité",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Titre = c.String(),
                        Image = c.String(),
                        Description = c.String(),
                        Prix_initial = c.Double(nullable: false),
                        Prix_promotion = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Publicité");
        }
    }
}
