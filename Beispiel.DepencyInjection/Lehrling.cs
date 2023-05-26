using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel.DependencyInjectionWrong
{
    internal class Lehrling
    {
        private Schaufel schaufel;
        public Lehrling()
        {
            schaufel = new Schaufel();
        }
        public void GrabMalEinLoch()
        {
            schaufel.Graben();
        }
    }
}
