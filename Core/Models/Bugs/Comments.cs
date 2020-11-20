using System;

namespace Core.Models.Bugs
{
    public class Comments : DependencyEntity
    {
        public string Comment { get; set; }

        public DateTime CommentTime { get; set; } = DateTime.Now;

        public int BugEntity { get; set; }

        public BugEntity Bug { get; set; }
    }
}
