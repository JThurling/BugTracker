using System;

namespace Core.Models.Bugs
{
    public class BugEntity : DependencyEntity
    {
        public string Bug { get; set; }

        public string ReportedBy { get; set; }

        public DateTime BugReportedTime { get; set; }

        public string Status { get; set; }

        public string AssignedTo { get; set; }

        public DateTime Deadline { get; set; }

        public string Priority { get; set; }
    }
}
