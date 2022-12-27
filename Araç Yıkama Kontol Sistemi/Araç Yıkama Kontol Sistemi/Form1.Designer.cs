namespace Araç_Yıkama_Kontol_Sistemi
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
            this.lbl_sayac = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_secenkk = new System.Windows.Forms.Label();
            this.lbl_yikama_süresi = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_yikama_baslat = new System.Windows.Forms.Button();
            this.lbl_yikama_sekli = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_iptal = new System.Windows.Forms.Button();
            this.btn_kopuklu_yikama = new System.Windows.Forms.Button();
            this.btn_normal_yikama = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_sayac
            // 
            this.lbl_sayac.AutoSize = true;
            this.lbl_sayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_sayac.Location = new System.Drawing.Point(400, 642);
            this.lbl_sayac.Name = "lbl_sayac";
            this.lbl_sayac.Size = new System.Drawing.Size(39, 29);
            this.lbl_sayac.TabIndex = 51;
            this.lbl_sayac.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(46, 642);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 29);
            this.label5.TabIndex = 50;
            this.label5.Text = "Yıkama Şu Süre İçinde Bitecek:";
            // 
            // lbl_secenkk
            // 
            this.lbl_secenkk.AutoSize = true;
            this.lbl_secenkk.Location = new System.Drawing.Point(721, 40);
            this.lbl_secenkk.Name = "lbl_secenkk";
            this.lbl_secenkk.Size = new System.Drawing.Size(14, 16);
            this.lbl_secenkk.TabIndex = 49;
            this.lbl_secenkk.Text = "0";
            // 
            // lbl_yikama_süresi
            // 
            this.lbl_yikama_süresi.AutoSize = true;
            this.lbl_yikama_süresi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_yikama_süresi.Location = new System.Drawing.Point(313, 445);
            this.lbl_yikama_süresi.Name = "lbl_yikama_süresi";
            this.lbl_yikama_süresi.Size = new System.Drawing.Size(39, 29);
            this.lbl_yikama_süresi.TabIndex = 47;
            this.lbl_yikama_süresi.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(46, 445);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 29);
            this.label4.TabIndex = 46;
            this.label4.Text = "Seçilen Yıkama Süresi:";
            // 
            // btn_yikama_baslat
            // 
            this.btn_yikama_baslat.BackColor = System.Drawing.Color.Lime;
            this.btn_yikama_baslat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_yikama_baslat.Location = new System.Drawing.Point(195, 511);
            this.btn_yikama_baslat.Name = "btn_yikama_baslat";
            this.btn_yikama_baslat.Size = new System.Drawing.Size(199, 63);
            this.btn_yikama_baslat.TabIndex = 45;
            this.btn_yikama_baslat.Text = "Yıkamayı Başlat";
            this.btn_yikama_baslat.UseVisualStyleBackColor = false;
            this.btn_yikama_baslat.Click += new System.EventHandler(this.btn_yikama_baslat_Click);
            // 
            // lbl_yikama_sekli
            // 
            this.lbl_yikama_sekli.AutoSize = true;
            this.lbl_yikama_sekli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_yikama_sekli.Location = new System.Drawing.Point(298, 378);
            this.lbl_yikama_sekli.Name = "lbl_yikama_sekli";
            this.lbl_yikama_sekli.Size = new System.Drawing.Size(121, 29);
            this.lbl_yikama_sekli.TabIndex = 44;
            this.lbl_yikama_sekli.Text = "Seçilmedi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(46, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 29);
            this.label2.TabIndex = 43;
            this.label2.Text = "Seçilen Yıkama Şekli:";
            // 
            // btn_iptal
            // 
            this.btn_iptal.BackColor = System.Drawing.Color.Red;
            this.btn_iptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_iptal.Location = new System.Drawing.Point(449, 520);
            this.btn_iptal.Name = "btn_iptal";
            this.btn_iptal.Size = new System.Drawing.Size(165, 47);
            this.btn_iptal.TabIndex = 42;
            this.btn_iptal.Text = "İptal";
            this.btn_iptal.UseVisualStyleBackColor = false;
            this.btn_iptal.Click += new System.EventHandler(this.btn_iptal_Click);
            // 
            // btn_kopuklu_yikama
            // 
            this.btn_kopuklu_yikama.BackColor = System.Drawing.Color.Lime;
            this.btn_kopuklu_yikama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_kopuklu_yikama.Location = new System.Drawing.Point(427, 209);
            this.btn_kopuklu_yikama.Name = "btn_kopuklu_yikama";
            this.btn_kopuklu_yikama.Size = new System.Drawing.Size(201, 47);
            this.btn_kopuklu_yikama.TabIndex = 41;
            this.btn_kopuklu_yikama.Text = "Köpüklü Yıkama";
            this.btn_kopuklu_yikama.UseVisualStyleBackColor = false;
            this.btn_kopuklu_yikama.Click += new System.EventHandler(this.btn_kopuklu_yikama_Click);
            // 
            // btn_normal_yikama
            // 
            this.btn_normal_yikama.BackColor = System.Drawing.Color.Cyan;
            this.btn_normal_yikama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_normal_yikama.Location = new System.Drawing.Point(159, 209);
            this.btn_normal_yikama.Name = "btn_normal_yikama";
            this.btn_normal_yikama.Size = new System.Drawing.Size(195, 47);
            this.btn_normal_yikama.TabIndex = 40;
            this.btn_normal_yikama.Text = "Normal Yıkama";
            this.btn_normal_yikama.UseVisualStyleBackColor = false;
            this.btn_normal_yikama.Click += new System.EventHandler(this.btn_normal_yikama_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(244, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 36);
            this.label1.TabIndex = 39;
            this.label1.Text = "Araç Yıkama Sistemi";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.Location = new System.Drawing.Point(51, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 47);
            this.button1.TabIndex = 52;
            this.button1.Text = "Araba";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button2.Location = new System.Drawing.Point(299, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(195, 47);
            this.button2.TabIndex = 53;
            this.button2.Text = "Kamyon";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button3.Location = new System.Drawing.Point(544, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 47);
            this.button3.TabIndex = 54;
            this.button3.Text = "Otobüs";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(45, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 31);
            this.label3.TabIndex = 55;
            this.label3.Text = "Yıkama Fiyatı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(238, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 31);
            this.label6.TabIndex = 56;
            this.label6.Text = "00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(799, 705);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_sayac);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_secenkk);
            this.Controls.Add(this.lbl_yikama_süresi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_yikama_baslat);
            this.Controls.Add(this.lbl_yikama_sekli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_iptal);
            this.Controls.Add(this.btn_kopuklu_yikama);
            this.Controls.Add(this.btn_normal_yikama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Araba Yıkama Kontrol Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sayac;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_secenkk;
        private System.Windows.Forms.Label lbl_yikama_süresi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_yikama_baslat;
        private System.Windows.Forms.Label lbl_yikama_sekli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_iptal;
        private System.Windows.Forms.Button btn_kopuklu_yikama;
        private System.Windows.Forms.Button btn_normal_yikama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}

