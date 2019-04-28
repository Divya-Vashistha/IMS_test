namespace IMS_New.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeInterview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Interviews", "isPrimaryPanel", c => c.Boolean(nullable: false));
            DropColumn("dbo.Interviews", "panelType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Interviews", "panelType", c => c.String());
            DropColumn("dbo.Interviews", "isPrimaryPanel");
        }
    }
}
