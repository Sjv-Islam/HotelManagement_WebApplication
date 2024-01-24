namespace HotelManagement_WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class second : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guests", "LoyaltyMember", c => c.Boolean(nullable: false));
            AddColumn("dbo.Guests", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Guests", "ImageUrl");
            DropColumn("dbo.Guests", "LoyaltyMember");
        }
    }
}
