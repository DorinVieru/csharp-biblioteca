using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Documenti
    {
        public string Codice { get; set; }
        public string Titolo { get; set; }
        public int Anno { get; set; }
        public string Settore { get; set; }
        public string Scaffale { get; set; }
        public string Autore { get; set; }

        public Documenti(string codice, string titolo, int anno, string settore, string scaffale, string autore)
        {
            Codice = codice;
            Titolo = titolo;
            Anno = anno;
            Settore = settore;
            Scaffale = scaffale;
            Autore = autore;
        }

        public virtual void Prestito()
        {
            Console.WriteLine($"'{Titolo}' è stato preso in prestito.");
        }

        public virtual void Ritorno()
        {
            Console.WriteLine($"'{Titolo}' è stato restituito.");
        }
    }

    // SOTTOCLASSE PER I LIBRI
    public class Libro : Documenti
    {
        public int NumeroPagine { get; set; }

        public Libro(string codice, string titolo, int anno, string settore, string scaffale, string autore, int numeroPagine)
            : base(codice, titolo, anno, settore, scaffale, autore)
        {
            NumeroPagine = numeroPagine;
        }

        public override void Prestito()
        {
            base.Prestito();
            Console.WriteLine($"Libro: '{Titolo}' di {Autore}, {NumeroPagine} pagine, anno {Anno}, codice identificativo {Codice}, settore {Settore} e scaffale {Scaffale}.");
        }

        public override void Ritorno()
        {
            base.Ritorno();
            Console.WriteLine($"Libro: '{Titolo}' di {Autore}, {NumeroPagine} pagine, anno {Anno}, codice identificativo {Codice}, settore {Settore} e scaffale {Scaffale}.");
        }
    }

    // SOTTOCLASSE PER I DVD
    public class DVD : Documenti
    {
        public int Durata { get; set; } // Durata in minuti

        public DVD(string codice, string titolo, int anno, string settore, string scaffale, string autore, int durata)
            : base(codice, titolo, anno, settore, scaffale, autore)
        {
            Durata = durata;
        }

        public override void Prestito()
        {
            base.Prestito();
            Console.WriteLine($"DVD: '{Titolo}', Durata: {Durata} minuti, anno {Anno}, codice identificativo {Codice}, settore {Settore} e scaffale {Scaffale}.");
        }

        public override void Ritorno()
        {
            base.Ritorno();
            Console.WriteLine($"DVD: '{Titolo}', Durata: {Durata} minuti, anno {Anno}, codice identificativo {Codice}, settore {Settore} e scaffale {Scaffale}.");
        }
    }

}
