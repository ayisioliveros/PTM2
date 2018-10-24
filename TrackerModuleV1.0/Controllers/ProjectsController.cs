using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrackerModuleV1._0.Data;
using TrackerModuleV1._0.Models.PTM;

namespace TrackerModuleV1._0.Controllers
{
    public class ProjectsController : Controller
    {
        private PTMContex db = new PTMContex();


        public ActionResult Index()
        {
            PTMContex ptmContex = new PTMContex();
            //List<SelectListItem> items = new List<SelectListItem>();
            //items.Add(new SelectListItem { Text = "option1", Value = "option2" });
            //items.Add(new SelectListItem { Text = "option2", Value = "option2" });

            var getProjectList = ptmContex.Projects.ToList();
            SelectList Idlist = new SelectList(getProjectList, "ProjectId", "ProjectId");
            SelectList Namelist = new SelectList(getProjectList, "ProjectName", "ProjectName");
            ViewBag.projectListId = Idlist;
            ViewBag.projectListName = Namelist;
            //ViewBag.selectedItemList = items;
            return View();

        }
        // GET: Projects

        public ActionResult All()
        {
            return View(db.Projects.ToList());
            
        }


        //GET: Projects/Details/PRO001
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }


        // GET: Projects/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
            
        //    Project project = db.Projects.Find(id);
        //    if (project == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(project);
        //}

        // GET: Projects/Create
        public ActionResult Create()
        {
            PTMContex ptmContex = new PTMContex();
            var getUserList = ptmContex.Users.ToList();
            SelectList Namelist = new SelectList(getUserList, "FullName", "FullName");
            ViewBag.UserListName = Namelist;
            return View();
        }


        


        // POST: Projects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjectId,ProjectName,ShortDescription")] Project project)
        {
            if (ModelState.IsValid)
            {
                db.Projects.Add(project);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(project);
        }

        // GET: Projects/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Find(id);
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // POST: Projects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjectId,ProjectName,ShortDescription")] Project project)
        {
            if (ModelState.IsValid)
            {
                db.Entry(project).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(project);
        }

        // GET: Projects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project project = db.Projects.Find(id);
            
            if (project == null)
            {
                return HttpNotFound();
            }
            return View(project);
        }

        // POST: Projects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Project project = db.Projects.Find(id);
            db.Projects.Remove(project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        /// <summary>
        /// /
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="projectName"></param>
        /// <param name="description"></param>
        /// <returns></returns>
        /// 
        /// 
        /// 
        /// // POST: Projects/Search/
        [HttpPost]
        public ActionResult Search(Project prjctV)
        {
            
            string SProjectId = prjctV.ProjectId;
            string SProjectName = prjctV.ProjectName;
            Project project= new Project();


            if (SProjectId != null)
            {
                project = db.Projects.Find(SProjectId);
            }
            else
            {
                string Sql = "Select * from Project where ";
                if (SProjectName != null)
                {
                    Sql = Sql + "ProjectName= @a";
                    project = db.Projects.SqlQuery(Sql, new SqlParameter("@a", SProjectName)).First();
                    
                }
            }
            return View("Details",project);

        }
        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
