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
    class MeyveEzme:IMeyveEzme
    {
        private double min_agirlik ;
        private double max_agirlik ;
        private double max_verim ;
        private double min_verim ;

        private double _agirlik;
        private double _verim;
        private double _vitA;
        private double _vitC;
        private double _yeniVitA;
        private double _yeniVitC;
        private String path;
        public int tur;
        protected Random rastgele = new Random();

        public String Path
        {
            get { return path; }
            set { path = value; }
        }

        public double MinAgirlik
        {
            get { return min_agirlik; }
            set {  min_agirlik=value; }

        }

        public double MaxAgirlik
        {
            get { return max_agirlik; }
            set { max_agirlik = value; }

        }

        public double MaxVerim
        {
            get { return max_verim; }
            set { max_verim = value; }
        }

        public double MinVerim
        {
            get { return min_verim; }
            set { min_verim = value; }
        }

        public double Verim
        {
            get { return _verim; }
            set { _verim = value; }
        }

        public double Agirlik
        {
            get { return _agirlik; }
            set { _agirlik = value; }
        }
        public double VitA
        {
            get { return _vitA; }
            set { _vitA = value; }
        }
        public double VitC
        {
            get { return _vitC; }
            set { _vitC = value; }
        }
        public double yeniVitA
        {
            get { return _yeniVitA; }
            set { _yeniVitA = value; }
        }
        public double yeniVitC

        {
            get { return _yeniVitC; }
            set { _yeniVitC = value; }
        }


        public void agirlikUret()
        {
            //rastgele agirlik uretme
            Random rastgele = new Random();
            Agirlik = Convert.ToDouble(rastgele.Next(Convert.ToInt32(MinAgirlik), Convert.ToInt32(MaxAgirlik)));

        }

        public void verimUret()
        {
            //rastgele verim uretme
            Random rastgele = new Random();
            Verim = Convert.ToDouble(rastgele.Next(Convert.ToInt32(MinVerim), Convert.ToInt32(MaxVerim)));
        }

        public double YeniAgirlik()
        {
            //yeni agirlik hesaplama
            return (Agirlik * Verim) / 100.0;

        }

        public void yeniVitaminA(double vitA)
        {
            //yeni A vit degeri hesaplama
            VitA = (Agirlik * vitA) / 100;
            yeniVitA = (YeniAgirlik() * vitA) / 100.0;

        }

        public void yeniVitaminC(double vitC)
        {
            //yeni C vit hesaplama
            VitC = (Agirlik * vitC) / 100;
            yeniVitC = (YeniAgirlik() * vitC) / 100.0;

        }
        
    }
}
