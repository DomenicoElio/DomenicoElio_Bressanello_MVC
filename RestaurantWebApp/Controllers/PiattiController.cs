using Microsoft.AspNetCore.Mvc;
using Restaurant_Core.Entities;
using Restaurant_Core.Interfaces;
using Restaurant_Core.BusinessLayer;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomenicoElio_Bressanello_MVC.RestaurantWebApp.Controllers
{
    public class PiattiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
