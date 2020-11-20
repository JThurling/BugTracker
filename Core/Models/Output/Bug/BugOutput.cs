using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Core.Models.Bugs;

namespace Core.Models.Output.Bug
{
    public class BugOutput
    {
        public int Id { get; set; }

        public string Bug { get; set; }

        public string Status { get; set; }

        public string Deadline { get; set; }

        public string Priority { get; set; }

        public IList<CommentOutput> Comments { get; set; }

        public IList<SubTaskOutput> SubTasks { get; set; }

        public string BugReportedTime { get; set; }
    }
}
