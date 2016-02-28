using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public abstract class MovimentoDiDenaro 
    {
        private readonly DateTime _data;
        private readonly string _causale;
        private readonly Dipendente _dipendente;
        protected readonly ISorgente _sorgente;
        protected readonly IDestinazione _destinazione;
       

        protected MovimentoDiDenaro(DateTime data, string causale, Dipendente dipendente,ISorgente sorgente,IDestinazione destinazione)
        {
            if (data == null)
                throw new ArgumentNullException("data");
            if (String.IsNullOrWhiteSpace(causale))
                throw new ArgumentNullException("causale mancante");
            if (destinazione == null)
                throw new ArgumentNullException("destinazione");
            if (sorgente == null)
                throw new ArgumentNullException("sorgente");
            _data = data;
            _causale = causale;
            _dipendente = dipendente;
            _sorgente = sorgente;
            _destinazione = destinazione;
        }

        public DateTime Data
        {
            get { return _data; }
        }
        
        public string Causale
        {
            get { return _causale; }
        }

        public Dipendente Dipendente
        {
            get { return _dipendente; }
        }

       
        protected bool ControllaSaldo(ISorgente sorgente, Currency importo)
        {
            return (sorgente.Importo.Importo >= importo.Importo ? true : false);
        }

        public abstract Currency Importo
        {
            get;
        }

        public IDestinazione Destinazione
        {
            get { return _destinazione; }
        }

        public ISorgente Sorgente
        {
            get { return _sorgente; }
        }

        public string NomeSorgente
        {
            get { return Sorgente.ToString(); }
        }

        public string NomeDestinazione
        {
            get { return Destinazione.ToString(); }
        }
       
    }
}
