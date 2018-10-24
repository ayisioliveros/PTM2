using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrackerModuleV1._0.Models.PTM
{
    public class Level
    {
        [Key]
        public string levelId { get; set; }
        public string projectId { get; set; }
        public int levelCount { get; set; }
        public Project project { get; set; }

        public virtual ICollection<Part> parts { get; set; }

    }
}