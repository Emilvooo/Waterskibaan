using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSkiBaan.SportOpslag;

namespace WaterSkiBaan.SportUitrusting
{
    class SkieOpslag : IOpslag
    {
        private Stack<Skies> _opslag;

        public void Afgeven(SportArtikel artikel)
        {
            _opslag.Push(artikel as Skies);
        }

        Skies PakSkies(Skies skies)
        {
            return skies;
        }
    }
}
