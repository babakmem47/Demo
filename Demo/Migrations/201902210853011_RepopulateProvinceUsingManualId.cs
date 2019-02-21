namespace Demo.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class RepopulateProvinceUsingManualId : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (4, N'تهران', N'تهران', N'021')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (5, N'قم', N'قم', N'025')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (6, N'یزد', N'یزد', N'035')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (7, N'اصفهان', N'اصفهان', N'031')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (8, N'خراسان رضوی', N'مشهد', N'051')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (9, N'چهارمحال و بختیاری', N'شهرکرد', N'038')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (10, N'مازندران', N'ساری', N'011')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (11, N'آذربایجان غربی', N'ارومیه', N'044')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (12, N'اراک', N'اراک', N'086')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (13, N'گلستان', N'گرگان', N'017')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (14, N'فارس', N'شیراز', N'071')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (15, N'آذربایجان شرقی', N'تبریز', N'041')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (16, N'اردبیل', N'اردبیل', N'045')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (17, N'همدان', N'همدان', N'081')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (18, N'کردستان', N'سنندج', N'087')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (19, N'بوشهر', N'بوشهر', N'077')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (20, N'کرمانشاه', N'کرمانشاه', N'083')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (21, N'ایلام', N'ایلام', N'0841')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (22, N'سیستان و بلوچستان', N'زاهدان', N'054')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (23, N'هرمزگان', N'بندرعباس', N'076')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (24, N'لرستان', N'خرم آباد', N'066')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (25, N'زنجان', N'زنجان', N'024')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (26, N'گیلان', N'رشت', N'013')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (27, N'البرز', N'کرج', N'026')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (28, N'خوزستان', N'اهواز', N'061')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (29, N'سمنان', N'سمنان', N'023')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (31, N'خراسان جنوبی', N'بیرجند', N'056')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (32, N'کرمان', N'کرمان', N'034')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (33, N'قزوین', N'قزوین', N'028')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (34, N'خراسان شمالی', N'بجنورد', N'058')
INSERT [dbo].[Provinces] ([Id], [ProvinceName], [CityCenter], [PreTelCode]) VALUES (35, N'کهکیلوئیه و بویراحمد', N'یاسوج', N'074')

            ");

        }

        public override void Down()
        {
        }
    }
}
