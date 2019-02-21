namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeIdentityToFalseForIdInProvice : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Setads", "ProvinceId", "dbo.Provinces");
            DropPrimaryKey("dbo.Provinces");
            AlterColumn("dbo.Provinces", "Id", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Provinces", "Id");
            AddForeignKey("dbo.Setads", "ProvinceId", "dbo.Provinces", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Setads", "ProvinceId", "dbo.Provinces");
            DropPrimaryKey("dbo.Provinces");
            AlterColumn("dbo.Provinces", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Provinces", "Id");
            AddForeignKey("dbo.Setads", "ProvinceId", "dbo.Provinces", "Id");
        }
    }
}
