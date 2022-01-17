﻿using System.ComponentModel.DataAnnotations;

namespace RazorPagesDemo.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int DisplayOrder { get; set; }
    }
}