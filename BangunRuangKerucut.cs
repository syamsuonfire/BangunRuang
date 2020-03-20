using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunRuang
{
    class BangunRuangKerucut : BangunRuang // Class Child
    {
        public double HitungLuasPermukaan()
        {
            return phi * r * (r + s);
        }
        public double HitungVolume()
        {
            return 0.333 * phi * r * r * t;
        }
    }
}
