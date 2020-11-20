using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iv_hafta_odevi.Models
{
    public class Book
    {
        [Required(ErrorMessage ="Bu alan boş bırakılamaz")]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz")]
        [MaxLength(20)]
        public string Name{ get; set; }
        
        public string Author{ get; set; }
    }
}
