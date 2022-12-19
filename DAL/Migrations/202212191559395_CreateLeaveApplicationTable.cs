﻿namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateLeaveApplicationTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LeaveApplications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Reason = c.String(nullable: false),
                        From = c.DateTime(nullable: false),
                        Finish = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LeaveApplications");
        }
    }
}
