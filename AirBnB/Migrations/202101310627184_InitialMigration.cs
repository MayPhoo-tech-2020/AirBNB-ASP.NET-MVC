namespace AirBnB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        customerId = c.Int(nullable: false, identity: true),
                        customerName = c.String(),
                    })
                .PrimaryKey(t => t.customerId);
            
            CreateTable(
                "dbo.Hosts",
                c => new
                    {
                        hostId = c.Int(nullable: false, identity: true),
                        hostName = c.String(),
                        hostRoomType = c.String(),
                        price = c.String(),
                        available = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.hostId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Hosts");
            DropTable("dbo.Customers");
        }
    }
}
