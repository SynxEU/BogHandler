using System.Security.Authentication.ExtendedProtection;

namespace BogHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "De syv små dværge";
            string forfatter = "H.C. Andersen";
            int antalSider = 172;
            double pris;
            string forNavn, efterNavn, fuldeNavn, adresse, prisen;
            Boghandler boghandler = new Boghandler();
            string str = boghandler.Sælg(title, forfatter, antalSider);
            
            Console.Write("Indtast fornavn: ");
            forNavn = Console.ReadLine();
            Console.Write("Indtast efternavn: ");
            efterNavn = Console.ReadLine();
            fuldeNavn = forNavn + efterNavn;
            Console.Write("Indtast adresse: ");
            adresse = Console.ReadLine();
            Console.Write("Indtast en pris (eksempel \"149\"): ");
            prisen = Console.ReadLine();
            Double.TryParse(prisen, out pris);

            Console.Clear();
            Console.WriteLine($"{str} - Pris: {pris}");
        }
    }
}
