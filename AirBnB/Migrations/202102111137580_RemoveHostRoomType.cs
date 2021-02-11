namespace AirBnB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveHostRoomType : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Hosts", "hostRoomType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Hosts", "hostRoomType", c => c.String());
        }
    }
}
