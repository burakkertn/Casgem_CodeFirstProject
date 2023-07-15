namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class miigAbout : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        AboutDes = c.String(),
                        AboutTitle = c.String(),
                    })
                .PrimaryKey(t => t.AboutID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Abouts");
        }
    }
}
