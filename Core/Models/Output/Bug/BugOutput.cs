using System;
using System.ComponentModel.DataAnnotations;
using Core.Models.Bugs;

namespace Core.Models.Output.Bug
{
    public class BugOutput
    {

        public string Bug { get; set; }

        public string Status { get; set; }

        public DateTime Deadline { get; set; }

        public string Priority { get; set; }

        public DateTime BugReportedTime { get; set; }
    }
}
