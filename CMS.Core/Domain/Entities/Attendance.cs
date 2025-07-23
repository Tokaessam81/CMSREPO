using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class Attendance: BaseEntity
    {
        [ForeignKey("Session")]
        public int? SessionId { get; set; }
        public Session? Session { get; set; }

        [ForeignKey("Student")]
        public int? StudentId { get; set; }
        public Student? Student { get; set; }

        [Required]
        [MaxLength(20)]
        [MinLength(3)]
        public string Status { get; set; } = "Present";
        public string? Notes { get; set; } = null;
    }
}
