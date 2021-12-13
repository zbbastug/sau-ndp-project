/* B171210043 ZEYNEP BURCU BASTUG
    NESNEYE DAYALI PROGRAMLAMA DERSI PROJE ODEVI
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B171210043_ProjeOdevi
{
    class Greyfurt : Sivi
    {
        private const double vitA = 3.0;
        private const double vitC = 44.0;

        public Greyfurt()
        {
            tur = 0;
            agirlikUret();
            verimUret();
            YeniAgirlik();
            yeniVitaminA(vitA);
            yeniVitaminC(vitC);
            Path = Directory.GetCurrentDirectory() + "\\..\\..\\..\\meyve\\greyfurt.jpg";
        }
    
    }
}
