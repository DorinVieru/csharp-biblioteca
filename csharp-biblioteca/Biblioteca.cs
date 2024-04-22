using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Biblioteca
    {
        public List<Utente> Utenti { get; set; }
        public List<Documenti> Documenti { get; set; }
        public List<Prestito> Prestiti { get; set; }

        public Biblioteca()
        {
            Utenti = new List<Utente>();
            Documenti = new List<Documenti>();
            Prestiti = new List<Prestito>();
        }

        // FUNZIONE PER AGGIUNGERE UN UTENTE
        public void AggiungiUtente(Utente utente)
        {
            Utenti.Add(utente);
        }

        // FUNZIONE PER AGGIUNGERE UN DOCUMENTO
        public void AggiungiDocumento(Documenti documento)
        {
            Documenti.Add(documento);
        }

        // FUNZIONE PER AGGIUNGERE UN PRESTITO
        public void AggiungiPrestito(Prestito prestito)
        {
            Prestiti.Add(prestito);
        }

        // FUNZIONE PER RICERCARE UN UTENTE
        public Utente RicercaUtente(string nome, string cognome)
        {
            return Utenti.FirstOrDefault(u => u.Nome == nome && u.Cognome == cognome);
        }

        // FUNZIONE PER RICERCARE UN DOCUMENTO PER CODICE
        public Documenti RicercaDocumentoCod(string codice)
        {
            return Documenti.FirstOrDefault(d => d.Codice == codice);
        }

        // FUNZIONE PER RICERCARE UN DOCUMENTO PER TITOLO
        public Documenti RicercaDocumentoTitolo(string titolo)
        {
            return Documenti.FirstOrDefault(d => d.Titolo == titolo);
        }

        // FUNZIONE PER RICERCARE UN PRESTITO PER NOME E COGNOME UTENTE
        public List<Prestito> RicercaPrestitiPerUtente(string nome, string cognome)
        {
            var utente = RicercaUtente(nome, cognome);
            return Prestiti.Where(p => p.Utente == utente).ToList();
        }
    }
}
