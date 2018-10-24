namespace TrackerModuleV1._0.Migrations.PTM
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSuppliertable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Supplier",
                c => new
                    {
                        SupplierId = c.String(nullable: false, maxLength: 128),
                        SupplierName = c.String(),
                        Address = c.String(),
                        ContactNo = c.String(),
                    })
                .PrimaryKey(t => t.SupplierId);
            
            CreateTable(
                "dbo.SupplierPart",
                c => new
                    {
                        Supplier_SupplierId = c.String(nullable: false, maxLength: 128),
                        Part_PartId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Supplier_SupplierId, t.Part_PartId })
                .ForeignKey("dbo.Supplier", t => t.Supplier_SupplierId, cascadeDelete: true)
                .ForeignKey("dbo.Part", t => t.Part_PartId, cascadeDelete: true)
                .Index(t => t.Supplier_SupplierId)
                .Index(t => t.Part_PartId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SupplierPart", "Part_PartId", "dbo.Part");
            DropForeignKey("dbo.SupplierPart", "Supplier_SupplierId", "dbo.Supplier");
            DropIndex("dbo.SupplierPart", new[] { "Part_PartId" });
            DropIndex("dbo.SupplierPart", new[] { "Supplier_SupplierId" });
            DropTable("dbo.SupplierPart");
            DropTable("dbo.Supplier");
        }
    }
}
