using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunRuang
{
    class BangunRuangBola : BangunRuang // Class Child
    {
        public double HitungLuasPermukaan()
        {
            return 4 * phi * r * r;
        }

        public double HitungVolume()
        {
            return 1.333 * phi * r * r * r;
        }
    }
}