using System.ComponentModel.DataAnnotations;

namespace WebAdaptation4.Model
{
    public class MisterOne
    {
        [Required]
        [MaxLength(140)]
        public int id { get; set; }
        public string Summary { get; set; }
    }
}
