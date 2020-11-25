namespace UsersGroupsLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GroupName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        IsAdmin = c.Boolean(nullable: false),
                        Group_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Groups", t => t.Group_ID)
                .Index(t => t.Group_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Group_ID", "dbo.Groups");
            DropIndex("dbo.Users", new[] { "Group_ID" });
            DropTable("dbo.Users");
            DropTable("dbo.Groups");
        }
    }
}
