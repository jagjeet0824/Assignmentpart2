namespace Assignment.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Vehicle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cost { get; set; }

        [Required]
        [StringLength(10)]
        public string bike { get; set; }

        [Required]
        [StringLength(10)]
        public string cars { get; set; }

        [Required]
        [StringLength(10)]
        public string trains { get; set; }
    }
}
