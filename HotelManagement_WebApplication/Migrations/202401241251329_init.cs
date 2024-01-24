namespace HotelManagement_WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GuestName = c.String(nullable: false, maxLength: 50),
                        Address = c.String(),
                        ContactNo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoomId = c.Int(nullable: false),
                        Check_In_Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Check_Out_Date = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        GuestID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .ForeignKey("dbo.Guests", t => t.GuestID, cascadeDelete: true)
                .Index(t => t.RoomId)
                .Index(t => t.GuestID);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        RoomId = c.Int(nullable: false, identity: true),
                        Room_Type = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.RoomId);
            
            CreateTable(
                "dbo.UserInfo",
                c => new
                    {
                        UserName = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                        Role = c.String(),
                    })
                .PrimaryKey(t => t.UserName);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "GuestID", "dbo.Guests");
            DropForeignKey("dbo.Reservations", "RoomId", "dbo.Rooms");
            DropIndex("dbo.Reservations", new[] { "GuestID" });
            DropIndex("dbo.Reservations", new[] { "RoomId" });
            DropTable("dbo.UserInfo");
            DropTable("dbo.Rooms");
            DropTable("dbo.Reservations");
            DropTable("dbo.Guests");
        }
    }
}
