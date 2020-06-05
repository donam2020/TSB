namespace TSB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Configs", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Configs", "Status", c => c.Boolean(nullable: false));
        }
    }
}
