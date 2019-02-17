namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIpRangeAndSetadClassWithFluentApi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IpRanges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Range = c.String(nullable: false, maxLength: 15),
                        Mask = c.String(nullable: false, maxLength: 2, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Range, unique: true);
            
            CreateTable(
                "dbo.Setads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Shakhes = c.String(maxLength: 4, fixedLength: true),
                        IsModiriatShoab = c.Boolean(nullable: false),
                        Address = c.String(maxLength: 200),
                        IpRangeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IpRanges", t => t.IpRangeId)
                .Index(t => t.IpRangeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Setads", "IpRangeId", "dbo.IpRanges");
            DropIndex("dbo.Setads", new[] { "IpRangeId" });
            DropIndex("dbo.IpRanges", new[] { "Range" });
            DropTable("dbo.Setads");
            DropTable("dbo.IpRanges");
        }
    }
}
