﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Core.Domain.Entities
{
    public class Course: BaseEntity
    {
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Title { get; set; }
        public string? Description { get; set; }
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<Group> Groups { get; set; } = new List<Group>();
    }
}
