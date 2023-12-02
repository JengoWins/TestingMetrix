using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebB.Classes
{
    public class MisterOne
    {
        [Required]
        [MaxLength(140)]
        public string Id { get; set; }
        public string Summary { get; set; }
    }
}