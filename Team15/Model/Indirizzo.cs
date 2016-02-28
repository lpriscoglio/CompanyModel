using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class Indirizzo
    {
        private string _via;
        private string _numeroCivico;
        private string _località;
        private string _cap;
        private string _provincia;
        private string _nazione;

        public Indirizzo(string via, string numeroCivico, string località, string cap, string provincia, string nazione)
        {
            if (String.IsNullOrWhiteSpace(via))
                throw new ArgumentNullException("Via mancante");
            if (String.IsNullOrWhiteSpace(numeroCivico))
                throw new ArgumentNullException("Numero Civico mancante");
            if (String.IsNullOrWhiteSpace(località))
                throw new ArgumentNullException("Località mancante");
            if (String.IsNullOrWhiteSpace(cap))
                throw new ArgumentNullException("CAP mancante");
            if (String.IsNullOrWhiteSpace(provincia))
                throw new ArgumentNullException("Provincia mancante");
            if (String.IsNullOrWhiteSpace(nazione))
                throw new ArgumentNullException("Nazione mancante");
            _via = via; 
            _numeroCivico = numeroCivico;
            _località = località;
            _cap = cap;
            _provincia = provincia;
            _nazione = nazione;
        }

        public string Via
        {
            get { return _via; }
            set { _via = value; }
        }

        public string NumeroCivico
        {
            get { return _numeroCivico; }
            set { _numeroCivico = value; }
        }

        public string Località
        {
            get { return _località; }
            set { _località = value; }
        }

        public string Cap
        {
            get { return _cap; }
            set { _cap = value; }
        }

        public string Provincia
        {
            get { return _provincia; }
            set { _provincia = value; }
        }

        public string Nazione
        {
            get { return _nazione; }
        }

        public override string ToString()
        {
            return (this._via+","+this._numeroCivico+","+this._località+","+this._provincia+","+this._cap+","+this._nazione);
        }
   
    }
}
