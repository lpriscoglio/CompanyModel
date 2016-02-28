using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class Depositi
    {
        private List<DepositoDiDenaro> _depositi;

        public Depositi()
        {
            _depositi = new List<DepositoDiDenaro>();
        }

        public void AggiungiDeposito(DepositoDiDenaro deposito)
        {
            _depositi.Add(deposito);
            Azienda.GetInstance().OnChanged();
        }

        public IEnumerable<DepositoDiDenaro> GetDepositi
        {
            get { return _depositi; }
        }

    }
}
