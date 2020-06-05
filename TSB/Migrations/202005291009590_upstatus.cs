namespace TSB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upstatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Configs", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Configs", "Status");
        }
    }
}
