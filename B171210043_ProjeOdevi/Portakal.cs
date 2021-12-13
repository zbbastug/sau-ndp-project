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
    class Portakal : Sivi
    {
        private const double vitA = 225.0;
        private const double vitC = 45.0;

        public Portakal()
        {
            tur = 0;
            agirlikUret();
            verimUret();
            YeniAgirlik();
            yeniVitaminA(vitA);
            yeniVitaminC(vitC);
            Path = Directory.GetCurrentDirectory() + "\\..\\..\\..\\meyve\\portakal.jpg";
        }
    }
    
}
