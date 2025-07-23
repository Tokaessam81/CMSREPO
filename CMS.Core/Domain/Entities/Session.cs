using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class Session: BaseEntity
    {
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        [Required]
        public DateTime SessionDate { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        public ICollection<SessionGroup> SessionGroups { get; set; } = new List<SessionGroup>();
        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
        public ICollection<SessionTask> Tasks { get; set; } = new List<SessionTask>();
    }
}
