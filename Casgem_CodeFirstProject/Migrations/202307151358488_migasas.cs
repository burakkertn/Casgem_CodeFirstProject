namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migasas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureID = c.Int(nullable: false, identity: true),
                        FeatureDes = c.String(),
                        FeatureTitle = c.String(),
                        FeatureImage = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.FeatureID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Features");
        }
    }
}
