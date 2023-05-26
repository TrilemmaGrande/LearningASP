using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel.DependencyInjectionRight
{
    internal class Lehrling
    {
        private Schaufel schaufel;
        public Lehrling(Schaufel schaufel)
        {
            this.schaufel = schaufel;
        }
        public void GrabMalEinLoch()
        {
            schaufel.Graben();
        }
    }
}
