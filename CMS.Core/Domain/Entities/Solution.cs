using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class Solution
    {
        public int SolutionId { get; set; }
        public int? TaskId { get; set; }
        public Task? Task { get; set; }
        public int? StudentId { get; set; }
        public Student? Student { get; set; }
        public DateTime? SubmittedAt { get; set; }
        public string FileUrl { get; set; } = string.Empty;
        public decimal? Grade { get; set; }
    }
}
