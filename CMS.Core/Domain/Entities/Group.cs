using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class Group:BaseEntity
    {
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string GroupName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [ForeignKey("Course")]
        public int? CourseId { get; set; } 
        public Course? Course { get; set; } = null!; 
        public ICollection<GroupInstructor> GroupInstructors { get; set; } = new List<GroupInstructor>();
        public ICollection<GroupStudent> GroupStudents { get; set; } = new List<GroupStudent>();
        public ICollection<SessionGroup> SessionGroups { get; set; } = new List<SessionGroup>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
