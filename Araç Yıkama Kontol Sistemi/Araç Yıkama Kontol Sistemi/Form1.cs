using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Araç_Yıkama_Kontol_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_normal_yikama_Click(object sender, EventArgs e)
        {
            if (lbl_secenkk.Text == "2")
                MessageBox.Show("Önce İptal Ediniz!");
            else
            {
                lbl_secenkk.Text = "1";
                lbl_yikama_sekli.Text = "Normal Yıkama";
                lbl_yikama_süresi.Text = "10 Saniye";
                lbl_yikama_süresi.BackColor = Color.LightBlue;
                lbl_yikama_sekli.BackColor = Color.LightBlue;
            }
        }

        private void btn_kopuklu_yikama_Click(object sender, EventArgs e)
        {
            if (lbl_secenkk.Text == "1")
                MessageBox.Show("Önce İptal Ediniz!");
            else
            {
                lbl_secenkk.Text = "2";
                lbl_yikama_sekli.Text = "Köpüklü Yıkama";
                lbl_yikama_sekli.BackColor = Color.LightGreen;
                lbl_yikama_süresi.Text = "15 Saniye";
                lbl_yikama_süresi.BackColor = Color.LightGreen;
            }
        }

        private void btn_yikama_baslat_Click(object sender, EventArgs e)
        {
            if (lbl_secenkk.Text == "0")
                MessageBox.Show("Yıkama Türünü Seçiniz!");

            else if (lbl_secenkk.Text == "1")
            {
                this.BackColor = Color.LightBlue;
                MessageBox.Show("Normal Yıkama Başlıyor!");
            }

            else if (lbl_secenkk.Text == "2")
            {
                this.BackColor = Color.LightGreen;
                MessageBox.Show("Köpüklü Yıkama Başlıyor!");
            }
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            lbl_secenkk.Text = "0";
            this.BackColor = Color.Yellow;
            lbl_yikama_sekli.Text = "Seçilmedi";
            lbl_yikama_süresi.Text = "00";
            lbl_yikama_sekli.BackColor = Color.Yellow;
            lbl_yikama_süresi.BackColor = Color.Yellow;

        }

        private void btn_durdur_Click(object sender, EventArgs e)
        {
            lbl_secenkk.Text = "0";
            this.BackColor = Color.Red;
            lbl_yikama_sekli.Text = "Seçilmedi";
            lbl_yikama_süresi.Text = "00";
            lbl_yikama_sekli.BackColor = Color.Red;
            lbl_yikama_süresi.BackColor = Color.Red;
        }
    }
}
