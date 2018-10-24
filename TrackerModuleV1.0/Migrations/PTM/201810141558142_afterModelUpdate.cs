namespace TrackerModuleV1._0.Migrations.PTM
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class afterModelUpdate : DbMigration
    {
        public override void Up()
        {
           // RenameTable(name: "dbo.ProjectPart", newName: "PartProject");
           // RenameTable(name: "dbo.ProjectUser", newName: "UserIdProjectId");
           // DropForeignKey("dbo.Level", "projectId", "dbo.Project");
           // DropForeignKey("dbo.Part", "CreatedBy_UserId", "dbo.User");
           // DropForeignKey("dbo.Part", "User_UserId", "dbo.User");
           // DropIndex("dbo.Level", new[] { "projectId" });
           // DropIndex("dbo.Part", new[] { "User_UserId" });
           // DropIndex("dbo.Part", new[] { "CreatedBy_UserId" });
           // DropColumn("dbo.Part", "CreatedUserId");
           // //DropColumn("dbo.Part", "CreatedUserId");
           // RenameColumn(table: "dbo.PartLevel", name: "Part_PartId", newName: "PartId");
           // RenameColumn(table: "dbo.PartLevel", name: "Level_levelId", newName: "levelId");
           // RenameColumn(table: "dbo.Part", name: "CreatedBy_UserId", newName: "CreatedUserId");
           // RenameColumn(table: "dbo.PartProject", name: "Project_ProjectId", newName: "ProjectId");
           // RenameColumn(table: "dbo.PartProject", name: "Part_PartId", newName: "PartId");
           // RenameColumn(table: "dbo.Part", name: "User_UserId", newName: "CreatedUserId");
           // RenameColumn(table: "dbo.UserIdProjectId", name: "Project_ProjectId", newName: "ProjectId");
           // RenameColumn(table: "dbo.UserIdProjectId", name: "User_UserId", newName: "UserId");
           // RenameIndex(table: "dbo.PartProject", name: "IX_Project_ProjectId", newName: "IX_ProjectId");
           // RenameIndex(table: "dbo.PartProject", name: "IX_Part_PartId", newName: "IX_PartId");
           // RenameIndex(table: "dbo.UserIdProjectId", name: "IX_User_UserId", newName: "IX_UserId");
           // RenameIndex(table: "dbo.UserIdProjectId", name: "IX_Project_ProjectId", newName: "IX_ProjectId");
           // RenameIndex(table: "dbo.PartLevel", name: "IX_Part_PartId", newName: "IX_PartId");
           // RenameIndex(table: "dbo.PartLevel", name: "IX_Level_levelId", newName: "IX_levelId");
           // DropPrimaryKey("dbo.UserIdProjectId");
           // AlterColumn("dbo.Level", "projectId", c => c.String(nullable: false, maxLength: 128));
           //// AlterColumn("dbo.Part", "CreatedUserId", c => c.String(nullable: false, maxLength: 128));
           // //AlterColumn("dbo.Part", "CreatedUserId", c => c.String(nullable: false, maxLength: 128));
           // //AlterColumn("dbo.Part", "CreatedUserId", c => c.String(nullable: false, maxLength: 128));
           // AddPrimaryKey("dbo.UserIdProjectId", new[] { "UserId", "ProjectId" });
           // CreateIndex("dbo.Level", "projectId");
           // //CreateIndex("dbo.Part", "CreatedUserId");
           // AddForeignKey("dbo.Level", "projectId", "dbo.Project", "ProjectId", cascadeDelete: true);
           // AddForeignKey("dbo.Part", "CreatedUserId", "dbo.User", "UserId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Part", "CreatedUserId", "dbo.User");
            DropForeignKey("dbo.Level", "projectId", "dbo.Project");
            DropIndex("dbo.Part", new[] { "CreatedUserId" });
            DropIndex("dbo.Level", new[] { "projectId" });
            DropPrimaryKey("dbo.UserIdProjectId");
            AlterColumn("dbo.Part", "CreatedUserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Part", "CreatedUserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.Part", "CreatedUserId", c => c.String());
            AlterColumn("dbo.Level", "projectId", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.UserIdProjectId", new[] { "Project_ProjectId", "User_UserId" });
            RenameIndex(table: "dbo.PartLevel", name: "IX_levelId", newName: "IX_Level_levelId");
            RenameIndex(table: "dbo.PartLevel", name: "IX_PartId", newName: "IX_Part_PartId");
            RenameIndex(table: "dbo.UserIdProjectId", name: "IX_ProjectId", newName: "IX_Project_ProjectId");
            RenameIndex(table: "dbo.UserIdProjectId", name: "IX_UserId", newName: "IX_User_UserId");
            RenameIndex(table: "dbo.PartProject", name: "IX_PartId", newName: "IX_Part_PartId");
            RenameIndex(table: "dbo.PartProject", name: "IX_ProjectId", newName: "IX_Project_ProjectId");
            RenameColumn(table: "dbo.UserIdProjectId", name: "UserId", newName: "User_UserId");
            RenameColumn(table: "dbo.UserIdProjectId", name: "ProjectId", newName: "Project_ProjectId");
            RenameColumn(table: "dbo.Part", name: "CreatedUserId", newName: "User_UserId");
            RenameColumn(table: "dbo.PartProject", name: "PartId", newName: "Part_PartId");
            RenameColumn(table: "dbo.PartProject", name: "ProjectId", newName: "Project_ProjectId");
            RenameColumn(table: "dbo.Part", name: "CreatedUserId", newName: "CreatedBy_UserId");
            RenameColumn(table: "dbo.PartLevel", name: "levelId", newName: "Level_levelId");
            RenameColumn(table: "dbo.PartLevel", name: "PartId", newName: "Part_PartId");
            //AddColumn("dbo.Part", "CreatedUserId", c => c.String());
            //AddColumn("dbo.Part", "CreatedUserId", c => c.String());
            CreateIndex("dbo.Part", "CreatedBy_UserId");
            CreateIndex("dbo.Part", "User_UserId");
            CreateIndex("dbo.Level", "projectId");
            AddForeignKey("dbo.Part", "User_UserId", "dbo.User", "UserId");
            AddForeignKey("dbo.Part", "CreatedBy_UserId", "dbo.User", "UserId");
            AddForeignKey("dbo.Level", "projectId", "dbo.Project", "ProjectId");
            RenameTable(name: "dbo.UserIdProjectId", newName: "ProjectUser");
            RenameTable(name: "dbo.PartProject", newName: "ProjectPart");
        }
    }
}
