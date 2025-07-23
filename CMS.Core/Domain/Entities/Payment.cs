using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class Payment: BaseEntity
    {
        [ForeignKey("Group")]
        public int? GroupId { get; set; }
        public Group? Group { get; set; }
        [ForeignKey("Student")]
        public int? StudentId { get; set; }
        public Student? Student { get; set; }
        [Required]
        [Range(typeof(decimal), "1", "1000000", ErrorMessage = "Amount must be between 1 and 1,000,000")]
        public decimal Amount { get; set; }
        [Required]
        public DateTime PaymentDate { get; set; }
        [Required]
        [MaxLength(50)]
        [MinLength(3)]
        public string PaymentMethod { get; set; } = string.Empty;
    }
}
