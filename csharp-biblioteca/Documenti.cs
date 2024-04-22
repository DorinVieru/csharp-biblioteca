using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    internal class Documenti
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

}
