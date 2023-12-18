using System.Security.Authentication.ExtendedProtection;

namespace BogHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bog> forlagBog = new List<Bog>();
            Forlag forlag = new Forlag();
            Boghandler boghandler = new Boghandler();
            do
            {
                string title;
                string forfatter;
                int antalSider, nr;
                //double pris;
                //string forNavn, efterNavn, fuldeNavn, adresse, prisen;

                Console.Write("Indtast titel: ");
                title = Console.ReadLine();
                Console.Write("Indtast forfatter: ");
                forfatter = Console.ReadLine();
                Console.Write("Indtast antal sider: ");
                antalSider = int.Parse(Console.ReadLine());

                /*Console.Write("Indtast fornavn: ");
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
                Console.WriteLine($"{str} - Pris: {pris}");*/

                if (forlagBog.Count() == 0)
                {
                    nr = 1;
                }
                else
                {
                    nr = forlagBog.Count() + 1;
                }

                forlagBog.Add(forlag.Modtag(title, forfatter, antalSider, nr));
                string str = boghandler.Sælg(title, forfatter, antalSider, nr);
                Console.WriteLine(str);
            } while (true);
        }
    }
}
