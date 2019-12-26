namespace Zelik.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3388a259-1c24-408e-b696-4cae7572e0ec', N'guest@zelik.com', 0, N'AD/QkJtFneTf9yW2g5cO+VjI6r7yfLUcOF1FzfS4J2b+IXKdLOKqpDUWFzYzqkXprw==', N'a4ad535d-8c72-44cf-b8dd-cde7333e59f2', NULL, 0, 0, NULL, 1, 0, N'guest@zelik.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ef48e196-4636-4f4d-847d-86ce41ffbfd0', N'admin2@zelik.com', 0, N'AKw8SPf/7l+WLLuZsVmWbK6ltoedkBwlUCiTlm9OrIJl0VE7T4SDcaE7Lqo8ICSo9g==', N'75b5ecc5-bf7a-4e50-bfa2-86e9eba53e16', NULL, 0, 0, NULL, 1, 0, N'admin2@zelik.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'8d3cc57e-1cf6-4f64-b554-c33b81eda9a7', N'CanManageMovies')
        
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ef48e196-4636-4f4d-847d-86ce41ffbfd0', N'8d3cc57e-1cf6-4f64-b554-c33b81eda9a7')


            ");
        }
        
        public override void Down()
        {
        }
    }
}
