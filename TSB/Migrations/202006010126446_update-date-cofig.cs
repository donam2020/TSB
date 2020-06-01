namespace TSB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatecofig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Configs", "CreateDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Configs", "CreateBy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Configs", "CreateBy");
            DropColumn("dbo.Configs", "CreateDate");
        }
    }
}
