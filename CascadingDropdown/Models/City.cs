using System.ComponentModel.DataAnnotations;

namespace CascadingDropdown.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }

        public State? State { get; set; }
    }
}
