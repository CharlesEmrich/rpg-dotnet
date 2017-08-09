using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPG.Models
{
    [Table("Doors")]
    public class Door
    {
        [Key]
        public int DoorId { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
        public string Shape { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }
}
