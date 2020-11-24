using System;
using System.ComponentModel.DataAnnotations;
using Core.Models.Bugs;

namespace Core.Models.Inputs.Bug
{
    public class BugInput
    {
        [Required(ErrorMessage = "Please Enter The Bug you found")]
        public string Bug { get; set; }
        
        public Status Status { get; set; } = Status.Open;

        public DateTime Deadline { get; set; }

        public Priority Priority { get; set; } = Priority.Low;
    }
}
