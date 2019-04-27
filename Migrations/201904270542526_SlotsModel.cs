namespace IMS_New.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SlotsModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Slots",
                c => new
                    {
                        slotId = c.Int(nullable: false, identity: true),
                        startDate = c.DateTime(nullable: false),
                        endDate = c.DateTime(nullable: false),
                        startTime = c.DateTime(nullable: false),
                        endTime = c.DateTime(nullable: false),
                        isRecurring = c.Boolean(nullable: false),
                        recurringType = c.String(),
                        dayOfWeek = c.String(),
                        panelId = c.String(),
                    })
                .PrimaryKey(t => t.slotId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Slots");
        }
    }
}
