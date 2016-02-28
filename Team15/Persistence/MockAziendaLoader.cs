using System;
using System.Collections.Generic;
using System.Text;
using Team15.Model;

namespace Team15.Persistence
{
    public class MockAziendaLoader : IAziendaLoader
    {
        private Dipendenti _dipendenti = new Dipendenti();
        private Prodotti _prodotti = new Prodotti();
        private Movimenti _movimenti = new Movimenti();
        private Soggetti _soggetti = new Soggetti();
        private Fatture _fatture = new Fatture();
        private Cassa _cassa = new Cassa(new Currency(100000m));
        private Depositi _depositi = new Depositi();
        
        public MockAziendaLoader()
        {
            Dipendente D1 = new Dipendente("Imperatore", "Bonaparte", "Napoleone", "corsica", Ruolo.Amministratore);
            Dipendente D2 = new Dipendente("PippoBaudo", "Baudo", "Pippo", "sanremo", Ruolo.Utente);
            Dipendente D3 = new Dipendente("lucarossi", "rossi", "luca", "1234", Ruolo.Utente);
            _dipendenti.AggiungiDipendente(D1);
            _dipendenti.AggiungiDipendente(D2);
            _dipendenti.AggiungiDipendente(D3);

            Prodotto P1 = new Prodotto("AAA00001", "matita hb", new Currency(0.5m));
            Prodotto P2 = new Prodotto("FAX12345", "laptop", new Currency(599m));
            Prodotto P3 = new Prodotto("GAS98765", "automobile", new Currency(12000m));
            Prodotto P4 = new Prodotto("ZZZ99999", "macchina del tempo", new Currency(10m));
            _prodotti.AggiungiProdotto(P1);
            _prodotti.AggiungiProdotto(P2);
            _prodotti.AggiungiProdotto(P3);
            _prodotti.AggiungiProdotto(P4);

            Cliente C1 = new Cliente("AAABBB11A99C123Z", "Clark Kent", "051111111", "superman@gmail.com", null,
                new Indirizzo("via Delle Moline", "1", "Bologna", "40100", "BO", "Italia"));
            Cliente C2 = new Cliente("MRCVRD55A13D234A", "Marco Verdi", "0721987654", "marco.verdi@yahoo.com", null,
                new Indirizzo("via Roma", "14", "Piobbico", "61020", "PU", "Italia"));
            Cliente C3 = new Cliente(null, "Microsoft S.p.A", "010000000003", "microsoft@gmail.com",
                "BOH12345678", new Indirizzo("Main Street", "1/a", "Sylicon Valley", "10000", "CA", "Stati Uniti"));
            Fornitore F1 = new Fornitore("Cartoleria Pitagora s.r.l.", "051223344", "pitagora@libero.it", "IT123456789",
                new Indirizzo("via Saragozza", "112", "Bologna", "40135", "BO", "Italia"));
            Fornitore F2 = new Fornitore("Electronics inc.", "02998877", "el-inc@elinc.com", "IT999999999",
                new Indirizzo("via Rizzoli", "23", "Bologna", "40100", "BO", "Italia"));
            _soggetti.AggiungiSoggetto((Soggetto)C1);
            _soggetti.AggiungiSoggetto((Soggetto)C2);
            _soggetti.AggiungiSoggetto((Soggetto)C3);
            _soggetti.AggiungiSoggetto((Soggetto)F1);
            _soggetti.AggiungiSoggetto((Soggetto)F2);

            DepositoDiDenaro DEP1 = DepositoDiDenaroFactory.CreateContoCorrenteBancario(new Currency(1000m), "IT89M0200801234000000123456");
            _depositi.AggiungiDeposito(DEP1);

            List<RigaFatturaVendita> righe1 = new List<RigaFatturaVendita>();
            RigaFatturaVendita riga1 = new RigaFatturaVendita(2, P1);
            RigaFatturaVendita riga2 = new RigaFatturaVendita(3, P2);
            righe1.Add(riga1);
            righe1.Add(riga2);
            List<RigaFatturaVendita> righe2 = new List<RigaFatturaVendita>();
            RigaFatturaVendita riga3 = new RigaFatturaVendita(2, P4);
            RigaFatturaVendita riga4 = new RigaFatturaVendita(3, P3);
            righe2.Add(riga3);
            righe2.Add(riga4);
            FatturaVendita FV1 = new FatturaVendita(righe2,C3);
            FatturaVendita FV2 = new FatturaVendita(new DateTime(2011,3,23),righe1,C2);
            FatturaAcquisto FA1 = new FatturaAcquisto(new DateTime(2011, 6, 1), 1234, new Currency(500m), F1);
            IncassoVendita IV1 = new IncassoVendita(DEP1, FV1, new DateTime(2011, 6, 1), "incasso fattura", D3);
            PagamentoAcquisto PA1 = new PagamentoAcquisto(new DateTime(2011, 6, 1), "pagamento fattura", D2, _cassa, FA1);
            _movimenti.AggiungiMovimento(IV1);
            _movimenti.AggiungiMovimento(PA1);
            _fatture.AggiungiFattura(FV1);
            _fatture.AggiungiFattura(FV2);
            _fatture.AggiungiFattura(FA1);
            FatturaVendita FV3 = new FatturaVendita(new DateTime(2012, 3, 23), righe1, C2);
            _fatture.AggiungiFattura(FV3);

            MovimentoInterno m1 =MovimentoInternoFactory.CreatePrelievo(new DateTime(2011, 6, 15), "boh", D2, new Currency(10m), DEP1, _cassa);
            _movimenti.AggiungiMovimento(m1);
        }


        public Dipendenti LoadDipendenti()
        {
            return _dipendenti;
        }

        public Prodotti LoadProdotti()
        {         
            return _prodotti;
        }

        public Movimenti LoadMovimenti()
        {
            return _movimenti;
        }

        public Soggetti LoadSoggetti()
        {             
            return _soggetti;
        }

        public Cassa LoadCassa()
        {
            return _cassa;
        }

        public Depositi LoadDepositi()
        {
            return _depositi;
        }

        public Fatture LoadFatture()
        {
            return _fatture;
        }


    }
}
