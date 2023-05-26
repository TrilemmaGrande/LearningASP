using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel.DependencyInjectionBetter
{
    internal class Meister
    {
        private Lehrling lehrling;
        public Meister()
        {
            lehrling = new Lehrling(new Schaufel());
        }
        public void GibAnweisung()
        {
            lehrling.GrabMalEinLoch();
        }
    }
}
