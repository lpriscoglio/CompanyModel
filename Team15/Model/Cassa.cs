using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class Cassa : ContenitoreDiDenaro
    {
        public Cassa(Currency saldoIniziale)
            : base(saldoIniziale)
        { }


        public override Currency Saldo()
        {
            decimal saldo = SaldoIniziale.Importo;
            foreach (MovimentoInterno movimento in Azienda.GetInstance().Movimenti.GetMovimentiInterni())
            {
                if (movimento.Sorgente is Cassa)
                {
                    saldo -= movimento.Importo.Importo;
                }
                else if (movimento.Destinazione is Cassa)
                {
                    saldo += movimento.Importo.Importo;
                }
            }
            foreach (PagamentoAcquisto pagamento in Azienda.GetInstance().Movimenti.GetPagamenti()) 
            {
                if (pagamento.Sorgente is Cassa)
                {
                    saldo -= pagamento.Importo.Importo;
                }
            }
            foreach (IncassoVendita incasso in Azienda.GetInstance().Movimenti.GetIncassi()) 
            {
                if (incasso.Destinazione is Cassa)
                {
                    saldo += incasso.Importo.Importo;
                }
            }
            return new Currency(saldo);
        }

        public override string ToString()
        {
            return "Cassa";
        }

       
    }
}
