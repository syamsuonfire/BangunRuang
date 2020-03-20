using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunRuang
{
    class BangunRuang // Class Parent
    {
        public int p;
        public int l;
        public int t;
        public int r;
        public int s;
        public double Volume;
        public double LuasPermukaan;

        public double phi = 22 / 7;

        public int HitungLuasPermukaan()
        {
            return 2 * (p * l + p * t + l * t);
        }

        public int HitungVolume()
        {
            return p * l * t;
        }

    }


}
