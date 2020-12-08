using System;
using System.Collections.Generic;
using Core.Models.Bugs;
using Elasticsearch.Net;
using Nest;
using Status = Core.Models.Bugs.Status;

namespace BugTracker.Shared.Models.ElasticsearchModels
{
    [ElasticsearchType(RelationName = "bug")]
    public class BugSearch
    {
        public string Bug { get; set; }

        public string Details { get; set; }

        public DateTime BugReportedTime { get; set; } = DateTime.Now;

        [StringEnum]
        public Status Status { get; set; } = Status.Open;

        public List<ApplicationUser> User { get; set; }
        
        public DateTime Deadline { get; set; }

        [StringEnum]
        public Priority Priority { get; set; } = Priority.Low;

        public List<SubTask> SubTasks { get; set; }

        public List<Comments> Comments { get; set; }
    }
}
