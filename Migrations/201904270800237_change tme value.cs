namespace IMS_New.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changetmevalue : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Interviews", "startTime", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Interviews", "endTime", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Slots", "startTime", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.Slots", "endTime", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.SlotExceptions", "startTime", c => c.Time(nullable: false, precision: 7));
            AlterColumn("dbo.SlotExceptions", "endTime", c => c.Time(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SlotExceptions", "endTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SlotExceptions", "startTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Slots", "endTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Slots", "startTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Interviews", "endTime", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Interviews", "startTime", c => c.DateTime(nullable: false));
        }
    }
}
