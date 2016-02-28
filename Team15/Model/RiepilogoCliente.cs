using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    class RiepilogoCliente : Riepilogo
    {
         private readonly Cliente _cliente;

        public RiepilogoCliente(Cliente cliente)
            : base()
        {
            _cliente = cliente;
        }

        public override Currency GetImportiPagati()
        {
            decimal importo=0m;
            foreach (FatturaVendita fattura in Azienda.GetInstance().Fatture.GetFattureVendita())
            {
                if (fattura.isPayed() && fattura.Cliente == _cliente)
                {
                    importo += fattura.Importo.Importo;
                }
            }
            return new Currency(importo);
        }

        public override Currency GetImportiDaPagare()
        {
            decimal importo = 0m;
            foreach (FatturaVendita fattura in Azienda.GetInstance().Fatture.GetFattureVendita())
            {
                if (!fattura.isPayed() && fattura.Cliente == _cliente)
                {
                    importo += fattura.Importo.Importo;
                }
            }
            return new Currency(importo);
        }
    }
}
