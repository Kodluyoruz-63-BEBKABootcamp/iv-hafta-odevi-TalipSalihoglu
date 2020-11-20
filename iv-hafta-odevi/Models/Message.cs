using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iv_hafta_odevi.Models
{
    public class Message
    {
        [Required]
        public int MessageId { get; set; }
        [Required]
        public string message { get; set; }
    }
}
