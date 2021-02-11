namespace AirBnB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateroomtype : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Hosts", "hostRoomType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Hosts", "hostRoomType", c => c.String());
        }
    }
}
