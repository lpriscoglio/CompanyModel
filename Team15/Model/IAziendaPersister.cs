using System;
using System.Collections.Generic;
using System.Text;

namespace Team15.Model
{
    public interface IAziendaPersister
    {
        IAziendaLoader GetLoader();
        void Save(Azienda azienda);
    }

    public interface IAziendaLoader
    {
        Dipendenti LoadDipendenti();
        Movimenti LoadMovimenti();
        Prodotti LoadProdotti();
        Depositi LoadDepositi();
        Soggetti LoadSoggetti();
        Cassa LoadCassa();
        Fatture LoadFatture();
    }
}
