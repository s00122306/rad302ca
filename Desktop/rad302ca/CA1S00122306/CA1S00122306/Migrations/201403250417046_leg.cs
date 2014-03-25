namespace CA1S00122306.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class leg : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Guests", "Leg_Id", c => c.Int());
            CreateIndex("dbo.Guests", "Leg_Id");
            CreateIndex("dbo.Legs", "TripId");
            AddForeignKey("dbo.Guests", "Leg_Id", "dbo.Legs", "Id");
            AddForeignKey("dbo.Legs", "TripId", "dbo.Trips", "TripId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Legs", "TripId", "dbo.Trips");
            DropForeignKey("dbo.Guests", "Leg_Id", "dbo.Legs");
            DropIndex("dbo.Legs", new[] { "TripId" });
            DropIndex("dbo.Guests", new[] { "Leg_Id" });
            DropColumn("dbo.Guests", "Leg_Id");
        }
    }
}
