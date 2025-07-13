using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class SessionGroup
    {
        public int SessionId { get; set; }
        public Session? Session { get; set; } = null!; // Navigation property to Session
        public int GroupId { get; set; }
        public Group? Group { get; set; } = null!; // Navigation property to Group
    }
}
