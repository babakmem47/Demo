namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProvinceClassWithFluentApi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        ProvinceName = c.String(nullable: false, maxLength: 25),
                        Octet3 = c.Byte(),
                        CityCenter = c.String(nullable: false, maxLength: 25),
                        PreTelCode = c.String(maxLength: 4),
                        SetadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Setads", t => t.Id)
                .Index(t => t.Id);
            
            AddColumn("dbo.Setads", "ProvinceId", c => c.Int());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Provinces", "Id", "dbo.Setads");
            DropIndex("dbo.Provinces", new[] { "Id" });
            DropColumn("dbo.Setads", "ProvinceId");
            DropTable("dbo.Provinces");
        }
    }
}
