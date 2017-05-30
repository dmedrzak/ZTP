namespace ZTP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SettingsModelchanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "NotificationAfterBought", c => c.Boolean(nullable: false));
            AddColumn("dbo.Settings", "NotificationAfterSold", c => c.Boolean(nullable: false));
            AddColumn("dbo.Settings", "NotificationAfterSendReport", c => c.Boolean(nullable: false));
            AddColumn("dbo.Settings", "NotificationAfterProvisionChanged", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Settings", "NotificationAfterProvisionChanged");
            DropColumn("dbo.Settings", "NotificationAfterSendReport");
            DropColumn("dbo.Settings", "NotificationAfterSold");
            DropColumn("dbo.Settings", "NotificationAfterBought");
        }
    }
}
