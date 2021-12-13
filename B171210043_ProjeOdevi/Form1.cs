/* B171210043 ZEYNEP BURCU BASTUG
    NESNEYE DAYALI PROGRAMLAMA DERSI PROJE ODEVI
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B171210043_ProjeOdevi
{
    public partial class Form1 : Form
    {
        int timeLeft = 60;
        MeyveEzme meyve;
        double toplamAgirlik;
        double toplamVitaminA;
        double toplamVitaminC;
        int elma, armut, cilek, portakal, greyfurt, mandalina;

        public Form1()
        {
            InitializeComponent();
        }

        private void uretilenMeyve(MeyveEzme me)
        {
            //form uygulamasinda olusan degerleri yazdirma
            meyve = me;
            toplamAgirlik += meyve.YeniAgirlik();
            toplamVitaminC += meyve.yeniVitC;
            toplamVitaminA += meyve.yeniVitA;
            gramDegerLabel.Text = meyve.Agirlik.ToString();
            pureDegerLabel.Text = meyve.YeniAgirlik().ToString();
            yeniADegerLabel.Text = meyve.yeniVitA.ToString();
            yeniCVitDegerLabel.Text = meyve.yeniVitC.ToString();
            vitADegerLabel.Text = meyve.VitA.ToString();
            vitCDegerLabel.Text = meyve.VitC.ToString();
            pictureBox1.ImageLocation = meyve.Path;
            toplamPureSiviDegerLabel.Text = toplamAgirlik.ToString();
            toplamAVitDegerLabel.Text = toplamVitaminA.ToString();
            toplamCVitDegerLabel.Text = toplamVitaminC.ToString();
            elmaDeger.Text = elma.ToString();
            armutDeger.Text = armut.ToString();
            cilekDeger.Text = cilek.ToString();
            portakalDeger.Text = portakal.ToString();
            greyfurtDeger.Text = greyfurt.ToString();
            mandalinaDeger.Text = mandalina.ToString();

        }

    
        private MeyveEzme rastgeleMeyveUret()
        {
            //rastgele meyve olusturma
            Random rastgele = new Random();
            int random = rastgele.Next(0,6);
            if (random == 0) { mandalina++; return new Mandalina(); }
            else if (random == 1) { portakal++; return new Portakal(); }
            else if (random == 2) { greyfurt++; return new Greyfurt(); }
            else if (random == 3) { cilek++; return new Cilek(); }
            else if (random == 4) { armut++; return new Armut(); }
            else if (random == 5) { elma++;  return new Elma(); }
            else return meyve;
                
        }
        private void baslaButton_Click(object sender, EventArgs e)
        {
            baslaButton.Enabled = false;
            timer1.Start();
            timer1.Interval = 1000;
            meyve = rastgeleMeyveUret();
            gramDegerLabel.Text = meyve.Agirlik.ToString();
            vitADegerLabel.Text = meyve.VitA.ToString();
            vitCDegerLabel.Text = meyve.VitC.ToString();
            pictureBox1.ImageLocation = meyve.Path;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           //timer interval 1000 e ayarlandi cunku saniyeler hizla ilerliyordu.

            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timerLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                katiMeyveButton.Enabled = false;
                siviMeyveButton.Enabled = false;

            }
        }

        private void katiMeyveButton_Click(object sender, EventArgs e)
        {
            if (meyve.tur == 1)
            {
                Hatalabel.Text = "";
                uretilenMeyve(rastgeleMeyveUret());
            }
            else {
                Hatalabel.Text = "Hatalı seçim";
            }
              
        }

        private void siviMeyveButton_Click(object sender, EventArgs e)
        {
            if (meyve.tur == 0)
            {
                Hatalabel.Text = "";
                uretilenMeyve(rastgeleMeyveUret());
            }
            else
            {
                Hatalabel.Text = "Hatalı seçim";
            }
        }

    }
}
