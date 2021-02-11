namespace AirBnB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateAvailableTypeToBool : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hosts", "available", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hosts", "available", c => c.String());
        }
    }
}
