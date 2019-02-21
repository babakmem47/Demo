namespace Demo.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateIpRangeClassUsingSqlLoop : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    DECLARE @count AS INT = 1
                    DECLARE @last AS INT = 35
                    DECLARE @ip AS NVARCHAR

                    WHILE(@count <= @last)
                    BEGIN
                        INSERT INTO IpRanges([Range],[Mask])
                        VALUES('172.16.'  + CAST(@count AS VARCHAR) + '.0', '24')
                        SET @count += 1
                    END
            ");
        }

        public override void Down()
        {
        }
    }
}
