namespace TSB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addmetatitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "Metatitle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Articles", "Metatitle");
        }
    }
}
