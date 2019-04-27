namespace IMS_New.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SlotExceptionModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SlotExceptions",
                c => new
                    {
                        slotExceptionId = c.Int(nullable: false, identity: true),
                        slotId = c.Int(nullable: false),
                        startDate = c.DateTime(nullable: false),
                        endDate = c.DateTime(nullable: false),
                        startTime = c.DateTime(nullable: false),
                        endTime = c.DateTime(nullable: false),
                        status = c.String(),
                    })
                .PrimaryKey(t => t.slotExceptionId)
                .ForeignKey("dbo.Slots", t => t.slotId, cascadeDelete: true)
                .Index(t => t.slotId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SlotExceptions", "slotId", "dbo.Slots");
            DropIndex("dbo.SlotExceptions", new[] { "slotId" });
            DropTable("dbo.SlotExceptions");
        }
    }
}
