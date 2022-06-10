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
    public class MenuViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public ICollection<PiattoViewModel>? Piatti { get; set; } = new List<PiattoViewModel>();  
    }
}
