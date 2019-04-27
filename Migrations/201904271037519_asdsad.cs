namespace IMS_New.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class asdsad : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Interviews", "start", c => c.DateTime(nullable: false));
            AddColumn("dbo.Interviews", "end", c => c.DateTime(nullable: false));
            AddColumn("dbo.Slots", "start", c => c.DateTime(nullable: false));
            AddColumn("dbo.Slots", "end", c => c.DateTime(nullable: false));
            AddColumn("dbo.SlotExceptions", "start", c => c.DateTime(nullable: false));
            AddColumn("dbo.SlotExceptions", "end", c => c.DateTime(nullable: false));
            DropColumn("dbo.Interviews", "startDate");
            DropColumn("dbo.Interviews", "endDate");
            DropColumn("dbo.Interviews", "startTime");
            DropColumn("dbo.Interviews", "endTime");
            DropColumn("dbo.Slots", "startDate");
            DropColumn("dbo.Slots", "endDate");
            DropColumn("dbo.Slots", "startTime");
            DropColumn("dbo.Slots", "endTime");
            DropColumn("dbo.SlotExceptions", "startDate");
            DropColumn("dbo.SlotExceptions", "endDate");
            DropColumn("dbo.SlotExceptions", "startTime");
            DropColumn("dbo.SlotExceptions", "endTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SlotExceptions", "endTime", c => c.Time(nullable: false, precision: 7));
            AddColumn("dbo.SlotExceptions", "startTime", c => c.Time(nullable: false, precision: 7));
            AddColumn("dbo.SlotExceptions", "endDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.SlotExceptions", "startDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Slots", "endTime", c => c.Time(nullable: false, precision: 7));
            AddColumn("dbo.Slots", "startTime", c => c.Time(nullable: false, precision: 7));
            AddColumn("dbo.Slots", "endDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Slots", "startDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Interviews", "endTime", c => c.Time(nullable: false, precision: 7));
            AddColumn("dbo.Interviews", "startTime", c => c.Time(nullable: false, precision: 7));
            AddColumn("dbo.Interviews", "endDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Interviews", "startDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.SlotExceptions", "end");
            DropColumn("dbo.SlotExceptions", "start");
            DropColumn("dbo.Slots", "end");
            DropColumn("dbo.Slots", "start");
            DropColumn("dbo.Interviews", "end");
            DropColumn("dbo.Interviews", "start");
        }
    }
}
