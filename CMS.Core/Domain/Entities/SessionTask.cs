using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class SessionTask : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateTime? DeadLine { get; set; }
        [ForeignKey("Session")]
        public int? SessionId { get; set; }
        public Session? Session { get; set; }
        public ICollection<Solution> Solutions { get; set; } = new List<Solution>();
    }
}
