namespace TSB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class droprowimagecontact : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "CompanyName", c => c.String());
            AlterColumn("dbo.Contacts", "Email", c => c.String(nullable: false));
            DropColumn("dbo.Contacts", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "Image", c => c.String());
            AlterColumn("dbo.Contacts", "Email", c => c.String());
            DropColumn("dbo.Contacts", "CompanyName");
        }
    }
}
