namespace Zelik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDrivingLiecenseToApplictionUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "DrivingLiecense", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "DrivingLiecense");
        }
    }
}
