using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using BugTracker.Shared.Models;
using Elasticsearch.Net;
using Nest;

namespace Core.Models.Bugs
{
    [ElasticsearchType(RelationName = "Bug", IdProperty = nameof(Id))]
    public class BugEntity : DependencyEntity
    {
        [Text(Boost = 1.5)]
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

    public enum Status
    {
        [EnumMember(Value = "Open")]
        Open,
        [EnumMember(Value = "In Progress")]
        InProgress,
        [EnumMember(Value = "Closed")]
        Closed
    }

    public enum Priority
    {
        [EnumMember(Value = "Low")]
        Low,
        [EnumMember(Value = "Medium")]
        Medium,
        [EnumMember(Value = "High")]
        High
    }
}
