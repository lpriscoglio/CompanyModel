using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    static class Autenticazione
    {
        private static Utente _utente = null;
        public static Utente AutenticaDipendente(string username, string password)
        {
            try
            {
                foreach (Dipendente dipendente in Azienda.GetInstance().Dipendenti.GetDipendenti)
                {
                    if (dipendente.Username == username && dipendente.Password == password)
                    {
                        _utente = CreaUtente(dipendente);
                        return _utente;
                    }
                }
            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
        }

        private static Utente CreaUtente(Dipendente dipendente)
        {
            
            if (dipendente.Ruolo == Ruolo.Utente)
            {
                return new Utente(dipendente);
            }
            else
                return new Amministratore(dipendente);

        }

        public static Utente Utente
        {
            get { return _utente; }
        }
    }
}
