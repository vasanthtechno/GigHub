using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Genre
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }
    }
}