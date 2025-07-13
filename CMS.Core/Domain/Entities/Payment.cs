using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int? GroupId { get; set; }
        public Group? Group { get; set; }
        public int? StudentId { get; set; }
        public Student? Student { get; set; }
        public decimal Amount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentMethod { get; set; } = string.Empty;


    }
}
