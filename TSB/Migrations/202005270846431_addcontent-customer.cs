namespace TSB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcontentcustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Content", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
            DropColumn("dbo.Customers", "Content");
        }
    }
}
