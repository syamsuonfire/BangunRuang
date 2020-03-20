using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunRuang
{
    class BangunRuangTabung : BangunRuang // Class Child
    {

        public double HitungLuasPermukaan()
        {
            return 2 * phi * r * (r + t);
        }

        public double HitungVolume()
        {
            return phi * r * r * t;
        }
    }
}