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
        [Display(Name = "Nazwa u�ytkownika")]
        [StringLength(20, ErrorMessage = "Nazwa u�ytkownika mo�e zawiera� maksymalnie 20 znak�w")]
        [Index(IsUnique = true)]

        public string Username { get; set; }

        [Required]
        [Display(Name = "Has�o")]
        [StringLength(20, ErrorMessage = "Has�o mo�e zawiera� maksymalnie 20 znak�w")]
        public string Password { get; set; }
    }
}
