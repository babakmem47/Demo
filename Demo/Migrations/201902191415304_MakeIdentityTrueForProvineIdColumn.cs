namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeIdentityTrueForProvineIdColumn : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Provinces", new[] { "Id" });
            DropPrimaryKey("dbo.Provinces");
            AlterColumn("dbo.Provinces", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Provinces", "Id");
            CreateIndex("dbo.Provinces", "Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Provinces", new[] { "Id" });
            DropPrimaryKey("dbo.Provinces");
            AlterColumn("dbo.Provinces", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Provinces", "Id");
            CreateIndex("dbo.Provinces", "Id");
        }
    }
}
