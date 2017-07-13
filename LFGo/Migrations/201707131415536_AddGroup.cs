namespace LFGo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGroup : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "LogoUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "LogoUrl");
        }
    }
}
