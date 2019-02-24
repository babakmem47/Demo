namespace Demo.Migrations
{
	using System.Data.Entity.Migrations;

	public partial class PopulateSetadWithModiriatShoabs : DbMigration
	{
		public override void Up()
		{
			Sql(@"
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N' غرب تهران (منطقه چهار)', 1, 1, 4)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'مرکزی تهران (منطقه دو)', 1, 2, 4)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'شرق تهران (منطقه سه)', 1, 3, 4)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'شمال تهران (منطقه یک)', 1, 4, 4)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'قم', 1, 5, 5)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'یزد', 1, 6, 6)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'اصفهان', 1, 7, 7)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'خراسان رضوی', 1, 8, 8)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'چهارمحال و بختیاری', 1, 9, 9)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'مازندران', 1, 10, 10)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'آذربایجان غربی', 1, 11, 11)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'اراک', 1, 12, 12)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'گلستان', 1, 13, 13)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'فارس', 1, 14, 14)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'آذربایجان شرقی', 1, 15, 15)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'اردبیل', 1, 16, 16)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'همدان', 1, 17, 17)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'کردستان', 1, 18, 18)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'بوشهر', 1, 19, 19)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'کرمانشاه', 1, 20, 20)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'ایلام', 1, 21, 21)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'سیستان و بلوچستان', 1, 22, 22)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'هرمزگان', 1, 23, 23)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'لرستان', 1, 24, 24)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'زنجان', 1, 25, 25)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'گیلان', 1, 26, 26)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'البرز', 1, 27, 27)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'خوزستان', 1, 28, 28)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'سمنان', 1, 29, 29)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'خراسان جنوبی', 1, 31, 31)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'کرمان', 1, 32, 32)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'قزوین', 1, 33, 33)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'خراسان شمالی', 1, 34, 34)
				INSERT [dbo].[Setads] ([Name], [IsModiriatShoab], [IpRangeId], [ProvinceId]) VALUES (N'کهکیلوئیه و بویراحمد', 1, 35, 35)
			");
		}

		public override void Down()
		{
		}
	}
}
