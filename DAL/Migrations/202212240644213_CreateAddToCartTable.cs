namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateAddToCartTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddToCarts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PId = c.Int(nullable: false),
                        PQty = c.Int(nullable: false),
                        Tprice = c.String(),
                        UName = c.String(),
                        PName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AddToCarts");
        }
    }
}
