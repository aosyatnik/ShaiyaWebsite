namespace ShaiyaWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsersRequiredFields : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Login", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.String());
            AlterColumn("dbo.Users", "Login", c => c.String());
        }
    }
}
