namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2b0bc32f-0975-4dc2-b885-ccb401c3446e', N'guest@vidly.com', 0, N'AOcN1EAQ/9B6Ay8FA4D95YwC3IWLOms2Q2WRzljHSMB27a/JGxRFuYjNTzNV+WWQkw==', N'7e4c818f-4231-44e3-a199-101b37aa97af', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f384e53c-ce27-4bbb-a849-9a8c8a98c4c7', N'admin@vidly.com', 0, N'AEnBn3/lCDtTPO03Z8ovVsv+mXJrYQICTLNC6sm1pb2gX5yQEEcsbdE2daHzkXnOPw==', N'4a786990-3c13-4bde-abc8-c8264e66a242', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'53d92c36-75b7-456b-92c5-10b50170a937', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'f384e53c-ce27-4bbb-a849-9a8c8a98c4c7', N'53d92c36-75b7-456b-92c5-10b50170a937')

");
        }
        
        public override void Down()
        {
        }
    }
}
