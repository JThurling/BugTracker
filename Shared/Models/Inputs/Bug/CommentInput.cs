using System;
using System.ComponentModel.DataAnnotations;

namespace Core.Models.Inputs.Bug
{
    public class CommentInput
    {
        [Required(ErrorMessage = "Please Enter a Comment")]
        public string Comment { get; set; }

        [Required(ErrorMessage = "Needs to be connected to some bug")]
        [Range(1, Double.PositiveInfinity)]
        public int BugEntity { get; set; }
    }
}
