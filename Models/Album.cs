using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace part2.Models
{
    [Table("Album")]
    public class Album
    {
       
        [Key]
        public int AlbumId { get; set; }
        [Required]
        public int Name   { get; set; }
        [Required]
        public decimal Charge { get; set; }
    }
}
