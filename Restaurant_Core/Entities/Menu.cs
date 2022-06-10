using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Core.Entities
{
    public class Menu
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Piatto>? Piatti { get; set; }

        //preso da corsi

        public double CalcoloPasto(){
            double total = 0;
            foreach (var piatto in Piatti)
            { total += (double)piatto.Prezzo;}
            return total;
        }
    }
}
