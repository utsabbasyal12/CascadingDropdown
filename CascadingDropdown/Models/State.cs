using System.ComponentModel.DataAnnotations;

namespace CascadingDropdown.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string? Name { get; set; }

        public Country? Country { get; set; }
    }
}
