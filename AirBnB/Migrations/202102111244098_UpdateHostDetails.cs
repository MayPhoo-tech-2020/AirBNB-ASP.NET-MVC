namespace AirBnB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateHostDetails : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hosts", "hostRoomType", c => c.String());
            AlterColumn("dbo.Hosts", "available", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hosts", "available", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Hosts", "hostRoomType", c => c.Int(nullable: false));
        }
    }
}
