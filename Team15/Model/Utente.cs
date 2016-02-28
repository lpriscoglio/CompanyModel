using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class Utente
    {
        private Dipendente _dipendente;

        public Utente(Dipendente dipendente)
        {
            if (dipendente == null)
                throw new ArgumentNullException("dipendente");
            _dipendente = dipendente;
        }

        public Dipendente Dipendente
        {
            get { return _dipendente; }
        }

        public override string ToString()
        {
            return "Utente Corrente: " + _dipendente.Username + "   Ruolo: " + _dipendente.Ruolo;
        }
    }

}
