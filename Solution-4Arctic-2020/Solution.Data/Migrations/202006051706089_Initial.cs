namespace Solution.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false),
                        ProductCode = c.String(),
                        Barcode = c.String(),
                        Description = c.String(),
                        ProductImageUrl = c.String(),
                        DefaultBuyingPrice = c.Double(nullable: false),
                        DefaultSellingPrice = c.Double(nullable: false),
                        StockId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Stocks", t => t.StockId)
                .Index(t => t.StockId);
            
            CreateTable(
                "dbo.Stocks",
                c => new
                    {
                        StockId = c.Int(nullable: false, identity: true),
                        DateAjout = c.DateTime(nullable: false),
                        Barcode = c.String(),
                    })
                .PrimaryKey(t => t.StockId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "StockId", "dbo.Stocks");
            DropIndex("dbo.Products", new[] { "StockId" });
            DropTable("dbo.Stocks");
            DropTable("dbo.Products");
        }
    }
}
