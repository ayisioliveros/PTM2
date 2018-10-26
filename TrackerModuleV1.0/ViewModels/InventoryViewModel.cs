using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrackerModuleV1._0.Models.PTM
{
    public class InventoryViewModel
    {
        public IEnumerable<TrackerModuleV1._0.Models.PTM.Project> Inventory { get; set; }
        public IEnumerable<TrackerModuleV1._0.Models.PTM.Project> Projects { get; set; }
        public IEnumerable<TrackerModuleV1._0.Models.PTM.Part> Parts { get; set; }
        public IEnumerable<TrackerModuleV1._0.Models.PTM.Supplier> Suppliers { get; set; }
    }
}