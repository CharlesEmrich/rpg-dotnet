using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPG.Models
{
    [Table("Keys")]
    public class Key
    {
        [Key]
        public int KeyId { get; set; }
        public string Shape { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }
}
