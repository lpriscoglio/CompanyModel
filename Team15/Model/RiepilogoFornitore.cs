using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    class RiepilogoFornitore : Riepilogo
    {
        private readonly Fornitore _fornitore;

        public RiepilogoFornitore(Fornitore fornitore)
            : base()
        {
            _fornitore = fornitore;
        }

        public override Currency GetImportiPagati()
        {
            decimal importo=0m;
            foreach (FatturaAcquisto fattura in Azienda.GetInstance().Fatture.GetFattureAcquisto())
            {
                if (fattura.isPayed() && fattura.Fornitore == _fornitore)
                {
                    importo += fattura.Importo.Importo;
                }
            }
            return new Currency(importo);
        }

        public override Currency GetImportiDaPagare()
        {
            decimal importo = 0m;
            foreach (FatturaAcquisto fattura in Azienda.GetInstance().Fatture.GetFattureAcquisto())
            {
                if (!fattura.isPayed() && fattura.Fornitore == _fornitore)
                {
                    importo += fattura.Importo.Importo;
                }
            }
            return new Currency(importo);
        }
    }
}
