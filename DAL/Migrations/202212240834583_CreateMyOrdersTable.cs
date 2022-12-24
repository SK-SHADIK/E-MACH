namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMyOrdersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OId = c.String(),
                        UName = c.String(),
                        TPrice = c.String(),
                        PayType = c.String(),
                        OStatus = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MyOrders");
        }
    }
}
