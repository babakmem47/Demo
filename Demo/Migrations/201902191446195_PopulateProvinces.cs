namespace Demo.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateProvinces : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'تهران', N'تهران', N'021', 0)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'قم', N'قم', N'025', 5)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'یزد', N'یزد', N'035', 6)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'اصفهان', N'اصفهان', N'031', 7)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'خراسان رضوی', N'مشهد', N'051', 8)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'چهارمحال و بختیاری', N'شهرکرد', N'038', 9)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'مازندران', N'ساری', N'011', 10)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'آذربایجان غربی', N'ارومیه', N'044', 11)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'اراک', N'اراک', N'086', 12)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'گلستان', N'گرگان', N'017', 13)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'فارس', N'شیراز', N'071', 14)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'آذربایجان شرقی', N'تبریز', N'041', 15)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'اردبیل', N'اردبیل', N'045', 16)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'همدان', N'همدان', N'081', 17)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'کردستان', N'سنندج', N'087', 18)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'بوشهر', N'بوشهر', N'077', 19)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'کرمانشاه', N'کرمانشاه', N'083', 20)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'ایلام', N'ایلام', N'0841', 21)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'سیستان و بلوچستان', N'زاهدان', N'054', 22)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'هرمزگان', N'بندرعباس', N'076', 23)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'لرستان', N'خرم آباد', N'066', 24)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'زنجان', N'زنجان', N'024', 25)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'گیلان', N'رشت', N'013', 26)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'البرز', N'کرج', N'026', 27)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'خوزستان', N'اهواز', N'061', 28)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'سمنان', N'سمنان', N'023', 29)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'خراسان جنوبی', N'بیرجند', N'056', 31)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'کرمان', N'کرمان', N'034', 32)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'قزوین', N'قزوین', N'028', 33)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'خراسان شمالی', N'بجنورد', N'058', 34)
INSERT [dbo].[Provinces] ([ProvinceName], [CityCenter], [PreTelCode], [Octet3]) VALUES (N'کهکیلوئیه و بویراحمد', N'یاسوج', N'074', 35)

            ");
        }

        public override void Down()
        {
        }
    }
}
