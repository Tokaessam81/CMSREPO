using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class GroupStudent
    {
        [ForeignKey("Group")]
        public int GroupId { get; set; }
        public Group? Group { get; set; } = null!; // Navigation property to Group
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        public Student? Student { get; set; } = null!; // Navigation property to Student
    }
}
