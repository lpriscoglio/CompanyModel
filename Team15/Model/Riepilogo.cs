using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    abstract class Riepilogo
    {
        public Riepilogo()
        {
        }

        public abstract Currency GetImportiPagati();
        public abstract Currency GetImportiDaPagare();

    }
}
