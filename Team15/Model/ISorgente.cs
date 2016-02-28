using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public interface ISorgente
    {
        Currency Importo
        {
            get;
        }

        string ToString();
    }
}
