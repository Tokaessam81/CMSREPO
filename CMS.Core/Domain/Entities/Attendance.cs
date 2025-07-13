using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class Attendance
    {
        public int AttendanceId { get; set; }
        public int? SessionId { get; set; }
        public Session? Session { get; set; }
        public int? StudentId { get; set; }
        public Student? Student { get; set; }
        public string Status { get; set; } = "Present";
        public string? Notes { get; set; } = null;

    }
}
