namespace BogHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "De syv små dværge";
            string forfatter = "H.C. Andersen";
            int antalSider = 172;
            Boghandler boghandler = new Boghandler();
            string str = boghandler.Sælg(title, forfatter, antalSider);
            Console.WriteLine(str);

        }
    }
}
