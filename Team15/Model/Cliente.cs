using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class Cliente : Soggetto
    {
        private readonly string _codiceFiscale = null;
        
        public Cliente(string codiceFiscale, string denominazione, string telefono, string email, string partitaIva, Indirizzo indirizzo)
            : base(denominazione, telefono, email, partitaIva, indirizzo)
        {
            if (String.IsNullOrWhiteSpace(partitaIva))
            {
                if (String.IsNullOrWhiteSpace(codiceFiscale))
                    throw new ArgumentNullException("inserire partita iva o codice fiscale");
                else if (ValidateCodiceFiscale(codiceFiscale))
                {
                    _codiceFiscale = codiceFiscale;
                }
                else
                {
                    throw new ArgumentException("codiceFiscale non valido");
                }
            }
            else if (!ValidatePartitaIva(partitaIva))
            {
                throw new ArgumentException("partita iva non valida");
            }
           
        }

        public string CodiceFiscale
        {
            get { return _codiceFiscale; }
        }

        private bool ValidateCodiceFiscale(string codiceFiscale)
        {
            return (codiceFiscale.Length == 16 ? true : false);
        }

        public override string ToString()
        {
            return Denominazione;
        }

    }
}
