using System;
using System.Collections.Generic;
using System.Text;

namespace Team15.Model
{
    public class ContatoreFattureVendita
    {
        private Dictionary<int, uint> _dizionario ;

        private static ContatoreFattureVendita _instance = null;

        private ContatoreFattureVendita()
        {
            _dizionario = new Dictionary<int, uint>();

        }

        public static ContatoreFattureVendita GetInstance()
        {
            if (_instance == null)
                _instance = new ContatoreFattureVendita();
            return _instance;
        }


        public uint GetNumero(DateTime data)
        {
            uint tmp = 1;
            if(_dizionario.ContainsKey(data.Year))
            {
                tmp = _dizionario[data.Year];
                tmp++;
                _dizionario[data.Year] = tmp;
            }
            else
            {
                _dizionario.Add(data.Year,tmp);
            }

            return tmp;
        }

    }
}