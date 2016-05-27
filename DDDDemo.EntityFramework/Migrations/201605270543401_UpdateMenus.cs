namespace DDDDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMenus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "Level", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menus", "Level");
        }
    }
}
