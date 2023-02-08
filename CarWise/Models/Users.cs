using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CarWise.Models
{
    public class Users
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [Display(Name = "Nazwa u¿ytkownika")]
        [StringLength(20, ErrorMessage = "Nazwa u¿ytkownika mo¿e zawieraæ maksymalnie 20 znaków")]
        [Index(IsUnique = true)]

        public string Username { get; set; }

        [Required]
        [Display(Name = "Has³o")]
        [StringLength(20, ErrorMessage = "Has³o mo¿e zawieraæ maksymalnie 20 znaków")]
        public string Password { get; set; }
    }
}
