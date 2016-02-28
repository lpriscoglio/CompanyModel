using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class Dipendenti
    {
        private List<Dipendente> _dipendenti;

        public Dipendenti()
        {
            _dipendenti = new List<Dipendente>();
        }

        public IEnumerable<Dipendente> GetDipendenti
        {
            get { return _dipendenti; }
        }

        public void AggiungiDipendente(Dipendente dipendente)
        {
            _dipendenti.Add(dipendente);
            Azienda.GetInstance().OnChanged();
        }

        public void RimuoviDipendente(Dipendente dipendente)
        {
            _dipendenti.Remove(dipendente);
            Azienda.GetInstance().OnChanged();
        }
    }
}
