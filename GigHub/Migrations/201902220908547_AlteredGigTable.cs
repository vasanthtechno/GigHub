namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteredGigTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Gigs", "DateTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.Gigs", "Date");
            DropColumn("dbo.Gigs", "Time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Gigs", "Time", c => c.String(nullable: false));
            AddColumn("dbo.Gigs", "Date", c => c.String(nullable: false));
            DropColumn("dbo.Gigs", "DateTime");
        }
    }
}
