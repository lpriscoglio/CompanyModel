using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class Amministratore : Utente
    {
        public Amministratore(Dipendente dipendente)
            : base(dipendente)
        {
        }

    }
}