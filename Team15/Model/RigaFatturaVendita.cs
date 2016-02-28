using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class RigaFatturaVendita
    {
        private double _quantità;
        private Prodotto _prodotto;

        public RigaFatturaVendita(double quantità, Prodotto prodotto)
        {
            if (quantità < 0)
                throw new ArgumentException("Impossibile quantità negativa");

            _quantità = quantità;
            _prodotto = (Prodotto)prodotto.Clone();
        }

        public double Quantità
        {
            get { return _quantità; }
        }

        public Prodotto Prodotto
        {
            get { return _prodotto; }
        }
    }
}
