using System;
using System.ComponentModel.DataAnnotations;
using Core.Models.Bugs;

namespace Core.Models.Inputs.Bug
{
    public class SubTaskInput
    {
        [Required(ErrorMessage = "Please Enter a task")]
        public string Task { get; set; }

        public Priority Priority { get; set; } = Priority.Low;

        [Required(ErrorMessage = "Needs to be connected to some bug")]
        [Range(1, Double.PositiveInfinity)]
        public int BugEntity { get; set; }
    }
}
