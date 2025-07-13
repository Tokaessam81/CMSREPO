

namespace CMS.Core.Domain.Entities
{
    public class Session
    {
        public int SessionId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime SessionDate { get; set; }
        public DateTime StartTime { get; set; }
        public ICollection<SessionGroup> SessionGroups { get; set; } = new List<SessionGroup>();
        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
        public ICollection<Task> Tasks { get; set; } = new List<Task>();
    }
}
