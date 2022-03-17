namespace ThiWAD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CateName = c.String(),
                        Description = c.String(),
                        Picture = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        QuantityPerUnit = c.Int(nullable: false),
                        SupplierID = c.Int(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        UnitslnStock = c.String(),
                        UnitOnOrder = c.String(),
                        ReorderLevel = c.String(),
                        Discontinued = c.String(),
                        category_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.category_ID)
                .Index(t => t.category_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "category_ID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "category_ID" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
