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
        [Display(Name ="Display Order")]
        [Range(0,100)]
        public int DisplayOrder { get; set; }
    }
}
