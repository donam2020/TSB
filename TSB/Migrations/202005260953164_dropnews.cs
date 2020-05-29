namespace TSB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropnews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Image", c => c.String());
            DropTable("dbo.News");
        }
        
        public override void Down()
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
            
            DropColumn("dbo.Customers", "Image");
        }
    }
}
