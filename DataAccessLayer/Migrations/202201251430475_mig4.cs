namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "AuthorTitle", c => c.String(maxLength: 50));
            AddColumn("dbo.Authors", "AuthorShort", c => c.String(maxLength: 100));
            AddColumn("dbo.Authors", "Mail", c => c.String(maxLength: 50));
            AddColumn("dbo.Authors", "Password", c => c.String(maxLength: 50));
            AddColumn("dbo.Authors", "PhoneNumber", c => c.String(maxLength: 20));
            AddColumn("dbo.Authors", "Status", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "Status");
            DropColumn("dbo.Authors", "PhoneNumber");
            DropColumn("dbo.Authors", "Password");
            DropColumn("dbo.Authors", "Mail");
            DropColumn("dbo.Authors", "AuthorShort");
            DropColumn("dbo.Authors", "AuthorTitle");
        }
    }
}
