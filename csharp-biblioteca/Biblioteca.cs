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

        
    }
}
