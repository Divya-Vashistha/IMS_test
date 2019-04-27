namespace IMS_New.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InterviewModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Interviews",
                c => new
                    {
                        interviewID = c.Int(nullable: false, identity: true),
                        interviewGuid = c.Guid(nullable: false),
                        startDate = c.DateTime(nullable: false),
                        endDate = c.DateTime(nullable: false),
                        startTime = c.DateTime(nullable: false),
                        endTime = c.DateTime(nullable: false),
                        slotId = c.Int(nullable: false),
                        panelId = c.String(),
                        panelType = c.String(),
                    })
                .PrimaryKey(t => t.interviewID)
                .ForeignKey("dbo.Slots", t => t.slotId, cascadeDelete: true)
                .Index(t => t.slotId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Interviews", "slotId", "dbo.Slots");
            DropIndex("dbo.Interviews", new[] { "slotId" });
            DropTable("dbo.Interviews");
        }
    }
}
