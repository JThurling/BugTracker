namespace Core.Models.Bugs
{
    public class SubTask : DependencyEntity
    {
        public string Task { get; set; }

        public Priority Priority { get; set; } = Priority.Low;
    }
}
