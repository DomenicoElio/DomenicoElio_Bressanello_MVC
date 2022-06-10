using DomenicoElio_Bressanello_MVC.Restaurant_Core.Entities;
using DomenicoElio_Bressanello_MVC.RestaurantMVC.Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomenicoElio_Bressanello_MVC.RestaurantWebApp.Helper
{
    public static class Mapping
    {
        public static Piatto ToPiatto(this PiattoViewModel piatto)
        {
            return new Piatto
            {
                Id = piatto.Id,
                Nome = piatto.Nome,
                Descrizione = piatto.Descrizione,
                Prezzo = piatto.Prezzo,
                MenuId = piatto.MenuId,
                Menu = piatto.Menu, 
            };
        }

        public static PiattoViewModel ToPiattoViewModel(this Piatto piatto)
        {
            return new PiattoViewModel
            {
                Id = piatto.Id,
                Nome = piatto.Nome,
                Descrizione = piatto.Descrizione,
                Prezzo = piatto.Prezzo,
                MenuId = piatto.MenuId,
                Menu = piatto.Menu,
            };
        }

        public static Menu ToMenu(this MenuViewModel menu)
        {
            List<Piatto> list = new List<Piatto>();
            foreach (var piatto in menu.Piatti)
            {
                list.Add(piatto?.ToPiatto());
            }
            return new Menu
            {
                Id = menu.Id,
                Nome = menu.Nome,
                Piatti = list,
            };
        }

        public static MenuViewModel ToMenuViewModel(this Menu menu)
        {
            List<PiattoViewModel> list = new List<PiattoViewModel>();
            foreach (var piatto in menu.Piatti)
            {
                list.Add(piatto?.ToPiattoViewModel());
            }
            return new MenuViewModel
            {
                Id = menu.Id,
                Nome = menu.Nome,
                Piatti = list,
            };
        }

        public static Utente ToUtente(this UtenteViewModel utenteViewModel)
        {
            return new Utente
            {
                Username = utenteViewModel.Username,
                Password = utenteViewModel.Password,
                Ruolo = utenteViewModel.Ruolo
            };
        }
    }
}
