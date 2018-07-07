namespace PakTech.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class iitial : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Courses", "imageUrl", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Courses", "imageUrl", c => c.String(nullable: false));
        }
    }
}
