namespace TrackerModuleV1._0.Migrations.PTM
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateModelNewx : DbMigration
    {
        public override void Up()
        {
            //RenameTable(name: "dbo.UserIdProjectId", newName: "ProjectUser");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ProjectUser", newName: "UserIdProjectId");
        }
    }
}
