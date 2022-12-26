﻿using System.ComponentModel.DataAnnotations;

namespace CascadingDropdown.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
