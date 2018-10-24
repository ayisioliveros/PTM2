using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrackerModuleV1._0.Models.PTM
{
    public class ViewModel
    {
        //public List<SelectListItem> Projects { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ShortDescription { get; set; }
    }
}