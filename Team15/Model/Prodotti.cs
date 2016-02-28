using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class Prodotti
    {
        private List<Prodotto> _prodotti;

        public Prodotti()
        {
            _prodotti = new List<Prodotto>();
        }

        public IEnumerable<Prodotto> GetProdotti
        {
            get { return _prodotti; }
        }

        public void AggiungiProdotto(Prodotto prodotto)
        {
            _prodotti.Add(prodotto);
            Azienda.GetInstance().OnChanged();
        }

        public void RimuoviProdotto(Prodotto prodotto)
        {
            _prodotti.Remove(prodotto);
            Azienda.GetInstance().OnChanged();
        }
    }
}
