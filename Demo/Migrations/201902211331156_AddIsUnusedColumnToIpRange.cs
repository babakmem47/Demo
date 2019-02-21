namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsUnusedColumnToIpRange : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.IpRanges", "IsUnused", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.IpRanges", "IsUnused");
        }
    }
}
