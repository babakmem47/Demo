namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeSetadIdNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Provinces", "SetadId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Provinces", "SetadId", c => c.Int(nullable: false));
        }
    }
}
