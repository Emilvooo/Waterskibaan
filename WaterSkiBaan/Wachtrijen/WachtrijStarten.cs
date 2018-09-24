using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSkiBaan.Sporters;

namespace WaterSkiBaan.Wachtrijen
{
    class WachtrijStarten
    {
        public Queue<Sporter> Wachtrij;

        public void VoegSporterToeAanRij(Sporter sporter)
        {
            Wachtrij.Enqueue(sporter);
        }
    }
}
