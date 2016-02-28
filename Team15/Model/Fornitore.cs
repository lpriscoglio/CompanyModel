using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class Fornitore : Soggetto
    {

        public Fornitore(string denominazione, string telefono, string email, string partitaIva,Indirizzo indirizzo)
            : base(denominazione, telefono, email, partitaIva, indirizzo)
        {
            if (String.IsNullOrWhiteSpace(partitaIva))
                throw new ArgumentNullException("partitaIva");
            if (!ValidatePartitaIva(partitaIva))
                throw new ArgumentException("Partita Iva non valida");
            
        }

        public override string ToString()
        {
            return (this.Denominazione);
        }
    }
}
