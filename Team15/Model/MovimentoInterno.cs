using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class MovimentoInterno : MovimentoDiDenaro
    {
        private Currency _importo;
       
        public MovimentoInterno(DateTime data, string causale, Dipendente dipendente, Currency importo,ISorgente sorgente,IDestinazione destinazione) 
            : base(data,causale,dipendente,sorgente,destinazione)
        {
           if (destinazione == sorgente)
                throw new ArgumentException("Sorgente e Destinazione devono essere diversi");
            if (!ControllaSaldo(sorgente, importo))
                throw new ArgumentException("Insufficienti fondi nella sorgente");
            _importo = importo;
        }

        public override Currency Importo
        {
            get { return _importo; }
        }
    }
}
