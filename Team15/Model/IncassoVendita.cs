using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class IncassoVendita : MovimentoDiDenaro
    {
       public IncassoVendita(IDestinazione destinazione, ISorgente sorgente, DateTime data, string causale, Dipendente dipendente)
            : base(data, causale, dipendente,sorgente,destinazione)
        {  }

        public override Currency Importo
        {
            get { return _sorgente.Importo; }
        }

        
    }
}
