using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogHandler
{
    class Boghandler
    {
        public string Sælg(string title, string forfatter, int antalSider, int nr)
        {
            Bog bog = new Bog(title, forfatter, antalSider, nr);
            return $"Bog Nummer: {nr} - Titel: {title} - Forfatter: {forfatter} - {antalSider} sider";
        }
    }
}
