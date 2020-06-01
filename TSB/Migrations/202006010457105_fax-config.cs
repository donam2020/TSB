namespace TSB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class faxconfig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Configs", "Fax", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Configs", "Fax");
        }
    }
}
