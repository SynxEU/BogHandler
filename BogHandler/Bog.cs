using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BogHandler
{
    class Bog
    {
        public string Title { get; set; }
        public string Forfatter { get; set; }
        public int AntalSider { get; set; }
        public int Nr { get; set; }
        public Bog(string title, string forfatter, int antalSider, int nr)
        {
            Title = title;
            Forfatter = forfatter;
            AntalSider = antalSider;
            Nr = nr;
        }
    }
}
