using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Team15.Model
{
    public class Dipendente
    {
        private readonly string _username;
        private string _cognome;
        private string _nome;
        private string _password;
        private Ruolo _ruolo;

        public Dipendente(string username,string cognome,string nome,string password,Ruolo ruolo)
        {
            if (String.IsNullOrWhiteSpace(username))
                throw new ArgumentNullException("username mancante");
            if (String.IsNullOrWhiteSpace(cognome))
                throw new ArgumentNullException("cognome mancante");
            if (String.IsNullOrWhiteSpace(nome))
                throw new ArgumentNullException("nome mancante");
            if (String.IsNullOrWhiteSpace(password))
                throw new ArgumentNullException("password mancante");
            _username = username;
            _cognome = cognome;
            _nome = nome;
            _password = password;
            _ruolo = ruolo;
         }

        public string Username
        {
            get { return _username; }
        }

        public string Cognome
        {
            get { return _cognome; }
            set { _cognome = value; }

        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
               
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Ruolo Ruolo
        {
            get { return _ruolo; }
            set { _ruolo = value; }
        }

        public override string ToString()
        {
            return (this._nome + " " + this._cognome);
        }
    
    }
}
