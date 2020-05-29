namespace TSB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.News",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        Title = c.String(nullable: false),
                        Image = c.String(),
                        ShowHome = c.Boolean(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Categories", "Image", c => c.String());
            AddColumn("dbo.Contacts", "Image", c => c.String());
            AddColumn("dbo.Contacts", "Addres", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "Addres");
            DropColumn("dbo.Contacts", "Image");
            DropColumn("dbo.Categories", "Image");
            DropTable("dbo.News");
        }
    }
}
