using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel.DependencyInjectionBetter
{
    internal class Schaufel : IGrabwerkzeg
    {
        public void Graben()
        {
            Console.WriteLine("*grab* *grab* *grab* ...");
        }
    }
}
