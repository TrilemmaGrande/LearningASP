using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beispiel.DependencyInjectionBetter
{
    internal class Lehrling
    {
        private IGrabwerkzeg grabwerkzeug;
        public Lehrling(IGrabwerkzeg grabwerkzeug)
        {
            this.grabwerkzeug = grabwerkzeug;
        }
        public void GrabMalEinLoch()
        {
            grabwerkzeug.Graben();
        }
    }
}
