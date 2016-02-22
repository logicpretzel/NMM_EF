namespace NMM_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class address : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Breweries", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Breweries", "Address");
        }
    }
}
