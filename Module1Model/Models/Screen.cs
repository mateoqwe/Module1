using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
