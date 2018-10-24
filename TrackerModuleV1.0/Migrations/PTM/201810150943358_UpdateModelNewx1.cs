namespace TrackerModuleV1._0.Migrations.PTM
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModelNewx1 : DbMigration
    {
        public override void Up()
        {
            //RenameTable(name: "dbo.PartProject", newName: "ProjectPart");
            //RenameColumn(table: "dbo.PartLevel", name: "PartId", newName: "Part_PartId");
            //RenameColumn(table: "dbo.PartLevel", name: "levelId", newName: "Level_levelId");
            //RenameColumn(table: "dbo.ProjectPart", name: "ProjectId", newName: "Project_ProjectId");
            //RenameColumn(table: "dbo.ProjectPart", name: "PartId", newName: "Part_PartId");
            //RenameColumn(table: "dbo.ProjectUser", name: "UserId", newName: "User_UserId");
            //RenameColumn(table: "dbo.ProjectUser", name: "ProjectId", newName: "Project_ProjectId");
            //RenameIndex(table: "dbo.ProjectPart", name: "IX_ProjectId", newName: "IX_Project_ProjectId");
            //RenameIndex(table: "dbo.ProjectPart", name: "IX_PartId", newName: "IX_Part_PartId");
            //RenameIndex(table: "dbo.ProjectUser", name: "IX_UserId", newName: "IX_User_UserId");
            //RenameIndex(table: "dbo.ProjectUser", name: "IX_ProjectId", newName: "IX_Project_ProjectId");
            //RenameIndex(table: "dbo.PartLevel", name: "IX_PartId", newName: "IX_Part_PartId");
            //RenameIndex(table: "dbo.PartLevel", name: "IX_levelId", newName: "IX_Level_levelId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.PartLevel", name: "IX_Level_levelId", newName: "IX_levelId");
            RenameIndex(table: "dbo.PartLevel", name: "IX_Part_PartId", newName: "IX_PartId");
            RenameIndex(table: "dbo.ProjectUser", name: "IX_Project_ProjectId", newName: "IX_ProjectId");
            RenameIndex(table: "dbo.ProjectUser", name: "IX_User_UserId", newName: "IX_UserId");
            RenameIndex(table: "dbo.ProjectPart", name: "IX_Part_PartId", newName: "IX_PartId");
            RenameIndex(table: "dbo.ProjectPart", name: "IX_Project_ProjectId", newName: "IX_ProjectId");
            RenameColumn(table: "dbo.ProjectUser", name: "Project_ProjectId", newName: "ProjectId");
            RenameColumn(table: "dbo.ProjectUser", name: "User_UserId", newName: "UserId");
            RenameColumn(table: "dbo.ProjectPart", name: "Part_PartId", newName: "PartId");
            RenameColumn(table: "dbo.ProjectPart", name: "Project_ProjectId", newName: "ProjectId");
            RenameColumn(table: "dbo.PartLevel", name: "Level_levelId", newName: "levelId");
            RenameColumn(table: "dbo.PartLevel", name: "Part_PartId", newName: "PartId");
            RenameTable(name: "dbo.ProjectPart", newName: "PartProject");
        }
    }
}
