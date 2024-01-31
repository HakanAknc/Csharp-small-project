using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci_Not_Kayit_Sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, ort;
            string durum;

            s1 = Convert.ToInt16(TxtSinav1.Text);
            s2 = Convert.ToInt16(TxtSinav2.Text);
            s3 = Convert.ToInt16(TxtSinav3.Text);
            ort = (s1 + s2 + s3) / 3;
            TxtOrtalama.Text = ort.ToString();
            if (ort >= 50)
            {
                durum = "Geçti";
            }
            else
            {
                durum = "Kaldı";
            }
            TxtDurum.Text = durum;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtDurum.Text != "" && TxtOrtalama.Text != "")
            {
                string adsoyad, ders, numara;
                adsoyad = TxtAdSoyad.Text;
                ders = comboBox1.Text;
                numara = maskedTextBox1.Text;
                listBox1.Items.Add(adsoyad + " - " + numara + " - " + ders + " - " + TxtOrtalama.Text + " - " + TxtDurum.Text);
                sayac++;
                label10.Text = "Kaydedilen Öğrenci Sayısı:" + sayac;
            }
            else
            {
                MessageBox.Show("Lütfen ortalama ve durum hesabını yapınız.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCizgi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("-------------------------------------------------------");
        }

        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac++;
            label10.Text = sayac.ToString();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            // Temizlemenin iki farklı yöntemi var
            //TxtAdSoyad.Text = "";    / 1.yöntem
            TxtAdSoyad.Clear();       // 2.yöntem
            TxtDurum.Clear();
            TxtOrtalama.Clear();
            TxtSinav1.Clear();
            TxtSinav2.Clear();
            TxtSinav3.Clear();
            maskedTextBox1.Clear();
            comboBox1.SelectedIndex = -1;   // -1 değeri olmadığı için temizler
            TxtAdSoyad.Focus();   // en son temizleme işlemi bittiğinde ad soyada focuslar
        }

        private void BtnMesjKutusu_Click(object sender, EventArgs e)
        {
            // MessageBox 4 tane parametre alır. (Mesj,Başlık,Button,İcon)
            MessageBox.Show("Öğrenci Kayıt Sistemine Hoşgeldiniz","Not Hesaplama",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
        }

        private void BtnForDongusu_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 10; i++)
            {
                listBox2.Items.Add(i + ".Merhaba");
            }
        }

        private void BtnForDongusu2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    listBox2.Items.Add(i);
                }
            }
        }

        private void BtnListBoxTemizle_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            int x = 1;
            while (x <= 10)
            {
                listBox2.Items.Add(x + ".While Döngüsü");
                x++;
            }
        }

        private void BtnDizi1_Click(object sender, EventArgs e)
        {
            string[] sehirler = { "Adana", "Ankara", "İstanbul", "Antalya", "Bursa", "Mersin"};
            TxtAdSoyad.Text = sehirler[4];
        }

        private void BtnDizi2_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 34, 66, 87, 32, 98, 104, 327, 78 };
            /*
            for (int i = 0; i< sayilar.Length; i++)   // for ile dizideki elemanların ekrana yazdırılması
            {
                listBox2.Items.Add(sayilar[i]);
            }
            */
            foreach(int k in sayilar)
            {
                //listBox2.Items.Add(k);
                if (k % 4 == 0)
                {
                    listBox2.Items.Add(k);
                }
            }
        }
    }
}
