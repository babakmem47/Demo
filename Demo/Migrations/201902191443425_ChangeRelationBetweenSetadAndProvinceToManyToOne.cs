namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeRelationBetweenSetadAndProvinceToManyToOne : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Provinces", "Id", "dbo.Setads");
            DropIndex("dbo.Provinces", new[] { "Id" });
            CreateIndex("dbo.Setads", "ProvinceId");
            AddForeignKey("dbo.Setads", "ProvinceId", "dbo.Provinces", "Id");
            DropColumn("dbo.Provinces", "SetadId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Provinces", "SetadId", c => c.Int());
            DropForeignKey("dbo.Setads", "ProvinceId", "dbo.Provinces");
            DropIndex("dbo.Setads", new[] { "ProvinceId" });
            CreateIndex("dbo.Provinces", "Id");
            AddForeignKey("dbo.Provinces", "Id", "dbo.Setads", "Id");
        }
    }
}
