namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_dasd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Iletisims",
                c => new
                    {
                        IletisimID = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Telefon = c.String(),
                        Mail = c.String(),
                        FaceURL = c.String(),
                        TwitterURL = c.String(),
                        InsagramURL = c.String(),
                        MailURL = c.String(),
                        LinkedinURL = c.String(),
                    })
                .PrimaryKey(t => t.IletisimID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Iletisims");
        }
    }
}
