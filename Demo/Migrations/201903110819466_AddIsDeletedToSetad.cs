namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsDeletedToSetad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Setads", "IsDeleted", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Setads", "IsDeleted");
        }
    }
}
