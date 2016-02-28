using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class Movimenti
    {
        private List<MovimentoDiDenaro> _movimenti;

        public Movimenti()
        {
            _movimenti = new List<MovimentoDiDenaro>();
        }

        public void AggiungiMovimento(MovimentoDiDenaro movimento)
        {
            _movimenti.Add(movimento);
            Azienda.GetInstance().OnChanged();
        }

        public IEnumerable<MovimentoDiDenaro> GetMovimenti
        {
            get { return _movimenti; }
        }

        public IEnumerable<MovimentoInterno> GetMovimentiInterni()
        {
            List<MovimentoInterno> list = new List<MovimentoInterno>();
            foreach (MovimentoDiDenaro movimento in _movimenti)
            {
                if (movimento is MovimentoInterno)
                {
                    list.Add((MovimentoInterno) movimento);
                }
            }
            return list;
        }

        public IEnumerable<PagamentoAcquisto> GetPagamenti()
        {
            List<PagamentoAcquisto> list = new List<PagamentoAcquisto>();
            foreach (MovimentoDiDenaro movimento in _movimenti)
            {
                if (movimento is PagamentoAcquisto)
                {
                    list.Add((PagamentoAcquisto)movimento);
                }
            }
            return list;
        }

        public IEnumerable<IncassoVendita> GetIncassi()
        {
            List<IncassoVendita> list = new List<IncassoVendita>();
            foreach (MovimentoDiDenaro movimento in _movimenti)
            {
                if (movimento is IncassoVendita)
                {
                    list.Add((IncassoVendita)movimento);
                }
            }
            return list;
        }
    }
}
