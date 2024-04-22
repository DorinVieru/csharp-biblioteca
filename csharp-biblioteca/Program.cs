using static csharp_biblioteca.Documenti;

namespace csharp_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creazione di un'istanza della biblioteca
            Biblioteca biblioteca = new Biblioteca();

            // Creazione di un utente
            Utente utente = new Utente
            {
                Cognome = "Bot",
                Nome = "Dorin",
                Email = "bot.dorin@email.com",
                Password = "Lamiabellapassw",
                RecapitoTelefonico = "34967589867"
            };
            biblioteca.AggiungiUtente(utente);
            Console.WriteLine($"REGISTRAZIONE UTENTE \nNuovo utente registrato: {utente.Nome} {utente.Cognome}, {utente.RecapitoTelefonico}");

            // Creazione di un libro
            Libro libro = new Libro("LB346", "Io Sono il Padrone della mia Anima", 2018, "Crescita personale", "S1", "Salvatore Brizzi", 222);
            biblioteca.AggiungiDocumento(libro);
            Console.WriteLine($"\nREGISTRAZIONE NUOVO LIBRO \nNuovo libro creato: {libro.Codice} {libro.Titolo}, {libro.Anno}, genere {libro.Settore}, di {libro.Autore}, {libro.NumeroPagine} pagine.");

            // Creazione di un DVD
            DVD dvd = new DVD("DVD077", "Matrix", 1999, "Sci-Fi (Realistico)", "B2", "Lana % Lily Wachowski", 136);
            biblioteca.AggiungiDocumento(dvd);
            Console.WriteLine($"\nREGITRSAZIONE NUOVO DVD \nNuovo DVD creato: {dvd.Codice} {dvd.Titolo}, {dvd.Anno}, genere {dvd.Settore}, di {dvd.Autore}, {dvd.Durata} minuti.");

            // Ricerca di un documento per titolo
            Documenti documentoRicercato = biblioteca.RicercaDocumentoTitolo("Il Signore degli Anelli");
            if (documentoRicercato != null)
            {
                Console.WriteLine($"\nRISULTATI RICERCA\nRisultato per la ricerca di un libro: {documentoRicercato.Titolo}");
            }
            else
            {
                Console.WriteLine("\nRISULTATI RICERCA \nHai effettuato una ricerca per un libro, ma non ho trovato nulla nel mio catalogo.");
            }

            // Prestito di un documento
            Prestito prestito = new Prestito
            {
                Utente = utente,
                Documento = libro,
                DataInizio = DateTime.Now,
                DataFine = DateTime.Now.AddDays(7)
            };
            biblioteca.AggiungiPrestito(prestito);
            Console.WriteLine($"\nNUOVO PRESTITO \nNuovo prestito registrato: {prestito.Utente.Nome} {prestito.Utente.Cognome} per {prestito.Documento.Titolo}, in data {prestito.DataInizio}. Terminerà il {prestito.DataFine}");

            
        }
    }
}
