using System;
using System.Collections.Generic;
using System.Text;

namespace Team15.Model
{
    static class DepositoDiDenaroFactory
    {
        class ContoCorrenteBancario : DepositoDiDenaro
        {
            private readonly string _codConto;

            public ContoCorrenteBancario(string codConto, Currency saldoIniziale)
                : base(saldoIniziale)
            {
                if (!ValidateCodConto(codConto))
                    throw new ArgumentException("Codice conto già esistente");
                _codConto = codConto;
            }

            public string CodConto
            {
                get { return _codConto; }
            }

            public override string ToString()
            {
                return _codConto;
            }


            
            public override Currency Saldo()
            
            {
                
                decimal saldo = SaldoIniziale.Importo;
                foreach (MovimentoInterno movimento in Azienda.GetInstance().Movimenti.GetMovimentiInterni()) //iterazione sui movimenti interni
                {
                    if (movimento.Sorgente is ContoCorrenteBancario && ((ContoCorrenteBancario)movimento.Sorgente).CodConto == this.CodConto)
                        saldo -= movimento.Importo.Importo;
                    else if (movimento.Destinazione is ContoCorrenteBancario && ((ContoCorrenteBancario)movimento.Destinazione).CodConto == this.CodConto)
                        saldo += movimento.Importo.Importo;
                }
                foreach (PagamentoAcquisto pagamento in Azienda.GetInstance().Movimenti.GetPagamenti()) // iterazione sui movimenti legati alle fatture
                {
                    if (pagamento.Sorgente is ContoCorrenteBancario && ((ContoCorrenteBancario)pagamento.Sorgente).CodConto == this.CodConto)
                        saldo -= pagamento.Importo.Importo;
                }
                foreach (IncassoVendita incasso in Azienda.GetInstance().Movimenti.GetIncassi())
                {
                    if (incasso.Destinazione is ContoCorrenteBancario && ((ContoCorrenteBancario)incasso.Destinazione).CodConto == this.CodConto)
                        saldo += incasso.Importo.Importo;
                }

                return new Currency(saldo);
            }

            public bool ValidateCodConto(string codiceConto)
            {
                foreach (DepositoDiDenaro deposito in Azienda.GetInstance().Depositi.GetDepositi)
                {
                    if (((ContoCorrenteBancario)deposito).CodConto == codiceConto)
                        return false;
                }
                return true;
            }
           
        }
        
        public static DepositoDiDenaro CreateContoCorrenteBancario(Currency saldoIniziale,string codiceConto)
        {
            return new ContoCorrenteBancario(codiceConto, saldoIniziale);
        }
    }
}
