namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateApplicationLeavesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationLeaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Reason = c.String(nullable: false),
                        Name = c.String(nullable: false),
                        From = c.DateTime(nullable: false),
                        To = c.DateTime(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {            
            DropTable("dbo.ApplicationLeaves");
        }
    }
}
