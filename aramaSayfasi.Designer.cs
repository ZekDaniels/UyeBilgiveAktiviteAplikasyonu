namespace WindowsFormsApp3
{
    partial class aramaSayfasi
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
            this.btnAraForm = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.soyadAra = new System.Windows.Forms.TextBox();
            this.adAra = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.telnoAra = new System.Windows.Forms.TextBox();
            this.komiteAra = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.bolumAra = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.fakulteAra = new System.Windows.Forms.TextBox();
            this.btnTemizleAraForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAraForm
            // 
            this.btnAraForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnAraForm.Location = new System.Drawing.Point(243, 266);
            this.btnAraForm.Name = "btnAraForm";
            this.btnAraForm.Size = new System.Drawing.Size(98, 55);
            this.btnAraForm.TabIndex = 11;
            this.btnAraForm.Text = "ÜYE ARA";
            this.btnAraForm.UseVisualStyleBackColor = false;
            this.btnAraForm.Click += new System.EventHandler(this.btnAraForm_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(68, 52);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(47, 13);
            this.lbl2.TabIndex = 15;
            this.lbl2.Text = "SOYAD:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(68, 26);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(25, 13);
            this.lbl1.TabIndex = 14;
            this.lbl1.Text = "AD:";
            // 
            // soyadAra
            // 
            this.soyadAra.Location = new System.Drawing.Point(144, 45);
            this.soyadAra.Name = "soyadAra";
            this.soyadAra.Size = new System.Drawing.Size(122, 20);
            this.soyadAra.TabIndex = 13;
            this.soyadAra.TextChanged += new System.EventHandler(this.aramaSayfasi_Load);
            // 
            // adAra
            // 
            this.adAra.Location = new System.Drawing.Point(144, 19);
            this.adAra.Name = "adAra";
            this.adAra.Size = new System.Drawing.Size(122, 20);
            this.adAra.TabIndex = 12;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(68, 78);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(59, 13);
            this.lbl3.TabIndex = 17;
            this.lbl3.Text = "TELEFON:";
            // 
            // telnoAra
            // 
            this.telnoAra.Location = new System.Drawing.Point(144, 71);
            this.telnoAra.Name = "telnoAra";
            this.telnoAra.Size = new System.Drawing.Size(122, 20);
            this.telnoAra.TabIndex = 16;
            // 
            // komiteAra
            // 
            this.komiteAra.FormattingEnabled = true;
            this.komiteAra.Items.AddRange(new object[] {
            "KOMİTE SEÇİNİZ",
            "TEKNİK PROJELER KOMİTESİ"});
            this.komiteAra.Location = new System.Drawing.Point(144, 148);
            this.komiteAra.Name = "komiteAra";
            this.komiteAra.Size = new System.Drawing.Size(122, 21);
            this.komiteAra.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "KOMİTE:";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(68, 130);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(48, 13);
            this.lbl7.TabIndex = 23;
            this.lbl7.Text = "BÖLÜM:";
            // 
            // bolumAra
            // 
            this.bolumAra.Location = new System.Drawing.Point(144, 123);
            this.bolumAra.Name = "bolumAra";
            this.bolumAra.Size = new System.Drawing.Size(122, 20);
            this.bolumAra.TabIndex = 22;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(68, 104);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(58, 13);
            this.lbl6.TabIndex = 21;
            this.lbl6.Text = "FAKÜLTE:";
            // 
            // fakulteAra
            // 
            this.fakulteAra.Location = new System.Drawing.Point(144, 97);
            this.fakulteAra.Name = "fakulteAra";
            this.fakulteAra.Size = new System.Drawing.Size(122, 20);
            this.fakulteAra.TabIndex = 20;
            // 
            // btnTemizleAraForm
            // 
            this.btnTemizleAraForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnTemizleAraForm.Location = new System.Drawing.Point(144, 266);
            this.btnTemizleAraForm.Name = "btnTemizleAraForm";
            this.btnTemizleAraForm.Size = new System.Drawing.Size(98, 55);
            this.btnTemizleAraForm.TabIndex = 24;
            this.btnTemizleAraForm.Text = "TEMİZLE";
            this.btnTemizleAraForm.UseVisualStyleBackColor = false;
            this.btnTemizleAraForm.Click += new System.EventHandler(this.btnTemizleAraForm_Click);
            // 
            // aramaSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(353, 333);
            this.Controls.Add(this.btnTemizleAraForm);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.bolumAra);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.fakulteAra);
            this.Controls.Add(this.komiteAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.telnoAra);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.soyadAra);
            this.Controls.Add(this.adAra);
            this.Controls.Add(this.btnAraForm);
            this.Name = "aramaSayfasi";
            this.Text = "Arama Sayfası";
            this.Load += new System.EventHandler(this.aramaSayfasi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAraForm;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox soyadAra;
        private System.Windows.Forms.TextBox adAra;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox telnoAra;
        private System.Windows.Forms.ComboBox komiteAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.TextBox bolumAra;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox fakulteAra;
        private System.Windows.Forms.Button btnTemizleAraForm;
    }
}