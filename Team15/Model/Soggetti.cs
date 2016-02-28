using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class Soggetti
    {
        private List<Soggetto> _soggetti;

        public Soggetti()
        {
            _soggetti = new List<Soggetto>();
        }

        public void AggiungiSoggetto(Soggetto soggetto)
        {
            _soggetti.Add(soggetto);
            Azienda.GetInstance().OnChanged();
        }

        public IEnumerable<Cliente> GetClienti()
        {
            List<Cliente> list = new List<Cliente>();
            foreach(Soggetto soggetto in _soggetti)
            {
                if(soggetto is Cliente)
                {
                    list.Add((Cliente) soggetto);
                }
            }
            return list;
        }

        public IEnumerable<Fornitore> GetFornitori()
        {
            List<Fornitore> list = new List<Fornitore>();
            foreach (Soggetto soggetto in _soggetti)
            {
                if (soggetto is Fornitore)
                {
                    list.Add((Fornitore)soggetto);
                }
            }
            return list;
        }


    }
}
