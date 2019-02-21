namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveOctet3FromProvince : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Provinces", "Octet3");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Provinces", "Octet3", c => c.Byte());
        }
    }
}
