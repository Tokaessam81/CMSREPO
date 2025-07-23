using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class SessionGroup
    {
        [ForeignKey("Session")]
        public int SessionId { get; set; }
        public Session? Session { get; set; } = null!; // Navigation property to Session
        [ForeignKey("Group")]
        public int GroupId { get; set; }
        public Group? Group { get; set; } = null!; // Navigation property to Group
    }
}
