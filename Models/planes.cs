using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace part2.Models
{
    [Table("Category")]

    public class planes
    {
        [Key]
        public int Title { get; set; }

        [Required]
        public string Planes { get; set; }

        [Required]
        public decimal trucks { get; set; }

       
    }
}