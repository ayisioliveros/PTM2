namespace TrackerModuleV1._0.Migrations.PTM
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class levelModel : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.PartProject", name: "PartId", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.PartProject", name: "ProjectId", newName: "PartId");
            RenameColumn(table: "dbo.ProjectIdUserId", name: "ProjectId", newName: "__mig_tmp__1");
            RenameColumn(table: "dbo.ProjectIdUserId", name: "UserId", newName: "ProjectId");
            RenameColumn(table: "dbo.PartProject", name: "__mig_tmp__0", newName: "ProjectId");
            RenameColumn(table: "dbo.ProjectIdUserId", name: "__mig_tmp__1", newName: "UserId");
            RenameIndex(table: "dbo.ProjectIdUserId", name: "IX_ProjectId", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.ProjectIdUserId", name: "IX_UserId", newName: "IX_ProjectId");
            RenameIndex(table: "dbo.PartProject", name: "IX_PartId", newName: "__mig_tmp__1");
            RenameIndex(table: "dbo.PartProject", name: "IX_ProjectId", newName: "IX_PartId");
            RenameIndex(table: "dbo.ProjectIdUserId", name: "__mig_tmp__0", newName: "IX_UserId");
            RenameIndex(table: "dbo.PartProject", name: "__mig_tmp__1", newName: "IX_ProjectId");
            CreateTable(
                "dbo.Level",
                c => new
                    {
                        levelId = c.String(nullable: false, maxLength: 128),
                        projectId = c.Int(nullable: false),
                        levelCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.levelId)
                .ForeignKey("dbo.Project", t => t.projectId, cascadeDelete: true)
                .Index(t => t.projectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Level", "projectId", "dbo.Project");
            DropIndex("dbo.Level", new[] { "projectId" });
            DropTable("dbo.Level");
            RenameIndex(table: "dbo.PartProject", name: "IX_ProjectId", newName: "__mig_tmp__1");
            RenameIndex(table: "dbo.ProjectIdUserId", name: "IX_UserId", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.PartProject", name: "IX_PartId", newName: "IX_ProjectId");
            RenameIndex(table: "dbo.PartProject", name: "__mig_tmp__1", newName: "IX_PartId");
            RenameIndex(table: "dbo.ProjectIdUserId", name: "IX_ProjectId", newName: "IX_UserId");
            RenameIndex(table: "dbo.ProjectIdUserId", name: "__mig_tmp__0", newName: "IX_ProjectId");
            RenameColumn(table: "dbo.ProjectIdUserId", name: "UserId", newName: "__mig_tmp__1");
            RenameColumn(table: "dbo.PartProject", name: "ProjectId", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.ProjectIdUserId", name: "ProjectId", newName: "UserId");
            RenameColumn(table: "dbo.ProjectIdUserId", name: "__mig_tmp__1", newName: "ProjectId");
            RenameColumn(table: "dbo.PartProject", name: "PartId", newName: "ProjectId");
            RenameColumn(table: "dbo.PartProject", name: "__mig_tmp__0", newName: "PartId");
        }
    }
}
