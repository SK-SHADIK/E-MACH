namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTokensTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tokens", "UserType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tokens", "UserType");
        }
    }
}
