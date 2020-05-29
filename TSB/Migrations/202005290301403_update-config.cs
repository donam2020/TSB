namespace TSB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateconfig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Configs", "Name", c => c.String());
            AddColumn("dbo.Configs", "Addres", c => c.String());
            DropColumn("dbo.Configs", "FooterInfo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Configs", "FooterInfo", c => c.String());
            DropColumn("dbo.Configs", "Addres");
            DropColumn("dbo.Configs", "Name");
        }
    }
}
