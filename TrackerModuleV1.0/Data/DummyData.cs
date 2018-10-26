using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TrackerModuleV1._0.Models.PTM;

namespace TrackerModuleV1._0.Data
{
    public class DummyData
    {
        public static List<Project> getProjects()
        {
            List<Project> projects = new List<Project>()
            {
                new Project()
                {
                    ProjectId="PRO001",
                    ProjectName="Wafer Sorter",
                    users=new List<User>(),
                    parts=new List<Part>(),
                    Levels=new List <Level>()

                },
                new Project()
                {
                    ProjectId="PRO002",
                    ProjectName="Bakeout Chamber",
                    users=new List<User>(),
                    parts=new List<Part>(),
                    Levels=new List <Level>()
                },
                new Project()
                {
                    ProjectId="PRO003",
                    ProjectName="Process Kit Transporter",
                    users=new List<User>(),
                    parts=new List<Part>(),
                    Levels=new List <Level>()
                },
                new Project()
                {
                    ProjectId="PRO004",
                    ProjectName="Carbon Nanotube CVD Chamber",
                    users=new List<User>(),
                    parts=new List<Part>(),
                    Levels=new List <Level>()
                }
            };
            return projects;
            
         }
        //public static List<User> getUsers()
        //{
        //    List<User> users = new List<User>()
        //    {
        //        new User()
        //        {
        //            UserId="EMP0001",
        //            FirstName="Leo",
        //            LastName="Passion",
        //            JobRole="Engineer",
                    
        //           // projects=new List<Project>()
        //            //ProjectNumber=context.Projects.Find(3).ProjectId,
                    
        //        },
        //        new User()
        //        {
        //            UserId="EMP0002",
        //            FirstName="Abienash",
        //            LastName="Thangavel",
        //            JobRole="Design Engineer",
        //             //projects=new List<Project>()
        //           // ProjectNumber=context.Projects.Find(1).ProjectId,

        //        },
        //        new User()
        //        {
        //            UserId="EMP003",
        //            FirstName="Alex",
        //            LastName="Daniel",
        //            JobRole="Design Engineer",
        //            // projects=new List<Project>()
        //            //ProjectNumber=context.Projects.Find(1).ProjectId,

        //        },
        //        new User()
        //        {
        //            UserId="EMP0004",
        //            FirstName="Danny",
        //            LastName="Edward",
        //            JobRole="Design Engineer",
        //            // projects=new List<Project>()
        //            //ProjectNumber=context.Projects.Find(1).ProjectId,

        //        },
        //        new User()
        //        {
        //            UserId="EMP0005",
        //            FirstName="Devinda",
        //            LastName="Liyanage",
        //            JobRole="R@D Engineer",
        //             //projects=new List<Project>()
        //           // ProjectNumber=context.Projects.Find(4).ProjectId,

        //        },
        //        new User()
        //        {
        //            UserId="EMP0006",
        //            FirstName="Chamali",
        //            LastName="Liyanage",
        //            JobRole="R@D Engineer",
        //             //projects=new List<Project>()
        //           // ProjectNumber=context.Projects.Find(4).ProjectId,

        //        }
        //    };
        //    return users;
        //}

        public static List<Part> getParts(PTMContex contex)
        {
            List<Part> parts = new List<Part>()
            {
                new Part()
                {
                    PartId="PAR0001",
                    PartName="ScrewDriver",
                    PartDescription="Triwing Triangle Screw-Driver Repair Fixing Tool for Nintendo Wii DS Lite NDSL",
                    NovenaTecPartNumber="NOVSCREW1001",
                    SwissRanksPartNumber="SWSCREW1001",
                    OEMPartNumber="OEMSCREW1001",
                    VendorPartNumber="ABCSCREW1001",
                    CreatedBy= contex.Users.Find("EMP0002"),
                    ApproveBy=contex.Users.Find("EMP0001"),
                    Status="Approved",
                    StockQuantity=10,
                    
                    

                },

                new Part()
                {
                    PartId="PAR0002",
                    PartName="BreadBoard",
                    PartDescription="Round Hole Solderless Breadboard 840 Points",
                    NovenaTecPartNumber="NOVBBOARD1002",
                    SwissRanksPartNumber="SWBBOARD1002",
                    OEMPartNumber="OEMBBOARD1002",
                    VendorPartNumber="FXYBBOARD1002",
                    CreatedBy= contex.Users.Find("EMP0001"),
                    Status="Send for Approve",
                    StockQuantity=0

                }
            };

            return parts;
        }
        public static List<Level> getLevels(PTMContex contex)
        {
            List<Level> levels = new List<Level>()
            {
                new Level()
                {
                    levelId ="PRO00101",
                    levelCount=1,
                    project=contex.Projects.Find("PRO001"),


                    parts=new List<Part>()

                },
                new Level()
                {
                    levelId ="PRO00102",
                    levelCount=2,
                    project=contex.Projects.Find("PRO001"),

                    parts=new List<Part>()
                },
                new Level()
                {
                    levelId ="PRO00103",
                    levelCount=3,
                    project=contex.Projects.Find("PRO001"),

                    parts=new List<Part>()
                },
                 new Level()
                {
                    levelId ="PRO00201",
                    levelCount=1,
                    project=contex.Projects.Find("PRO002"),

                    parts=new List<Part>()

                }
            };
            return levels;
        }

    }
}