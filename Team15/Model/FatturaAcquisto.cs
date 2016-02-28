using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class FatturaAcquisto : Fattura, IDestinazione
    {
        
        private Currency _importo;
        private Fornitore _fornitore;


        public FatturaAcquisto(DateTime data, uint numero, Currency importo, Fornitore fornitore)
            : base(data,numero)
        {
            if (!ControllaNumeroFattura(numero, fornitore))
                throw new ArgumentException("Numero di fattura già esistente");
            _importo = importo;
            _fornitore = fornitore;
            _data = data;
        }

        public FatturaAcquisto(uint numero, Currency importo, Fornitore fornitore)
            : base(numero)
        {
           if (!ControllaNumeroFattura(numero, fornitore))
                throw new ArgumentException("Numero di fattura già esistente");
            _importo = importo;
            _fornitore = fornitore;
        }

        private bool ControllaNumeroFattura(uint numero, Fornitore fornitore)
        {
            foreach (FatturaAcquisto fattura in Azienda.GetInstance().Fatture.GetFattureAcquisto())
            {
                if (fattura.Numero == numero && fattura.Fornitore == fornitore)
                    return false;
            }
            return true;
        }

        public Fornitore Fornitore
        {
            get { return _fornitore; }
        }

        public override Currency Importo
        {
            get { return _importo; }
        }

        public bool isPayed()
        {
            foreach (PagamentoAcquisto pagamento in Azienda.GetInstance().Movimenti.GetPagamenti())
            {
                if (pagamento.Destinazione.Equals(this))
                {
                    return true;
                }
            }
            return false;
        }

        

        public override string ToString()
        {
            return "Fattura di acquisto numero: " + _numero;
        }

    }
}
