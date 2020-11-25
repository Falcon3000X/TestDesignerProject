namespace UsersGroupsLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.QuestionBlocks",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Question = c.String(),
                        TrueAnswer = c.String(),
                        DifficultLevel = c.Int(nullable: false),
                        Q1 = c.String(),
                        Q2 = c.String(),
                        Q3 = c.String(),
                        Test_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Tests", t => t.Test_ID, cascadeDelete: true)
                .Index(t => t.Test_ID);
            
            CreateTable(
                "dbo.Tests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        TestName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.QuestionBlocks", "Test_ID", "dbo.Tests");
            DropIndex("dbo.QuestionBlocks", new[] { "Test_ID" });
            DropTable("dbo.Tests");
            DropTable("dbo.QuestionBlocks");
        }
    }
}
