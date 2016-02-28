using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class Azienda
    {
        //Singleton
        private Dipendenti _dipendenti;
        private Movimenti _movimenti;
        private Prodotti _prodotti;
        private Depositi _depositi;
        private Soggetti _soggetti;
        private Fatture _fatture;
        private Cassa _cassa;

        public event EventHandler Changed;
        private static Azienda _instance = null;

        private Azienda(decimal saldoCassa)
        {
            _dipendenti = new Dipendenti();
            _movimenti = new Movimenti();
            _prodotti = new Prodotti();
            _depositi = new Depositi();
            _soggetti = new Soggetti();
            _fatture = new Fatture();
            _cassa = new Cassa(new Currency(saldoCassa));
        }

        private Azienda()
        {
            _dipendenti = new Dipendenti();
            _movimenti = new Movimenti();
            _prodotti = new Prodotti();
            _depositi = new Depositi();
            _soggetti = new Soggetti();
            _fatture = new Fatture();
            _cassa = new Cassa(new Currency(0m));
            
        }

        public static Azienda GetInstance()
        {
            if (_instance == null)
                _instance = new Azienda();
            return _instance;
        }

        public Dipendenti Dipendenti
        {
            get { return _dipendenti; }
        }

        public Prodotti Prodotti
        {
            get { return _prodotti; }
        }

        public Movimenti Movimenti
        {
            get { return _movimenti; }
        }

        public Depositi Depositi
        {
            get { return _depositi; }
        }

        public Fatture Fatture
        {
            get { return _fatture; }
        }

        public Soggetti Soggetti
        {
            get { return _soggetti; }
        }

        public Cassa Cassa
        {
            get { return _cassa; }
        }

       public IEnumerable<RigaFatturaVendita> GetRighe(FatturaVendita fattura)
        {
            return fattura.RigheFattura;
        }
               
        public virtual void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty);
        }
        
        public void Load(IAziendaPersister persister)
        {
            if (persister == null)
                throw new ArgumentNullException("persister");
            IAziendaLoader loader = persister.GetLoader();
            _dipendenti = loader.LoadDipendenti();
            _movimenti = loader.LoadMovimenti();
            _prodotti = loader.LoadProdotti();
            _depositi = loader.LoadDepositi();
            _soggetti = loader.LoadSoggetti();
            _cassa = loader.LoadCassa();
            _fatture = loader.LoadFatture();
        }
       
    }
}
