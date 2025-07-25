﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class Student :UserBase
    {
        [Required]
        public string PasswordHash { get; set; } = string.Empty;
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Faculty { get; set; } = string.Empty;
        public bool IsGraduated { get; set; } = false;
        public DateTime? BirthDate { get; set; } = null;
        public ICollection<GroupStudent> GroupStudents { get; set; } = new List<GroupStudent>();
        public ICollection<Solution> Solutions { get; set; } = new List<Solution>();
        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();
        public ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
