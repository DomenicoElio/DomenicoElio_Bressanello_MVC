using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Core.Entities
{
    public class Utenti
    {
            public int Id { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public Ruolo Ruolo { get; set; }
        }

    //classe presa dal progetto fatto durante la settimana

        public enum Ruolo
        {
            Administrator = 0,
            User = 1
        }
}
