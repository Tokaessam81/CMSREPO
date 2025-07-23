using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class Solution: BaseEntity
    {
        [ForeignKey("SessionTask")]
        public int? SessionTaskId { get; set; }
        public SessionTask? SessionTask { get; set; }
        [ForeignKey("Student")]
        public int? StudentId { get; set; }
        public Student? Student { get; set; }
        public DateTime? SubmittedAt { get; set; }
        [Required]
        [MaxLength(200)]
        [MinLength(3)]
        public string FileLocation { get; set; } = string.Empty;
        [Range(typeof(decimal), "0", "100", ErrorMessage = "Grade must be between 0 and 100.")]
        public decimal? Grade { get; set; }
    }
}
