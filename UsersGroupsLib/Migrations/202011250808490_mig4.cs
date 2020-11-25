namespace UsersGroupsLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Answers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        IsRight = c.Boolean(nullable: false),
                        QuestionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ApointTests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TestID = c.Int(nullable: false),
                        GroupID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ApointTests");
            DropTable("dbo.Answers");
        }
    }
}
