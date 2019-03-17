namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DateCreatedAndDateModifiedToIpRange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IpRanges", "DateCreated", c => c.DateTime(nullable: false));
            AddColumn("dbo.IpRanges", "DateModified", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.IpRanges", "DateModified");
            DropColumn("dbo.IpRanges", "DateCreated");
        }
    }
}
