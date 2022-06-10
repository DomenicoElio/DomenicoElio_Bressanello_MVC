using DomenicoElio_Bressanello_MVC.Restaurant_Core.Entities;
using System.ComponentModel.DataAnnotations;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomenicoElio_Bressanello_MVC.RestaurantWebApp.Models
{
    public class UtenteViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; } = "/";
        [Required]
        public Ruolo Ruolo { get; set; }
    }
}
