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
    class Armut : Kati
    {
        private const double vitA = 25.0;
        private const double vitC = 5.0;

        public Armut()
        {
            tur = 1;
            agirlikUret();
            verimUret();
            YeniAgirlik();
            yeniVitaminA(vitA);
            yeniVitaminC(vitC);
            Path = Directory.GetCurrentDirectory() + "\\..\\..\\..\\meyve\\armut.jpg";
        }
    }
}
