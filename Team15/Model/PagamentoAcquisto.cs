using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class PagamentoAcquisto : MovimentoDiDenaro
    {
           public PagamentoAcquisto(DateTime data, string causale, Dipendente dipendente, ISorgente sorgente,IDestinazione destinazione)
            : base(data, causale, dipendente,sorgente,destinazione)
        {
             if (!ControllaSaldo(sorgente, destinazione.Importo))
                throw new ArgumentException("Insufficienti fondi nella sorgente");
         }

        public override Currency Importo
        {
            get { return _destinazione.Importo; }
        }     
    }
}
