using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class Admin : UserBase
    {
        [Required]
        public string PasswordHash { get; set; } = string.Empty;
    }
}
