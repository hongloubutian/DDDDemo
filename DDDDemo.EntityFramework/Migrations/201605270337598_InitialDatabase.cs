namespace DDDDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MenuCode = c.String(),
                        MenuName = c.String(),
                        MenuUrl = c.String(),
                        PID = c.String(),
                        Order = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RoleMenus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Menus_Id = c.Int(),
                        Roles_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Menus", t => t.Menus_Id)
                .ForeignKey("dbo.Roles", t => t.Roles_Id)
                .Index(t => t.Menus_Id)
                .Index(t => t.Roles_Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoleName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UserRoles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Roles_Id = c.Int(),
                        Users_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.Roles_Id)
                .ForeignKey("dbo.Users", t => t.Users_Id)
                .Index(t => t.Roles_Id)
                .Index(t => t.Users_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserPwd = c.String(),
                        Sex = c.Int(nullable: false),
                        Email = c.String(),
                        IsEmailConfirmed = c.String(),
                        LastLoginDate = c.DateTime(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserRoles", "Users_Id", "dbo.Users");
            DropForeignKey("dbo.UserRoles", "Roles_Id", "dbo.Roles");
            DropForeignKey("dbo.RoleMenus", "Roles_Id", "dbo.Roles");
            DropForeignKey("dbo.RoleMenus", "Menus_Id", "dbo.Menus");
            DropIndex("dbo.UserRoles", new[] { "Users_Id" });
            DropIndex("dbo.UserRoles", new[] { "Roles_Id" });
            DropIndex("dbo.RoleMenus", new[] { "Roles_Id" });
            DropIndex("dbo.RoleMenus", new[] { "Menus_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.UserRoles");
            DropTable("dbo.Roles");
            DropTable("dbo.RoleMenus");
            DropTable("dbo.Menus");
        }
    }
}
