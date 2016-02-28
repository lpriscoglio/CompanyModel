using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class FatturaVendita : Fattura, ISorgente
    {

        private List<RigaFatturaVendita> _righeFattura;
        private Cliente _cliente;

        public FatturaVendita(DateTime data,List<RigaFatturaVendita> righe, Cliente cliente)
            : base(data)
        {
            _righeFattura = righe;
            _numero = ContatoreFattureVendita.GetInstance().GetNumero(_data);
            _cliente = cliente;
        }

        public FatturaVendita(List<RigaFatturaVendita> righe,Cliente cliente) : base()
        {
            _righeFattura = righe;
            _numero = ContatoreFattureVendita.GetInstance().GetNumero(_data);
            _cliente = cliente;
        }
             

        public override Currency Importo
        {
            get
            {
                Currency importo = new Currency(0m);
                foreach (RigaFatturaVendita riga in _righeFattura)
                {
                    importo.Importo += ((riga.Prodotto.Prezzo.Importo) * (decimal)(riga.Quantità));
                }
                return importo;
            }
        }

        public Cliente Cliente
        {
            get {  return _cliente; }
        }

        public IEnumerable<RigaFatturaVendita> RigheFattura
        {
            get { return _righeFattura; }
        }

        public bool isPayed()
        {
            foreach (IncassoVendita incasso in Azienda.GetInstance().Movimenti.GetIncassi())
            {
                if (incasso.Sorgente.Equals(this))
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return "Fattura di vendita numero: " + _numero;
        }
    }
}
