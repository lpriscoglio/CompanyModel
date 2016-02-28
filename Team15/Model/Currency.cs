using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class Currency
    {
        private decimal _importo;
        private string _idValuta;

        public Currency(decimal importo, string idValuta)
        {
            _importo = importo;
            _idValuta = idValuta;
        }

        public Currency(string idValuta)
        {
            _importo = 1.0m;
            _idValuta = idValuta;
        }
        
        public Currency(decimal importo)
        {
            _importo = importo;
            _idValuta = "Euro";
        }
        
        public Currency()
        {
            _importo = 1.0m;
            _idValuta = "Euro";
        }
    

        public decimal Importo
        {
            get { return _importo; }
            set { _importo = value; }
        }

        public override string ToString()
        {
            return (this._importo+" "+this._idValuta);
        }
    }
}
