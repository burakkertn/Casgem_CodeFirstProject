namespace Casgem_CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdsadasdsa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "AboutResim", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "AboutResim");
        }
    }
}
