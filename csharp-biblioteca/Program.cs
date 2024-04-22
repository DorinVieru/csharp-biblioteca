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


            
        }
    }
}
