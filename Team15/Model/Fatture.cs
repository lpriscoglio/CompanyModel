using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class Fatture
    {
        private List<Fattura> _fatture;

        public Fatture()
        {
            _fatture = new List<Fattura>();
        }

        public IEnumerable<Fattura> GetFatture
        {
            get { return _fatture; }
        }

        public IEnumerable<FatturaAcquisto> GetFattureAcquisto()
        {
            List<FatturaAcquisto> list = new List<FatturaAcquisto>();
            foreach (Fattura fattura in _fatture)
            {
                if (fattura is FatturaAcquisto)
                {
                    list.Add((FatturaAcquisto) fattura);
                }
            }
            return list;
        }

        public IEnumerable<FatturaVendita> GetFattureVendita()
        {
            List<FatturaVendita> list = new List<FatturaVendita>();
            foreach (Fattura fattura in _fatture)
            {
                if (fattura is FatturaVendita)
                {
                    list.Add((FatturaVendita) fattura);
                }
            }
            return list;
        }

        public void AggiungiFattura(Fattura fattura)
        {
            _fatture.Add(fattura);
            Azienda.GetInstance().OnChanged();
        }

        public IEnumerable<FatturaAcquisto> GetFattureAcquistoDaPagare()
        {
            List<FatturaAcquisto> list = new List<FatturaAcquisto>();
            foreach (FatturaAcquisto fattura in Azienda.GetInstance().Fatture.GetFattureAcquisto())
            {
                if (!fattura.isPayed())
                {
                    list.Add(fattura);
                }
            }
            return list;
        }

        public IEnumerable<FatturaVendita> GetFattureVenditaDaPagare()
        {
            List<FatturaVendita> list = new List<FatturaVendita>();
            foreach (FatturaVendita fattura in Azienda.GetInstance().Fatture.GetFattureVendita())
            {
                if (!fattura.isPayed())
                {
                    list.Add(fattura);
                }
            }
            return list;
        }
    }

}
