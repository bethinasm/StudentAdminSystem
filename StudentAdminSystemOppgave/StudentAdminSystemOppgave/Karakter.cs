using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminSystemOppgave
{
    internal class Karakter
    {
        public Fag Fag { get; set; }
        public double KarakterTall { get; set; }

        public Karakter(Fag fagNavn, double tall)
        {
            Fag = fagNavn;
            KarakterTall = tall;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"");
        }
    }
}
