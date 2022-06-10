using Restaurant_Core.Entities;
using Restaurant_Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        List<Piatto> GetPiatti();
        List<Menu> GetMenus();
        Esito AddPiatto(Piatto nuovoPiatto);
        Esito AddMenu(Menu menu);
        Esito ModificaPiatto(int idPiatto, string nuovoNome, string nuovaDescrizione, double nuovoPrezzo, Tipologia nuovaTipologia);
        Esito EliminaPiatto(int id);
        Esito AssegnaPiattoAlMenu(int idPiatto, int idMenu);

    }
}
