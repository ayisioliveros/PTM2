namespace TrackerModuleV1._0.Migrations.PTM
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Data;

    internal sealed class Configuration : DbMigrationsConfiguration<TrackerModuleV1._0.Data.PTMContex>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\PTM";
        }
        void AddOrUpdateUser(PTMContex context, string ProjectName, string FirstName)
        {
            var prjct = context.Projects.SingleOrDefault(p => p.ProjectName == ProjectName);
            var usr = context.Users.SingleOrDefault(u => u.FirstName == FirstName);
            if (usr != null)
            {
                prjct.users.Add(context.Users.Single(u => u.FirstName == FirstName));

            }
        }
        void AddOrUpdateLevel_Part(PTMContex context, string levelId, string PartName)
        {
            var level = context.Levels.SingleOrDefault(p => p.levelId == levelId);
            var part = context.Parts.SingleOrDefault(u => u.PartName == PartName);
            if (part != null)
            {
                level.parts.Add(context.Parts.Single(u => u.PartName == PartName));

            }
        }
        void AddOrUpdateProject_Level(PTMContex context, string ProjectName, string levelId)
        {
            var prjct = context.Projects.SingleOrDefault(p => p.ProjectName == ProjectName);
            var level = context.Levels.SingleOrDefault(l => l.levelId == levelId);
            if (level != null)
            {
                prjct.Levels.Add(context.Levels.Single(u => u.levelId == levelId));

            }
        }
        void AddorUpdatePart(PTMContex contex, string projectName, string partName)
        {
            var prjct = contex.Projects.SingleOrDefault(p => p.ProjectName == projectName);
            var prt = contex.Parts.SingleOrDefault(i => i.PartName == partName);
            if (prt != null)
            {
                prjct.parts.Add(contex.Parts.Single(p => p.PartName == partName));
            }
        }

        protected override void Seed(TrackerModuleV1._0.Data.PTMContex context)
        {
            //  This method will be called after migrating to the latest version.

            

            context.Projects.AddOrUpdate(
                p =>  p.ProjectName, DummyData.getProjects().ToArray());
            context.SaveChanges();

            context.Users.AddOrUpdate(
                u => new { u.FirstName, u.LastName }, DummyData.getUsers().ToArray());
            context.SaveChanges();

            context.Parts.AddOrUpdate(
                p => p.PartName, DummyData.getParts(context).ToArray());
            context.SaveChanges();

            context.Levels.AddOrUpdate(
                p=> p.levelId,DummyData.getLevels(context).ToArray());
            context.SaveChanges();


            AddOrUpdateUser(context, "Wafer Sorter", "Abienash");
            AddOrUpdateUser(context, "Wafer Sorter", "Leo");
            AddOrUpdateUser(context, "Bakeout Chamber", "Leo");
            AddOrUpdateUser(context, "Carbon Nanotube CVD Chamber", "Devinda");
            AddOrUpdateUser(context, "Process Kit Transporter", "Danny");
            AddOrUpdateUser(context, "Bakeout Chamber", "Devinda");

            AddorUpdatePart(context, "Wafer Sorter", "ScrewDriver");
            AddorUpdatePart(context, "Process Kit Transporter", "BreadBoard");
            AddorUpdatePart(context, "Process Kit Transporter", "ScrewDriver");

            //AddOrUpdateProject_Level(context, "Wafer Sorter", "PRO00101");
            //AddOrUpdateProject_Level(context, "Wafer Sorter", "PRO00102");
            //AddOrUpdateProject_Level(context, "Wafer Sorter", "PRO00103");


            AddOrUpdateLevel_Part(context, "PRO00101", "ScrewDriver");
            AddOrUpdateLevel_Part(context, "PRO00101", "BreadBoard");
            AddOrUpdateLevel_Part(context, "PRO00201", "BreadBoard");

            context.SaveChanges();
            //PRO00201
        }
    }
}
