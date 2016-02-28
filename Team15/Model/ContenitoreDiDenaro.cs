using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public abstract class ContenitoreDiDenaro : IDestinazione,ISorgente
    {
        private readonly Currency _saldoIniziale;

        protected ContenitoreDiDenaro(Currency saldoIniziale)
        {
            _saldoIniziale = saldoIniziale;
        }

        protected ContenitoreDiDenaro()
        {
            _saldoIniziale = new Currency(0m);
        }

        protected Currency SaldoIniziale
        {
            get { return _saldoIniziale; }
        }

        public Currency Importo
        {
            get { return Saldo(); }
        }
           
        public abstract Currency Saldo();

        public override abstract string ToString();

    }
}
