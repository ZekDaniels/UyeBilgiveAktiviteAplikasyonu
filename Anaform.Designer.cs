namespace WindowsFormsApp3
{
    partial class ANAFORM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.egitim = new System.Windows.Forms.GroupBox();
            this.sinif = new System.Windows.Forms.ComboBox();
            this.lbl8 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.bolum = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.fakulte = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.kisi = new System.Windows.Forms.GroupBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.telno = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.adres = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.soyad = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.topluluk = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grvSil = new System.Windows.Forms.Button();
            this.girGorev = new System.Windows.Forms.TextBox();
            this.grvEkle = new System.Windows.Forms.Button();
            this.gorevler = new System.Windows.Forms.ListBox();
            this.ayrica = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.komite = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnPuanla = new System.Windows.Forms.Button();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.egitim.SuspendLayout();
            this.kisi.SuspendLayout();
            this.topluluk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // egitim
            // 
            this.egitim.BackColor = System.Drawing.Color.LightBlue;
            this.egitim.Controls.Add(this.sinif);
            this.egitim.Controls.Add(this.lbl8);
            this.egitim.Controls.Add(this.lbl7);
            this.egitim.Controls.Add(this.bolum);
            this.egitim.Controls.Add(this.lbl6);
            this.egitim.Controls.Add(this.fakulte);
            this.egitim.Location = new System.Drawing.Point(237, 8);
            this.egitim.Name = "egitim";
            this.egitim.Size = new System.Drawing.Size(202, 145);
            this.egitim.TabIndex = 3;
            this.egitim.TabStop = false;
            this.egitim.Text = "EĞİTİM BİLGİLERİ";
            // 
            // sinif
            // 
            this.sinif.FormattingEnabled = true;
            this.sinif.Items.AddRange(new object[] {
            "SINIF SEÇİNİZ",
            "HAZIRLIK",
            "1.SINIF",
            "2.SINIF",
            "3.SINIF",
            "4.SINIF",
            "MEZUN"});
            this.sinif.Location = new System.Drawing.Point(71, 71);
            this.sinif.Name = "sinif";
            this.sinif.Size = new System.Drawing.Size(121, 21);
            this.sinif.TabIndex = 6;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(17, 79);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(37, 13);
            this.lbl8.TabIndex = 4;
            this.lbl8.Text = "SINIF:";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(17, 53);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(48, 13);
            this.lbl7.TabIndex = 3;
            this.lbl7.Text = "BÖLÜM:";
            // 
            // bolum
            // 
            this.bolum.Location = new System.Drawing.Point(71, 45);
            this.bolum.Name = "bolum";
            this.bolum.Size = new System.Drawing.Size(121, 20);
            this.bolum.TabIndex = 2;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(7, 26);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(58, 13);
            this.lbl6.TabIndex = 1;
            this.lbl6.Text = "FAKÜLTE:";
            // 
            // fakulte
            // 
            this.fakulte.Location = new System.Drawing.Point(71, 19);
            this.fakulte.Name = "fakulte";
            this.fakulte.Size = new System.Drawing.Size(121, 20);
            this.fakulte.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.Control;
            this.btnEkle.Location = new System.Drawing.Point(237, 159);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(98, 39);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "ÜYE EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // kisi
            // 
            this.kisi.BackColor = System.Drawing.Color.LightBlue;
            this.kisi.Controls.Add(this.lbl4);
            this.kisi.Controls.Add(this.mail);
            this.kisi.Controls.Add(this.lbl3);
            this.kisi.Controls.Add(this.telno);
            this.kisi.Controls.Add(this.lbl5);
            this.kisi.Controls.Add(this.adres);
            this.kisi.Controls.Add(this.lbl2);
            this.kisi.Controls.Add(this.lbl1);
            this.kisi.Controls.Add(this.soyad);
            this.kisi.Controls.Add(this.ad);
            this.kisi.Location = new System.Drawing.Point(12, 8);
            this.kisi.Name = "kisi";
            this.kisi.Size = new System.Drawing.Size(219, 286);
            this.kisi.TabIndex = 2;
            this.kisi.TabStop = false;
            this.kisi.Text = "KİŞİSEL BİLGİLER";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(7, 109);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(35, 13);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "MAİL:";
            // 
            // mail
            // 
            this.mail.Location = new System.Drawing.Point(86, 102);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(120, 20);
            this.mail.TabIndex = 7;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(7, 83);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(59, 13);
            this.lbl3.TabIndex = 6;
            this.lbl3.Text = "TELEFON:";
            // 
            // telno
            // 
            this.telno.Location = new System.Drawing.Point(85, 76);
            this.telno.Name = "telno";
            this.telno.Size = new System.Drawing.Size(120, 20);
            this.telno.TabIndex = 5;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(4, 132);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(101, 13);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "ADRES BİLGİLERİ:";
            // 
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(6, 148);
            this.adres.Multiline = true;
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(206, 125);
            this.adres.TabIndex = 1;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(7, 57);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(47, 13);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "SOYAD:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(7, 31);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(25, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "AD:";
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(85, 50);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(121, 20);
            this.soyad.TabIndex = 1;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(85, 24);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(121, 20);
            this.ad.TabIndex = 0;
            // 
            // topluluk
            // 
            this.topluluk.BackColor = System.Drawing.Color.LightBlue;
            this.topluluk.Controls.Add(this.label4);
            this.topluluk.Controls.Add(this.grvSil);
            this.topluluk.Controls.Add(this.girGorev);
            this.topluluk.Controls.Add(this.grvEkle);
            this.topluluk.Controls.Add(this.gorevler);
            this.topluluk.Controls.Add(this.ayrica);
            this.topluluk.Controls.Add(this.label3);
            this.topluluk.Controls.Add(this.label2);
            this.topluluk.Controls.Add(this.komite);
            this.topluluk.Controls.Add(this.label1);
            this.topluluk.Location = new System.Drawing.Point(445, 8);
            this.topluluk.Name = "topluluk";
            this.topluluk.Size = new System.Drawing.Size(211, 286);
            this.topluluk.TabIndex = 4;
            this.topluluk.TabStop = false;
            this.topluluk.Text = "TOPLULUK BİLGİLERİ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "GÖREVİ GİR:";
            // 
            // grvSil
            // 
            this.grvSil.BackColor = System.Drawing.SystemColors.Control;
            this.grvSil.Location = new System.Drawing.Point(143, 132);
            this.grvSil.Name = "grvSil";
            this.grvSil.Size = new System.Drawing.Size(64, 35);
            this.grvSil.TabIndex = 16;
            this.grvSil.Text = "GÖREV SİL";
            this.grvSil.UseVisualStyleBackColor = false;
            this.grvSil.Click += new System.EventHandler(this.grvSil_Click_2);
            // 
            // girGorev
            // 
            this.girGorev.Location = new System.Drawing.Point(10, 72);
            this.girGorev.Name = "girGorev";
            this.girGorev.Size = new System.Drawing.Size(125, 20);
            this.girGorev.TabIndex = 15;
            // 
            // grvEkle
            // 
            this.grvEkle.BackColor = System.Drawing.SystemColors.Control;
            this.grvEkle.Location = new System.Drawing.Point(141, 67);
            this.grvEkle.Name = "grvEkle";
            this.grvEkle.Size = new System.Drawing.Size(64, 37);
            this.grvEkle.TabIndex = 14;
            this.grvEkle.Text = "GÖREV EKLE";
            this.grvEkle.UseVisualStyleBackColor = false;
            this.grvEkle.Click += new System.EventHandler(this.grvEkle_Click_1);
            // 
            // gorevler
            // 
            this.gorevler.FormattingEnabled = true;
            this.gorevler.Location = new System.Drawing.Point(11, 115);
            this.gorevler.Name = "gorevler";
            this.gorevler.Size = new System.Drawing.Size(126, 69);
            this.gorevler.TabIndex = 13;
            // 
            // ayrica
            // 
            this.ayrica.Location = new System.Drawing.Point(9, 201);
            this.ayrica.Multiline = true;
            this.ayrica.Name = "ayrica";
            this.ayrica.Size = new System.Drawing.Size(190, 79);
            this.ayrica.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "AYRICA;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "GÖREVLER:";
            // 
            // komite
            // 
            this.komite.FormattingEnabled = true;
            this.komite.Items.AddRange(new object[] {
            "KOMİTE SEÇİNİZ",
            "TEKNİK PROJELER KOMİTESİ"});
            this.komite.Location = new System.Drawing.Point(62, 21);
            this.komite.Name = "komite";
            this.komite.Size = new System.Drawing.Size(136, 21);
            this.komite.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "KOMİTE:";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 300);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(645, 176);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.Control;
            this.btnSil.Location = new System.Drawing.Point(341, 159);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(98, 39);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "ÜYE SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPuanla
            // 
            this.btnPuanla.BackColor = System.Drawing.SystemColors.Control;
            this.btnPuanla.Location = new System.Drawing.Point(341, 204);
            this.btnPuanla.Name = "btnPuanla";
            this.btnPuanla.Size = new System.Drawing.Size(98, 39);
            this.btnPuanla.TabIndex = 9;
            this.btnPuanla.Text = "PUANLAMA SİSTEMİ";
            this.btnPuanla.UseVisualStyleBackColor = false;
            this.btnPuanla.Click += new System.EventHandler(this.puanla_Click);
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.SystemColors.Control;
            this.btnguncelle.Location = new System.Drawing.Point(237, 204);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(98, 39);
            this.btnguncelle.TabIndex = 8;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = false;
            this.btnguncelle.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.Control;
            this.btnAra.Location = new System.Drawing.Point(237, 249);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(98, 39);
            this.btnAra.TabIndex = 10;
            this.btnAra.Text = "ÜYE ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.SystemColors.Control;
            this.btnTemizle.Location = new System.Drawing.Point(341, 249);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(98, 39);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // ANAFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 488);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnPuanla);
            this.Controls.Add(this.topluluk);
            this.Controls.Add(this.egitim);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.kisi);
            this.Name = "ANAFORM";
            this.Text = "ANAFORM";
            this.Load += new System.EventHandler(this.ANAFORM_Load);
            this.egitim.ResumeLayout(false);
            this.egitim.PerformLayout();
            this.kisi.ResumeLayout(false);
            this.kisi.PerformLayout();
            this.topluluk.ResumeLayout(false);
            this.topluluk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox egitim;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.TextBox bolum;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox fakulte;
        private System.Windows.Forms.GroupBox kisi;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox mail;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox telno;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.ComboBox sinif;
        private System.Windows.Forms.GroupBox topluluk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox komite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ayrica;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnPuanla;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.ListBox gorevler;
        private System.Windows.Forms.Button grvEkle;
        private System.Windows.Forms.TextBox girGorev;
        private System.Windows.Forms.Button grvSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnTemizle;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}