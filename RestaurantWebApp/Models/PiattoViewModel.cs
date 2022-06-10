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
    public class PiattoViewModel
    {

        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public Tipologia tipologia { get; set; }
        [Required]
        public decimal Prezzo { get; set; }

        public int? MenuId { get; set; }
        public Menu? Menu { get; set; }
    }
}
