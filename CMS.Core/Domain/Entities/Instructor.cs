using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class Instructor : UserBase
    {
        public string? Bio { get; set; }
        public string? Specialization { get; set; }
        public ICollection<GroupInstructor> GroupInstructors { get; set; } = new List<GroupInstructor>();
    }
}