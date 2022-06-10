using System;
using Restaurant_Core.Entities;
using Restaurant_Core.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Core.BusinessLayer
{
    public class MainBL : IBusinessLayer
    {
        private readonly IRepoPiatti repoPiatti;
        private readonly IRepoMenu repoMenu;
        private readonly IRepoUtenti repoUtenti;

        public MainBL(IRepoPiatti piatti, IRepoMenu menu, IRepoUtenti utenti){
            repoPiatti = piatti;
            repoMenu = menu;
            repoUtenti = utenti;
        }

        public List<Menu> GetMenus() { return repoMenu.GetAll(); }

        public List<Piatto> GetPiatti() { return repoPiatti.GetAll(); }

        public Esito AddMenu(Menu nuovoMenu)
        {
            repoMenu.Add(nuovoMenu);

            return new Esito { IsOk = true };
        }

        public Esito AddPiatto(Piatto nuovoPiatto)
        {
            repoPiatti.Add(nuovoPiatto);
            return new Esito() { IsOk = true };
        }

        public Esito AssegnaPiattoAlMenu(int idPiatto, int idMenu)
        {
            var piattoRecuperato = repoPiatti.GetById(idPiatto);
            var menuRecuperato = repoMenu.GetById(idMenu);
            if (piattoRecuperato == null || menuRecuperato == null)
            {
                return new Esito() { IsOk = false };
            }
            if (piattoRecuperato.MenuId != null)
            {
                return new Esito() { IsOk = false };
            }
            piattoRecuperato.MenuId = menuRecuperato.Id;
            repoPiatti.Update(piattoRecuperato);
            return new Esito() { IsOk = true };
        }

        // anche se non richiesto da consegna, la scelta di usare id per piatti e menu semplifica le operazioni crud e non 

        public Esito EliminaPiatto(int id)
        {
            var piattoRecuperato = repoPiatti.GetById(id);
            if (piattoRecuperato == null)
            {
                return new Esito() { IsOk = false };
            }
            repoPiatti.Delete(piattoRecuperato);
            return new Esito() { IsOk = true };
        }

        public Esito ModificaPiatto(int idPiatto, string nuovoNome, string nuovaDescrizione, double nuovoPrezzo, Tipologia nuovaTipologia)
        {
            var piattoRecuperato = repoPiatti.GetById(idPiatto);
            if (piattoRecuperato == null)
            {
                return new Esito() { IsOk = false, Messaggio = "the selected Id doesn't match any of our menu choices: select a new one" };
            }
            piattoRecuperato.Nome = nuovoNome;
            piattoRecuperato.Descrizione = nuovaDescrizione;
            piattoRecuperato.Prezzo = nuovoPrezzo;
            piattoRecuperato.tipo = nuovaTipologia;
            repoPiatti.Update(piattoRecuperato);
            return new Esito() { IsOk = true };
        }

    }
}
