using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class GroupInstructor
    {
        public int GroupId { get; set; }
        public Group? Group { get; set; } = null!; // Navigation property to Group
        public int InstructorId { get; set; }
        public Instructor? Instructor { get; set; } = null!; // Navigation property to Instructor

    }
}
