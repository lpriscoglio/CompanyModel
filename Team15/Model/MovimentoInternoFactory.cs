using System;
using System.Collections.Generic;
using System.Text;

namespace Team15.Model
{
    static class MovimentoInternoFactory
    {
        public static MovimentoInterno CreatePrelievo(DateTime data,string causale,Dipendente dipendente,Currency importo,DepositoDiDenaro sorgente,Cassa destinazione)
        {
            return new MovimentoInterno(data,causale,dipendente,importo,sorgente,destinazione);
        }

        public static MovimentoInterno CreateSpostamento(DateTime data, string causale, Dipendente dipendente, Currency importo, DepositoDiDenaro sorgente, DepositoDiDenaro destinazione)
        {
            return new MovimentoInterno(data, causale, dipendente, importo, sorgente, destinazione);
        }

        public static MovimentoInterno CreateVersamento(DateTime data, string causale, Dipendente dipendente, Currency importo, Cassa sorgente, DepositoDiDenaro destinazione)
        {
            return new MovimentoInterno(data, causale, dipendente, importo, sorgente, destinazione);
        }
    }
}
