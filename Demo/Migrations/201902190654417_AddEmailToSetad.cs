namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailToSetad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Setads", "Email", c => c.String(maxLength: 30));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Setads", "Email");
        }
    }
}
