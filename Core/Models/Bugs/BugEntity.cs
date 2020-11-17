using System;
using System.Collections.Generic;

namespace Core.Models.Bugs
{
    public class BugEntity : DependencyEntity
    {
        public string Bug { get; set; }

        // public ApplicationUser ReportedBy { get; set; }

        public DateTime BugReportedTime { get; set; } = DateTime.Now;

        public Status Status { get; set; } = Status.Open;

        public List<ApplicationUser> User { get; set; }

        public DateTime Deadline { get; set; }

        public Priority Priority { get; set; } = Priority.Low;
    }

    public enum Status
    {
        Open,
        InProgress,
        Closed
    }

    public enum Priority
    {
        Low,
        Medium,
        High
    }
}
