using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class Prodotto : ICloneable
    {
        private readonly string _codiceProdotto;
        private string _descrizione;
        private readonly Currency _prezzo;

        public Prodotto(string codiceProdotto, string descrizione, Currency prezzo)
        {
            if (String.IsNullOrWhiteSpace(codiceProdotto))
                throw new ArgumentNullException("codiceProdotto mancante");
            if (String.IsNullOrWhiteSpace(descrizione))
                throw new ArgumentNullException("descrizione mancante");
            if (!ValidateCodiceProdotto(codiceProdotto))
                throw new ArgumentException("codice prodotto non valido");
            if(!ValidateProdotto(codiceProdotto))
                throw new ArgumentException("codice prodotto già esistente");
            _codiceProdotto = codiceProdotto;
            _descrizione = descrizione;
            _prezzo = prezzo;
        }

        public string CodiceProdotto
        {
            get { return _codiceProdotto; }
        }

        public string Descrizione
        {
            get { return _descrizione; }
            set { _descrizione = value; }
        }

        public Currency Prezzo
        {
            get { return _prezzo; }
        }

        #region ICloneable Members

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        #endregion

        private bool ValidateCodiceProdotto(string codice)
        {
            if (codice.Length == 8)
            {
                for (int i = 0; i < codice.Length; i++)
                {
                    if (i < 3)
                    {
                        if (!Char.IsUpper(codice,i))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (!Char.IsDigit(codice,i))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
            else return false;
        }

        private bool ValidateProdotto(string codiceProdotto)
        {
            foreach (Prodotto prodotto in Azienda.GetInstance().Prodotti.GetProdotti)
            {
                if (codiceProdotto == prodotto._codiceProdotto)
                    return false;
            }
            return true;
        }

        public override string ToString()
        {
            return _codiceProdotto+" "+_descrizione;
        }
        
    }
}
