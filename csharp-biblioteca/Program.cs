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
                Cognome = "Dorin",
                Nome = "Bot",
                Email = "bot.dorin@email.com",
                Password = "Lamiabellapassw",
                RecapitoTelefonico = "34967589867"
            };
            biblioteca.AggiungiUtente(utente);
            Console.WriteLine($"Nuovo utente registrato: {utente.Nome} {utente.Cognome}, {utente.RecapitoTelefonico}");

            // Creazione di un libro
            Libro libro = new Libro("LB346", "Io Sono il Padrone della mia Anima", 2018, "Crescita personale", "S1", "Salvatore Brizzi", 222);
            biblioteca.AggiungiDocumento(libro);
            Console.WriteLine($"Nuovo libro creato: {libro.Codice} {libro.Titolo}, {libro.Anno}, genere {libro.Settore}, di {libro.Autore}, {libro.NumeroPagine} pagine.");

            // Creazione di un DVD
            DVD dvd = new DVD("DVD077", "Matrix", 1999, "Sci-Fi (Realistico)", "B2", "Lana % Lily Wachowski", 136);
            biblioteca.AggiungiDocumento(dvd);
            Console.WriteLine($"Nuovo DVD creato: {dvd.Codice} {dvd.Titolo}, {dvd.Anno}, genere {dvd.Settore}, di {dvd.Autore}, {dvd.Durata} minuti.");

            
        }
    }
}
