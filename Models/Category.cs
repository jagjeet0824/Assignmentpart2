namespace Assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class Category
    {
        public int cost { get; set; }

        [Required]
        [StringLength(10)]
        public string planes { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int trucks { get; set; }

        [Required]
        [StringLength(10)]
        public string cranes { get; set; }
    }
}
