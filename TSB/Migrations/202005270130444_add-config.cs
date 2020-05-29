namespace TSB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addconfig : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Configs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FooterInfo = c.String(),
                        InfoAbout = c.String(),
                        LinkFacebook = c.String(),
                        CategoryAbout = c.String(),
                        ImageAbout = c.String(),
                        ImageCategory = c.String(),
                        TitleHome = c.String(),
                        Description = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        LinkYoutube = c.String(),
                        LinkTwichter = c.String(),
                        LinkGoogle = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Configs");
        }
    }
}
