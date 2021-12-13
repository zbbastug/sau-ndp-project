namespace B171210043_ProjeOdevi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.baslaButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.katiMeyveButton = new System.Windows.Forms.Button();
            this.siviMeyveButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yeniCVitDegerLabel = new System.Windows.Forms.Label();
            this.yeniCVitLabel = new System.Windows.Forms.Label();
            this.yeniADegerLabel = new System.Windows.Forms.Label();
            this.yeniAVitLabel = new System.Windows.Forms.Label();
            this.pureDegerLabel = new System.Windows.Forms.Label();
            this.pureLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toplamPureSiviDegerLabel = new System.Windows.Forms.Label();
            this.toplamPureSiviLabel = new System.Windows.Forms.Label();
            this.toplamCVitDegerLabel = new System.Windows.Forms.Label();
            this.toplamCVitLabel = new System.Windows.Forms.Label();
            this.toplamAVitDegerLabel = new System.Windows.Forms.Label();
            this.toplamAVitLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.vitCDegerLabel = new System.Windows.Forms.Label();
            this.vitCLabel = new System.Windows.Forms.Label();
            this.vitADegerLabel = new System.Windows.Forms.Label();
            this.vitALabel = new System.Windows.Forms.Label();
            this.gramDegerLabel = new System.Windows.Forms.Label();
            this.gramLabel = new System.Windows.Forms.Label();
            this.Hatalabel = new System.Windows.Forms.Label();
            this.toplamMeyve = new System.Windows.Forms.GroupBox();
            this.mandalinaDeger = new System.Windows.Forms.Label();
            this.greyfurtDeger = new System.Windows.Forms.Label();
            this.portakalDeger = new System.Windows.Forms.Label();
            this.cilekDeger = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.elmaDeger = new System.Windows.Forms.Label();
            this.armutDeger = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toplamMeyve.SuspendLayout();
            this.SuspendLayout();
            // 
            // baslaButton
            // 
            this.baslaButton.BackColor = System.Drawing.Color.DarkKhaki;
            this.baslaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.baslaButton.ForeColor = System.Drawing.SystemColors.Control;
            this.baslaButton.Location = new System.Drawing.Point(655, 106);
            this.baslaButton.Name = "baslaButton";
            this.baslaButton.Size = new System.Drawing.Size(148, 74);
            this.baslaButton.TabIndex = 0;
            this.baslaButton.Text = "BASLA";
            this.baslaButton.UseVisualStyleBackColor = false;
            this.baslaButton.Click += new System.EventHandler(this.baslaButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(43, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 293);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.Chocolate;
            this.label1.Location = new System.Drawing.Point(67, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "MEYVE FOTOĞRAFI";
            // 
            // katiMeyveButton
            // 
            this.katiMeyveButton.BackColor = System.Drawing.Color.Goldenrod;
            this.katiMeyveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.katiMeyveButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.katiMeyveButton.Location = new System.Drawing.Point(550, 187);
            this.katiMeyveButton.Name = "katiMeyveButton";
            this.katiMeyveButton.Size = new System.Drawing.Size(151, 83);
            this.katiMeyveButton.TabIndex = 3;
            this.katiMeyveButton.Text = "Katı Meyve Sıkacağı";
            this.katiMeyveButton.UseVisualStyleBackColor = false;
            this.katiMeyveButton.Click += new System.EventHandler(this.katiMeyveButton_Click);
            // 
            // siviMeyveButton
            // 
            this.siviMeyveButton.BackColor = System.Drawing.Color.Goldenrod;
            this.siviMeyveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.siviMeyveButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.siviMeyveButton.Location = new System.Drawing.Point(765, 187);
            this.siviMeyveButton.Name = "siviMeyveButton";
            this.siviMeyveButton.Size = new System.Drawing.Size(152, 83);
            this.siviMeyveButton.TabIndex = 4;
            this.siviMeyveButton.Text = "Sıvı Meyve Sıkacağı";
            this.siviMeyveButton.UseVisualStyleBackColor = false;
            this.siviMeyveButton.Click += new System.EventHandler(this.siviMeyveButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.yeniCVitDegerLabel);
            this.groupBox1.Controls.Add(this.yeniCVitLabel);
            this.groupBox1.Controls.Add(this.yeniADegerLabel);
            this.groupBox1.Controls.Add(this.yeniAVitLabel);
            this.groupBox1.Controls.Add(this.pureDegerLabel);
            this.groupBox1.Controls.Add(this.pureLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.Coral;
            this.groupBox1.Location = new System.Drawing.Point(429, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 166);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meyve Özellikleri";
            // 
            // yeniCVitDegerLabel
            // 
            this.yeniCVitDegerLabel.AutoSize = true;
            this.yeniCVitDegerLabel.Location = new System.Drawing.Point(203, 105);
            this.yeniCVitDegerLabel.Name = "yeniCVitDegerLabel";
            this.yeniCVitDegerLabel.Size = new System.Drawing.Size(0, 20);
            this.yeniCVitDegerLabel.TabIndex = 5;
            // 
            // yeniCVitLabel
            // 
            this.yeniCVitLabel.AutoSize = true;
            this.yeniCVitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.yeniCVitLabel.ForeColor = System.Drawing.Color.Maroon;
            this.yeniCVitLabel.Location = new System.Drawing.Point(6, 105);
            this.yeniCVitLabel.Name = "yeniCVitLabel";
            this.yeniCVitLabel.Size = new System.Drawing.Size(119, 20);
            this.yeniCVitLabel.TabIndex = 4;
            this.yeniCVitLabel.Text = "Yeni Vitamin C";
            // 
            // yeniADegerLabel
            // 
            this.yeniADegerLabel.AutoSize = true;
            this.yeniADegerLabel.Location = new System.Drawing.Point(203, 71);
            this.yeniADegerLabel.Name = "yeniADegerLabel";
            this.yeniADegerLabel.Size = new System.Drawing.Size(0, 20);
            this.yeniADegerLabel.TabIndex = 3;
            // 
            // yeniAVitLabel
            // 
            this.yeniAVitLabel.AutoSize = true;
            this.yeniAVitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.yeniAVitLabel.ForeColor = System.Drawing.Color.Maroon;
            this.yeniAVitLabel.Location = new System.Drawing.Point(6, 71);
            this.yeniAVitLabel.Name = "yeniAVitLabel";
            this.yeniAVitLabel.Size = new System.Drawing.Size(123, 20);
            this.yeniAVitLabel.TabIndex = 2;
            this.yeniAVitLabel.Text = "Yeni Vitamin A:";
            // 
            // pureDegerLabel
            // 
            this.pureDegerLabel.AutoSize = true;
            this.pureDegerLabel.Location = new System.Drawing.Point(203, 42);
            this.pureDegerLabel.Name = "pureDegerLabel";
            this.pureDegerLabel.Size = new System.Drawing.Size(0, 20);
            this.pureDegerLabel.TabIndex = 1;
            // 
            // pureLabel
            // 
            this.pureLabel.AutoSize = true;
            this.pureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pureLabel.ForeColor = System.Drawing.Color.Maroon;
            this.pureLabel.Location = new System.Drawing.Point(6, 42);
            this.pureLabel.Name = "pureLabel";
            this.pureLabel.Size = new System.Drawing.Size(116, 20);
            this.pureLabel.TabIndex = 0;
            this.pureLabel.Text = "Püre/Sıvı Hali:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Controls.Add(this.toplamPureSiviDegerLabel);
            this.groupBox2.Controls.Add(this.toplamPureSiviLabel);
            this.groupBox2.Controls.Add(this.toplamCVitDegerLabel);
            this.groupBox2.Controls.Add(this.toplamCVitLabel);
            this.groupBox2.Controls.Add(this.toplamAVitDegerLabel);
            this.groupBox2.Controls.Add(this.toplamAVitLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(755, 311);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 166);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toplam";
            // 
            // toplamPureSiviDegerLabel
            // 
            this.toplamPureSiviDegerLabel.AutoSize = true;
            this.toplamPureSiviDegerLabel.Location = new System.Drawing.Point(212, 103);
            this.toplamPureSiviDegerLabel.Name = "toplamPureSiviDegerLabel";
            this.toplamPureSiviDegerLabel.Size = new System.Drawing.Size(0, 20);
            this.toplamPureSiviDegerLabel.TabIndex = 5;
            // 
            // toplamPureSiviLabel
            // 
            this.toplamPureSiviLabel.AutoSize = true;
            this.toplamPureSiviLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.toplamPureSiviLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.toplamPureSiviLabel.Location = new System.Drawing.Point(6, 105);
            this.toplamPureSiviLabel.Name = "toplamPureSiviLabel";
            this.toplamPureSiviLabel.Size = new System.Drawing.Size(141, 20);
            this.toplamPureSiviLabel.TabIndex = 4;
            this.toplamPureSiviLabel.Text = "Toplam Sıvı/Püre:";
            // 
            // toplamCVitDegerLabel
            // 
            this.toplamCVitDegerLabel.AutoSize = true;
            this.toplamCVitDegerLabel.Location = new System.Drawing.Point(212, 74);
            this.toplamCVitDegerLabel.Name = "toplamCVitDegerLabel";
            this.toplamCVitDegerLabel.Size = new System.Drawing.Size(0, 20);
            this.toplamCVitDegerLabel.TabIndex = 3;
            // 
            // toplamCVitLabel
            // 
            this.toplamCVitLabel.AutoSize = true;
            this.toplamCVitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.toplamCVitLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.toplamCVitLabel.Location = new System.Drawing.Point(6, 71);
            this.toplamCVitLabel.Name = "toplamCVitLabel";
            this.toplamCVitLabel.Size = new System.Drawing.Size(151, 20);
            this.toplamCVitLabel.TabIndex = 2;
            this.toplamCVitLabel.Text = "Toplam C Vitamini:";
            // 
            // toplamAVitDegerLabel
            // 
            this.toplamAVitDegerLabel.AutoSize = true;
            this.toplamAVitDegerLabel.Location = new System.Drawing.Point(212, 33);
            this.toplamAVitDegerLabel.Name = "toplamAVitDegerLabel";
            this.toplamAVitDegerLabel.Size = new System.Drawing.Size(0, 20);
            this.toplamAVitDegerLabel.TabIndex = 1;
            // 
            // toplamAVitLabel
            // 
            this.toplamAVitLabel.AutoSize = true;
            this.toplamAVitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.toplamAVitLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.toplamAVitLabel.Location = new System.Drawing.Point(6, 30);
            this.toplamAVitLabel.Name = "toplamAVitLabel";
            this.toplamAVitLabel.Size = new System.Drawing.Size(150, 20);
            this.toplamAVitLabel.TabIndex = 0;
            this.toplamAVitLabel.Text = "Toplam A Vitamini:";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.timerLabel.ForeColor = System.Drawing.Color.OrangeRed;
            this.timerLabel.Location = new System.Drawing.Point(632, 22);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(0, 48);
            this.timerLabel.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox3.Controls.Add(this.vitCDegerLabel);
            this.groupBox3.Controls.Add(this.vitCLabel);
            this.groupBox3.Controls.Add(this.vitADegerLabel);
            this.groupBox3.Controls.Add(this.vitALabel);
            this.groupBox3.Controls.Add(this.gramDegerLabel);
            this.groupBox3.Controls.Add(this.gramLabel);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox3.ForeColor = System.Drawing.Color.SandyBrown;
            this.groupBox3.Location = new System.Drawing.Point(43, 453);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(229, 145);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Meyve";
            // 
            // vitCDegerLabel
            // 
            this.vitCDegerLabel.AutoSize = true;
            this.vitCDegerLabel.Location = new System.Drawing.Point(154, 91);
            this.vitCDegerLabel.Name = "vitCDegerLabel";
            this.vitCDegerLabel.Size = new System.Drawing.Size(0, 20);
            this.vitCDegerLabel.TabIndex = 5;
            // 
            // vitCLabel
            // 
            this.vitCLabel.AutoSize = true;
            this.vitCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.vitCLabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.vitCLabel.Location = new System.Drawing.Point(6, 91);
            this.vitCLabel.Name = "vitCLabel";
            this.vitCLabel.Size = new System.Drawing.Size(87, 20);
            this.vitCLabel.TabIndex = 4;
            this.vitCLabel.Text = "Vitamin C:";
            // 
            // vitADegerLabel
            // 
            this.vitADegerLabel.AutoSize = true;
            this.vitADegerLabel.Location = new System.Drawing.Point(154, 60);
            this.vitADegerLabel.Name = "vitADegerLabel";
            this.vitADegerLabel.Size = new System.Drawing.Size(0, 20);
            this.vitADegerLabel.TabIndex = 3;
            // 
            // vitALabel
            // 
            this.vitALabel.AutoSize = true;
            this.vitALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.vitALabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.vitALabel.Location = new System.Drawing.Point(6, 58);
            this.vitALabel.Name = "vitALabel";
            this.vitALabel.Size = new System.Drawing.Size(86, 20);
            this.vitALabel.TabIndex = 2;
            this.vitALabel.Text = "Vitamin A:";
            // 
            // gramDegerLabel
            // 
            this.gramDegerLabel.AutoSize = true;
            this.gramDegerLabel.Location = new System.Drawing.Point(154, 29);
            this.gramDegerLabel.Name = "gramDegerLabel";
            this.gramDegerLabel.Size = new System.Drawing.Size(0, 20);
            this.gramDegerLabel.TabIndex = 1;
            // 
            // gramLabel
            // 
            this.gramLabel.AutoSize = true;
            this.gramLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gramLabel.ForeColor = System.Drawing.Color.OliveDrab;
            this.gramLabel.Location = new System.Drawing.Point(6, 29);
            this.gramLabel.Name = "gramLabel";
            this.gramLabel.Size = new System.Drawing.Size(109, 20);
            this.gramLabel.TabIndex = 0;
            this.gramLabel.Text = "Meyve Gram:";
            // 
            // Hatalabel
            // 
            this.Hatalabel.AutoSize = true;
            this.Hatalabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Hatalabel.ForeColor = System.Drawing.Color.Red;
            this.Hatalabel.Location = new System.Drawing.Point(966, 144);
            this.Hatalabel.Name = "Hatalabel";
            this.Hatalabel.Size = new System.Drawing.Size(0, 25);
            this.Hatalabel.TabIndex = 12;
            // 
            // toplamMeyve
            // 
            this.toplamMeyve.BackColor = System.Drawing.Color.Cornsilk;
            this.toplamMeyve.Controls.Add(this.mandalinaDeger);
            this.toplamMeyve.Controls.Add(this.greyfurtDeger);
            this.toplamMeyve.Controls.Add(this.portakalDeger);
            this.toplamMeyve.Controls.Add(this.cilekDeger);
            this.toplamMeyve.Controls.Add(this.label11);
            this.toplamMeyve.Controls.Add(this.label10);
            this.toplamMeyve.Controls.Add(this.label9);
            this.toplamMeyve.Controls.Add(this.label8);
            this.toplamMeyve.Controls.Add(this.elmaDeger);
            this.toplamMeyve.Controls.Add(this.armutDeger);
            this.toplamMeyve.Controls.Add(this.label5);
            this.toplamMeyve.Controls.Add(this.label4);
            this.toplamMeyve.Location = new System.Drawing.Point(832, 511);
            this.toplamMeyve.Name = "toplamMeyve";
            this.toplamMeyve.Size = new System.Drawing.Size(237, 142);
            this.toplamMeyve.TabIndex = 13;
            this.toplamMeyve.TabStop = false;
            this.toplamMeyve.Text = "Toplam Meyve Sayisi";
            // 
            // mandalinaDeger
            // 
            this.mandalinaDeger.AutoSize = true;
            this.mandalinaDeger.Location = new System.Drawing.Point(90, 117);
            this.mandalinaDeger.Name = "mandalinaDeger";
            this.mandalinaDeger.Size = new System.Drawing.Size(0, 17);
            this.mandalinaDeger.TabIndex = 11;
            // 
            // greyfurtDeger
            // 
            this.greyfurtDeger.AutoSize = true;
            this.greyfurtDeger.Location = new System.Drawing.Point(90, 100);
            this.greyfurtDeger.Name = "greyfurtDeger";
            this.greyfurtDeger.Size = new System.Drawing.Size(0, 17);
            this.greyfurtDeger.TabIndex = 10;
            // 
            // portakalDeger
            // 
            this.portakalDeger.AutoSize = true;
            this.portakalDeger.Location = new System.Drawing.Point(90, 83);
            this.portakalDeger.Name = "portakalDeger";
            this.portakalDeger.Size = new System.Drawing.Size(0, 17);
            this.portakalDeger.TabIndex = 9;
            // 
            // cilekDeger
            // 
            this.cilekDeger.AutoSize = true;
            this.cilekDeger.Location = new System.Drawing.Point(90, 66);
            this.cilekDeger.Name = "cilekDeger";
            this.cilekDeger.Size = new System.Drawing.Size(0, 17);
            this.cilekDeger.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Çilek";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Portakal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "Greyfurt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Mandalina";
            // 
            // elmaDeger
            // 
            this.elmaDeger.AutoSize = true;
            this.elmaDeger.Location = new System.Drawing.Point(90, 29);
            this.elmaDeger.Name = "elmaDeger";
            this.elmaDeger.Size = new System.Drawing.Size(0, 17);
            this.elmaDeger.TabIndex = 3;
            // 
            // armutDeger
            // 
            this.armutDeger.AutoSize = true;
            this.armutDeger.Location = new System.Drawing.Point(90, 49);
            this.armutDeger.Name = "armutDeger";
            this.armutDeger.Size = new System.Drawing.Size(0, 17);
            this.armutDeger.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Armut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Elma";
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1166, 670);
            this.Controls.Add(this.toplamMeyve);
            this.Controls.Add(this.Hatalabel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.siviMeyveButton);
            this.Controls.Add(this.katiMeyveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.baslaButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toplamMeyve.ResumeLayout(false);
            this.toplamMeyve.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button baslaButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button katiMeyveButton;
        private System.Windows.Forms.Button siviMeyveButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label yeniCVitDegerLabel;
        private System.Windows.Forms.Label yeniCVitLabel;
        private System.Windows.Forms.Label yeniADegerLabel;
        private System.Windows.Forms.Label yeniAVitLabel;
        private System.Windows.Forms.Label pureDegerLabel;
        private System.Windows.Forms.Label pureLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label toplamPureSiviDegerLabel;
        private System.Windows.Forms.Label toplamPureSiviLabel;
        private System.Windows.Forms.Label toplamCVitDegerLabel;
        private System.Windows.Forms.Label toplamCVitLabel;
        private System.Windows.Forms.Label toplamAVitDegerLabel;
        private System.Windows.Forms.Label toplamAVitLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label vitCDegerLabel;
        private System.Windows.Forms.Label vitCLabel;
        private System.Windows.Forms.Label vitADegerLabel;
        private System.Windows.Forms.Label vitALabel;
        private System.Windows.Forms.Label gramDegerLabel;
        private System.Windows.Forms.Label gramLabel;
        private System.Windows.Forms.Label Hatalabel;
        private System.Windows.Forms.GroupBox toplamMeyve;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label elmaDeger;
        private System.Windows.Forms.Label armutDeger;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mandalinaDeger;
        private System.Windows.Forms.Label greyfurtDeger;
        private System.Windows.Forms.Label portakalDeger;
        private System.Windows.Forms.Label cilekDeger;
    }
}

