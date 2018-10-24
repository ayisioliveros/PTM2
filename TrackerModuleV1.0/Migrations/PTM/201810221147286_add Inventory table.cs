namespace TrackerModuleV1._0.Migrations.PTM
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addInventorytable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Inventory",
                c => new
                    {
                        InventoryId = c.String(nullable: false, maxLength: 128),
                        ShortDescription = c.String(),
                        MaterialType = c.String(),
                        StoreLocation = c.String(),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeliveryStatus = c.String(),
                        DeliveryDate = c.DateTime(nullable: false),
                        OpenOrderQnty = c.Int(nullable: false),
                        QntyInTransit = c.Int(nullable: false),
                        DeliveryLocation = c.String(),
                        DeliveryQnty = c.Int(nullable: false),
                        UoM = c.String(),
                        UsedQnty = c.Int(nullable: false),
                        LastUsedDate = c.DateTime(nullable: false),
                        Stock = c.Int(nullable: false),
                        SafetyStock = c.Int(nullable: false),
                        RackNo = c.Int(nullable: false),
                        LineNo = c.Int(nullable: false),
                        LastUser_UserId = c.String(maxLength: 128),
                        Part_PartId = c.String(maxLength: 128),
                        Project_ProjectId = c.String(maxLength: 128),
                        Supplier_SupplierId = c.String(maxLength: 128),
                        User_UserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.InventoryId)
                .ForeignKey("dbo.User", t => t.LastUser_UserId)
                .ForeignKey("dbo.Part", t => t.Part_PartId)
                .ForeignKey("dbo.Project", t => t.Project_ProjectId)
                .ForeignKey("dbo.Supplier", t => t.Supplier_SupplierId)
                .ForeignKey("dbo.User", t => t.User_UserId)
                .Index(t => t.LastUser_UserId)
                .Index(t => t.Part_PartId)
                .Index(t => t.Project_ProjectId)
                .Index(t => t.Supplier_SupplierId)
                .Index(t => t.User_UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Inventory", "User_UserId", "dbo.User");
            DropForeignKey("dbo.Inventory", "Supplier_SupplierId", "dbo.Supplier");
            DropForeignKey("dbo.Inventory", "Project_ProjectId", "dbo.Project");
            DropForeignKey("dbo.Inventory", "Part_PartId", "dbo.Part");
            DropForeignKey("dbo.Inventory", "LastUser_UserId", "dbo.User");
            DropIndex("dbo.Inventory", new[] { "User_UserId" });
            DropIndex("dbo.Inventory", new[] { "Supplier_SupplierId" });
            DropIndex("dbo.Inventory", new[] { "Project_ProjectId" });
            DropIndex("dbo.Inventory", new[] { "Part_PartId" });
            DropIndex("dbo.Inventory", new[] { "LastUser_UserId" });
            DropTable("dbo.Inventory");
        }
    }
}
