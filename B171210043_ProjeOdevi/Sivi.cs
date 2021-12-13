/* B171210043 ZEYNEP BURCU BASTUG
    NESNEYE DAYALI PROGRAMLAMA DERSI PROJE ODEVI
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B171210043_ProjeOdevi
{
    class Sivi : MeyveEzme
    {
        private const double minimumAgirlik = 70;
        private const double maximumAgirlik = 120;
        private const double minimumVerim = 80;
        private const double maximumVerim = 95;

        public Sivi()
        {
            MaxAgirlik = maximumAgirlik;
            MinAgirlik = minimumAgirlik;
            MinVerim = minimumVerim;
            MaxVerim = maximumVerim;
        }
    }
}
