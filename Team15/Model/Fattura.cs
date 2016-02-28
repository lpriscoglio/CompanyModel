using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public abstract class Fattura
    {
        protected DateTime _data;
        protected uint _numero;

        protected Fattura(DateTime data, uint numero)
        {
            if(data == null)
                throw new ArgumentNullException("Data nulla");
            if (numero < 0)
                throw new ArgumentException("Impossibile numero fattura negativo");
            _data = data;
            _numero = numero;
        }

        protected Fattura(uint numero)
        {
            if (numero < 0)
                throw new ArgumentException("Impossibile numero fattura negativo");
            _numero = numero;
            _data = DateTime.Today;
        }

        protected Fattura(DateTime data)
        {
            if (data == null)
                throw new ArgumentException("Data nulla");
            _numero = 0;
            _data = data;
        }

        protected Fattura()
        {
            _numero = 0;
            _data = DateTime.Today;
        }


        public DateTime Data
        {
            get { return _data; }
        }

        public uint Numero
        {
            get { return _numero; }
        }

        public abstract Currency Importo
        { get; }
    }
}
