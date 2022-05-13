
namespace proje_otomasyon
{
    partial class giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(giris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.GirisPaneli = new System.Windows.Forms.Panel();
            this.buttonSifreUnut = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ySifretextBox = new System.Windows.Forms.TextBox();
            this.yPostaTextBox = new System.Windows.Forms.TextBox();
            this.yoneticiButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.hastatextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hastatextBox2 = new System.Windows.Forms.TextBox();
            this.hastabutton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dSifretextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dEpostaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.doktorButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.GirisPaneli.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hastane Otomasyon Sistemi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(235, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "HOŞGELDİNİZ ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(119, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 113);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 103);
            this.panel2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(11, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 85);
            this.button1.TabIndex = 8;
            this.button1.Text = "Yönetici Girişi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(13, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 85);
            this.button2.TabIndex = 9;
            this.button2.Text = "Doktor Girişi";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(15, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 85);
            this.button3.TabIndex = 10;
            this.button3.Text = "Hasta Girişi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(15, 286);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(149, 85);
            this.button4.TabIndex = 11;
            this.button4.Text = "Kaydol";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(-1, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 473);
            this.panel3.TabIndex = 12;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(15, 377);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 85);
            this.button5.TabIndex = 0;
            this.button5.Text = "İletişim";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // GirisPaneli
            // 
            this.GirisPaneli.Controls.Add(this.buttonSifreUnut);
            this.GirisPaneli.Controls.Add(this.groupBox1);
            this.GirisPaneli.Controls.Add(this.groupBox3);
            this.GirisPaneli.Controls.Add(this.groupBox2);
            this.GirisPaneli.Location = new System.Drawing.Point(290, 210);
            this.GirisPaneli.Name = "GirisPaneli";
            this.GirisPaneli.Size = new System.Drawing.Size(468, 358);
            this.GirisPaneli.TabIndex = 1;
            // 
            // buttonSifreUnut
            // 
            this.buttonSifreUnut.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSifreUnut.Location = new System.Drawing.Point(312, 305);
            this.buttonSifreUnut.Name = "buttonSifreUnut";
            this.buttonSifreUnut.Size = new System.Drawing.Size(138, 30);
            this.buttonSifreUnut.TabIndex = 1;
            this.buttonSifreUnut.Text = "Şifremi Unuttum";
            this.buttonSifreUnut.UseVisualStyleBackColor = true;
            this.buttonSifreUnut.Click += new System.EventHandler(this.buttonSifreUnut_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ySifretextBox);
            this.groupBox1.Controls.Add(this.yPostaTextBox);
            this.groupBox1.Controls.Add(this.yoneticiButton);
            this.groupBox1.Location = new System.Drawing.Point(21, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 242);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yönetici Giriş Bilgileri";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox2.Location = new System.Drawing.Point(344, 100);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(71, 22);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Göster";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "E-Posta:";
            // 
            // ySifretextBox
            // 
            this.ySifretextBox.Location = new System.Drawing.Point(136, 97);
            this.ySifretextBox.Multiline = true;
            this.ySifretextBox.Name = "ySifretextBox";
            this.ySifretextBox.PasswordChar = '*';
            this.ySifretextBox.Size = new System.Drawing.Size(200, 28);
            this.ySifretextBox.TabIndex = 2;
            // 
            // yPostaTextBox
            // 
            this.yPostaTextBox.Location = new System.Drawing.Point(136, 62);
            this.yPostaTextBox.Name = "yPostaTextBox";
            this.yPostaTextBox.Size = new System.Drawing.Size(200, 28);
            this.yPostaTextBox.TabIndex = 1;
            // 
            // yoneticiButton
            // 
            this.yoneticiButton.Location = new System.Drawing.Point(186, 152);
            this.yoneticiButton.Name = "yoneticiButton";
            this.yoneticiButton.Size = new System.Drawing.Size(119, 33);
            this.yoneticiButton.TabIndex = 0;
            this.yoneticiButton.Text = "Giriş";
            this.yoneticiButton.UseVisualStyleBackColor = true;
            this.yoneticiButton.Click += new System.EventHandler(this.yoneticiButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox3);
            this.groupBox3.Controls.Add(this.hastatextBox1);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.hastatextBox2);
            this.groupBox3.Controls.Add(this.hastabutton);
            this.groupBox3.Location = new System.Drawing.Point(21, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(420, 238);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hasta Giriş Bilgileri";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox3.Location = new System.Drawing.Point(301, 102);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(71, 22);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Göster";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // hastatextBox1
            // 
            this.hastatextBox1.Location = new System.Drawing.Point(147, 53);
            this.hastatextBox1.Mask = "00000000000";
            this.hastatextBox1.Name = "hastatextBox1";
            this.hastatextBox1.Size = new System.Drawing.Size(137, 28);
            this.hastatextBox1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Şifre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(87, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "TC:";
            // 
            // hastatextBox2
            // 
            this.hastatextBox2.Location = new System.Drawing.Point(147, 96);
            this.hastatextBox2.Multiline = true;
            this.hastatextBox2.Name = "hastatextBox2";
            this.hastatextBox2.PasswordChar = '*';
            this.hastatextBox2.Size = new System.Drawing.Size(137, 28);
            this.hastatextBox2.TabIndex = 12;
            // 
            // hastabutton
            // 
            this.hastabutton.Location = new System.Drawing.Point(197, 148);
            this.hastabutton.Name = "hastabutton";
            this.hastabutton.Size = new System.Drawing.Size(119, 33);
            this.hastabutton.TabIndex = 10;
            this.hastabutton.Text = "Giriş";
            this.hastabutton.UseVisualStyleBackColor = true;
            this.hastabutton.Click += new System.EventHandler(this.hastabutton_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dSifretextBox);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Controls.Add(this.dEpostaTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.doktorButton);
            this.groupBox2.Location = new System.Drawing.Point(21, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 242);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doktor Giriş Bilgileri";
            // 
            // dSifretextBox
            // 
            this.dSifretextBox.Location = new System.Drawing.Point(148, 108);
            this.dSifretextBox.Multiline = true;
            this.dSifretextBox.Name = "dSifretextBox";
            this.dSifretextBox.PasswordChar = '*';
            this.dSifretextBox.Size = new System.Drawing.Size(133, 22);
            this.dSifretextBox.TabIndex = 12;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(293, 109);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 22);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dEpostaTextBox
            // 
            this.dEpostaTextBox.Location = new System.Drawing.Point(148, 66);
            this.dEpostaTextBox.Mask = "00000000000";
            this.dEpostaTextBox.Name = "dEpostaTextBox";
            this.dEpostaTextBox.Size = new System.Drawing.Size(133, 28);
            this.dEpostaTextBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Şifre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "TC:";
            // 
            // doktorButton
            // 
            this.doktorButton.Location = new System.Drawing.Point(198, 158);
            this.doktorButton.Name = "doktorButton";
            this.doktorButton.Size = new System.Drawing.Size(119, 33);
            this.doktorButton.TabIndex = 5;
            this.doktorButton.Text = "Giriş";
            this.doktorButton.UseVisualStyleBackColor = true;
            this.doktorButton.Click += new System.EventHandler(this.doktorButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(172, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(698, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(190, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 23);
            this.label9.TabIndex = 15;
            this.label9.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(768, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 23);
            this.label10.TabIndex = 16;
            this.label10.Text = "label10";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 631);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GirisPaneli);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "giris";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.giris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.GirisPaneli.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ySifretextBox;
        private System.Windows.Forms.TextBox yPostaTextBox;
        private System.Windows.Forms.Button yoneticiButton;
        private System.Windows.Forms.Panel GirisPaneli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button doktorButton;
        private System.Windows.Forms.Button buttonSifreUnut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox hastatextBox2;
        private System.Windows.Forms.Button hastabutton;
        private System.Windows.Forms.MaskedTextBox dEpostaTextBox;
        private System.Windows.Forms.MaskedTextBox hastatextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox dSifretextBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
    }
}

