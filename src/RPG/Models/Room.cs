using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPG.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public string Description { get; set; }

    }
}
