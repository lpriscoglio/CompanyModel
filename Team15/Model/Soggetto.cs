using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public abstract class Soggetto
    {
        private readonly string _denominazione;
        private string _telefono;
        private string _email;
        private readonly string _partitaIva;
        private Indirizzo _indirizzo;

        protected Soggetto(string denominazione, string telefono, string email, string partitaIva, Indirizzo indirizzo)
        {
            if (String.IsNullOrWhiteSpace(denominazione))
                throw new ArgumentNullException("denominazione mancante");
            if (String.IsNullOrWhiteSpace(telefono))
                throw new ArgumentNullException("telefono mancante");
            if (String.IsNullOrWhiteSpace(email))
                throw new ArgumentNullException("email mancante");
            if (indirizzo == null)
                throw new ArgumentNullException("indirizzo mancante");

            _denominazione = denominazione;
            _telefono = telefono;
            _indirizzo = indirizzo;
            _partitaIva = partitaIva;

            if (ValidateEmail(email))
            {
                _email = email;
            }
            else
            {
                throw new ArgumentException("Email non valida");
            }              
         }

        public string Denominazione
        {
            get { return _denominazione; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (ValidateEmail(value))
                    _email = value;
                else
                    throw new ArgumentException("Email non valida");
            }
        }

        public string PartitaIva
        {
            get { return _partitaIva; }
        }

        public Indirizzo Indirizzo
        {
            get { return _indirizzo; }
        }

        //Ci limitiamo a dei controlli superficiali sulla partita iva e sull'email

        protected bool ValidatePartitaIva(string partitaIva)
        {
            return (partitaIva.Length == 11 ? true : false);
        }

        private bool ValidateEmail(string email)
        {
            return (email.Contains("@") ? true : false);
        }
    }
}
