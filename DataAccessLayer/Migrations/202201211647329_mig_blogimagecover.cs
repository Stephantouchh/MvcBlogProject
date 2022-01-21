namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_blogimagecover : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "BlogImageCover", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "BlogImageCover");
        }
    }
}
