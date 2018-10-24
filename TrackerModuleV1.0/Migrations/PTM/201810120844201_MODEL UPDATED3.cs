namespace TrackerModuleV1._0.Migrations.PTM
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MODELUPDATED3 : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.PartLevel", name: "Part_PartId", newName: "PartId");
            RenameColumn(table: "dbo.PartLevel", name: "Level_levelId", newName: "levelId");
            RenameIndex(table: "dbo.PartLevel", name: "IX_Part_PartId", newName: "IX_PartId");
            RenameIndex(table: "dbo.PartLevel", name: "IX_Level_levelId", newName: "IX_levelId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.PartLevel", name: "IX_levelId", newName: "IX_Level_levelId");
            RenameIndex(table: "dbo.PartLevel", name: "IX_PartId", newName: "IX_Part_PartId");
            RenameColumn(table: "dbo.PartLevel", name: "levelId", newName: "Level_levelId");
            RenameColumn(table: "dbo.PartLevel", name: "PartId", newName: "Part_PartId");
        }
    }
}
