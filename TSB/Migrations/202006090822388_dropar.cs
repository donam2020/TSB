namespace TSB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Metatitle", c => c.String());
            DropColumn("dbo.Articles", "Metatitle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Articles", "Metatitle", c => c.String());
            DropColumn("dbo.Categories", "Metatitle");
        }
    }
}
