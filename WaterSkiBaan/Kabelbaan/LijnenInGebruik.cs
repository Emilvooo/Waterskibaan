using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSkiBaan.Kabelbaan
{
    class LijnenInGebruik
    {
        LinkedList<Lijn> lijnen;
        Queue<Lijn> lijnenUitgerangeerd;

        void NeemLijnInGebruik(Lijn lijn)
        {
            lijnen.AddFirst(lijn);

            return;
        }

        void StelLijnBuitenGebruik(Lijn lijn)
        {
            lijnen.Remove(lijn);
            lijnenUitgerangeerd.Enqueue(lijn);

            return;
        }
    }
}
