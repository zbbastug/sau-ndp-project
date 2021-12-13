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
    interface IMeyveEzme
    {

        String Path
        {
            get;
            set;
        }

        double MinAgirlik
        {
            get;
            set;
        }

        double MaxAgirlik
        {
            get;
            set;
        }

        double MaxVerim
        {
            get;
            set;
        }

        double MinVerim
        {
            get;
            set;
        }

        double Verim
        {
            get;
            set;
        }

        double Agirlik
        {
            get;
            set;
        }
        double VitA
        {
            get;
            set;
        }
        double VitC
        {
            get;
            set;
        }
        double yeniVitA
        {
            get;
            set;
        }
        double yeniVitC

        {
            get;
            set;
        }

        double YeniAgirlik();
        void verimUret();
        void yeniVitaminC( double vitC);
        void yeniVitaminA( double vitA);
        void agirlikUret();

    }
}
