using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class GroupInstructor
    {
        [ForeignKey("Group")]
        public int GroupId { get; set; }
        public Group? Group { get; set; } = null!; // Navigation property to Group
        [ForeignKey("Instructor")]
        public int InstructorId { get; set; }
        public Instructor? Instructor { get; set; } = null!; // Navigation property to Instructor
    }
}
