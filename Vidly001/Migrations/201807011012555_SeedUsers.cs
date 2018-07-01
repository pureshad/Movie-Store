namespace Vidly001.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'75065327-4814-4e04-a285-7e28e4efd6e9', N'guest@vidly.com', 0, N'AM/RQUw8OqRof8GOy9ryMF7boUh/QCffihwrXYlrINP1MgBoTVDMqn+PHhL0cgsA2g==', N'fb61c41a-1ae9-4ee2-a906-e800762ab65f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7b1e726d-641f-4e02-8d5c-54fddc9e145a', N'admin@vidly.com', 0, N'ANaFQkYkFVFQgxUhdSv1sYvj/9oCC648PevlZGqQg8Gs7/cIepenh4aITjvtMsKvrQ==', N'e13738e8-8f80-4c03-8aac-aa50a3d960c3', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c04cb35d-b4e4-4128-8e48-e5b5fa2447a8', N'CanManageMovies')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7b1e726d-641f-4e02-8d5c-54fddc9e145a', N'c04cb35d-b4e4-4128-8e48-e5b5fa2447a8')
           ");
        }

        public override void Down()
        {
        }
    }
}
