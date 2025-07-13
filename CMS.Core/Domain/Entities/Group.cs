using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? CourseId { get; set; } 
        public Course? Course { get; set; } = null!; 
        public ICollection<GroupInstructor> GroupInstructors { get; set; } = new List<GroupInstructor>();
        public ICollection<GroupStudent> GroupStudents { get; set; } = new List<GroupStudent>();
        public ICollection<SessionGroup> SessionGroups { get; set; } = new List<SessionGroup>();
        public ICollection<Payment> Sessions { get; set; } = new List<Payment>();
    }
}
