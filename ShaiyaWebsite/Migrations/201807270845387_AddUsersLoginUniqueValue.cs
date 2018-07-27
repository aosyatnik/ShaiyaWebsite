namespace ShaiyaWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsersLoginUniqueValue : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Users", "Login", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "Login" });
        }
    }
}
