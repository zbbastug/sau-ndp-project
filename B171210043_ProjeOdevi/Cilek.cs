/* B171210043 ZEYNEP BURCU BASTUG
    NESNEYE DAYALI PROGRAMLAMA DERSI PROJE ODEVI 2021
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B171210043_ProjeOdevi
{
    class Cilek : Kati
    {
        private const double vitA = 12.0;
        private const double vitC = 60.0;

        public Cilek()
        {
            tur = 1;
            agirlikUret();
            verimUret();
            YeniAgirlik();
            yeniVitaminA(vitA);
            yeniVitaminC(vitC);
            Path = Directory.GetCurrentDirectory() + "\\..\\..\\..\\meyve\\cilek.jpg";
        }
    }
}
