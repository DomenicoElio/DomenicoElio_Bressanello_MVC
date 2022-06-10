using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Core.Entities
{
    public enum Tipologia
    {
        primo = 0,
        secondo,
        dolce
    }
    public class Piatto
    {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Descrizione { get; set; }
            public Tipologia tipo { get; set; }
            public double Prezzo { get; set; }

            //come consigliato preso e visto dalla relazione corsi -> studenti    

            public int? MenuId { get; set; }
            public Menu? Menu { get; set; }
        }

    }
