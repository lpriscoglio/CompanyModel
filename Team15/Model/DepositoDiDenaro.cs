using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public abstract class DepositoDiDenaro : ContenitoreDiDenaro
    {
        protected DepositoDiDenaro(Currency saldoIniziale)
            : base(saldoIniziale)
        {}

        public override abstract string ToString();
    }
}
