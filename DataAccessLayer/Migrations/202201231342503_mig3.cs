namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryDescription", c => c.String(maxLength: 1000));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "CategoryDescription");
        }
    }
}
