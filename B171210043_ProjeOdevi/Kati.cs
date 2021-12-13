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
    class Kati : MeyveEzme
    {
        private const double minimumAgirlik = 70;
        private const double maximumAgirlik = 120;
        private const double minimumVerim = 30;
        private const double maximumVerim = 70;

        public Kati()
        {
            MaxAgirlik = maximumAgirlik;
            MinAgirlik = minimumAgirlik;
            MinVerim = minimumVerim;
            MaxVerim = maximumVerim;
        }
        

    }
}
