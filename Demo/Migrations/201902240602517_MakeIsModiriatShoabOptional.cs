namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeIsModiriatShoabOptional : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Setads", "IsModiriatShoab", c => c.Boolean());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Setads", "IsModiriatShoab", c => c.Boolean(nullable: false));
        }
    }
}
