namespace AirBnB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHostRoomType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Hosts", "hostRoomType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Hosts", "hostRoomType");
        }
    }
}
