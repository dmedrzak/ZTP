namespace ZTP.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserSettingsVirtualWallerModelsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Settings",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        Password = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        isRemember = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VirtualWallets",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        PaidMoney = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ActualAccountBalance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Settings", "Id", "dbo.Users");
            DropForeignKey("dbo.VirtualWallets", "Id", "dbo.Users");
            DropIndex("dbo.VirtualWallets", new[] { "Id" });
            DropIndex("dbo.Settings", new[] { "Id" });
            DropTable("dbo.VirtualWallets");
            DropTable("dbo.Users");
            DropTable("dbo.Settings");
        }
    }
}
