namespace CA1S00122306.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        GuestID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                    })
                .PrimaryKey(t => t.GuestID);
            
            CreateTable(
                "dbo.Legs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartLocation = c.String(),
                        EndLocation = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        TripId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trips",
                c => new
                    {
                        TripId = c.Int(nullable: false, identity: true),
                        TripName = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Viable = c.Boolean(nullable: false),
                        Complete = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.TripId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trips");
            DropTable("dbo.Legs");
            DropTable("dbo.Guests");
        }
    }
}
