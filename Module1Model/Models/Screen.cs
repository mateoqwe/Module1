using System.ComponentModel.DataAnnotations;

namespace Module1Model.Models
{
    public class Screen
    {
        [Key]
        public int screenId { get; set; }

        [Required]
        public string screenName { get; set; }
    }
}
