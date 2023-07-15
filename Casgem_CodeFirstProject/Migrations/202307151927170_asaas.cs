namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asaas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryURL = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        GalleryID = c.Int(nullable: false, identity: true),
                        GalleryURL = c.String(),
                    })
                .PrimaryKey(t => t.GalleryID);
            
            CreateTable(
                "dbo.Travels",
                c => new
                    {
                        TravelID = c.Int(nullable: false, identity: true),
                        TravelCategory = c.String(),
                    })
                .PrimaryKey(t => t.TravelID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Travels");
            DropTable("dbo.Galleries");
            DropTable("dbo.Categories");
        }
    }
}
