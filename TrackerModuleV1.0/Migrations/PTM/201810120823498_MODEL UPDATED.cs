namespace TrackerModuleV1._0.Migrations.PTM
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MODELUPDATED : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PartLevel",
                c => new
                    {
                        Part_PartId = c.Int(nullable: false),
                        Level_levelId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Part_PartId, t.Level_levelId })
                .ForeignKey("dbo.Part", t => t.Part_PartId, cascadeDelete: true)
                .ForeignKey("dbo.Level", t => t.Level_levelId, cascadeDelete: true)
                .Index(t => t.Part_PartId)
                .Index(t => t.Level_levelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PartLevel", "Level_levelId", "dbo.Level");
            DropForeignKey("dbo.PartLevel", "Part_PartId", "dbo.Part");
            DropIndex("dbo.PartLevel", new[] { "Level_levelId" });
            DropIndex("dbo.PartLevel", new[] { "Part_PartId" });
            DropTable("dbo.PartLevel");
        }
    }
}
