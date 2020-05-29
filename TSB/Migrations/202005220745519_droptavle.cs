namespace TSB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class droptavle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "Name", c => c.String(nullable: false));
            AddColumn("dbo.Articles", "Sumary", c => c.String());
            AddColumn("dbo.Articles", "CategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Articles", "CountView", c => c.Int(nullable: false));
            CreateIndex("dbo.Articles", "CategoryId");
            AddForeignKey("dbo.Articles", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
            DropTable("dbo.Products");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Title = c.String(),
                        Sumary = c.String(),
                        Content = c.String(),
                        Image = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CreateBy = c.String(),
                        CategoryId = c.Int(nullable: false),
                        ShowHome = c.Boolean(nullable: false),
                        CountView = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            DropForeignKey("dbo.Articles", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Articles", new[] { "CategoryId" });
            DropColumn("dbo.Articles", "CountView");
            DropColumn("dbo.Articles", "CategoryId");
            DropColumn("dbo.Articles", "Sumary");
            DropColumn("dbo.Articles", "Name");
        }
    }
}
