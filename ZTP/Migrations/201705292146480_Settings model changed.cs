namespace ZTP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Settingsmodelchanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Settings", "UpdateEveryMin", c => c.Int(nullable: false));
            AddColumn("dbo.Settings", "isUpdateEveryOn", c => c.Boolean(nullable: false));
            AddColumn("dbo.Settings", "SoundWhenActionWasSold", c => c.Boolean(nullable: false));
            AddColumn("dbo.Settings", "SoundWhenActionWasBought", c => c.Boolean(nullable: false));
            AddColumn("dbo.Settings", "SoundWhenPercentageWasChanged", c => c.Boolean(nullable: false));
            AddColumn("dbo.Settings", "SoundWhenEmailWasSend", c => c.Boolean(nullable: false));
            AddColumn("dbo.Settings", "SummaryReport", c => c.Boolean(nullable: false));
            AddColumn("dbo.Settings", "SingleReporsts", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Settings", "SingleReporsts");
            DropColumn("dbo.Settings", "SummaryReport");
            DropColumn("dbo.Settings", "SoundWhenEmailWasSend");
            DropColumn("dbo.Settings", "SoundWhenPercentageWasChanged");
            DropColumn("dbo.Settings", "SoundWhenActionWasBought");
            DropColumn("dbo.Settings", "SoundWhenActionWasSold");
            DropColumn("dbo.Settings", "isUpdateEveryOn");
            DropColumn("dbo.Settings", "UpdateEveryMin");
        }
    }
}
