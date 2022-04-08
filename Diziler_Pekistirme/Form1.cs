using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diziler_Pekistirme
{
    public partial class lbl_Ad : Form
    {
        public lbl_Ad()
        {
            InitializeComponent();
        }
        //Kullanıcağımız Dizileri ve Değişkenleri Tanımlıyoruz.
        string[] ad = new string[1];
        string[] soyad = new string[1];
        string[] ceptel = new string[1];
        string[] evtel = new string[1];
        string[] evadres = new string[1];
        string[] isadres = new string[1];
        int sıra = 0;
        int kacinci = 0;

        private void lbl_Ad_Load(object sender, EventArgs e)
        { }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            ad[sıra] = textBox1.Text;
            soyad[sıra] = textBox2.Text;
            ceptel[sıra] = maskedTextBox2.Text;
            evtel[sıra] = maskedTextBox1.Text;
            evadres[sıra] = richTextBox1.Text;
            isadres[sıra] = richTextBox2.Text;
            sıra++;
            Array.Resize(ref ad, sıra + 1);
            Array.Resize(ref soyad, sıra + 1);
            Array.Resize(ref ceptel, sıra + 1);
            Array.Resize(ref evtel, sıra + 1);
            Array.Resize(ref evadres, sıra + 1);
            Array.Resize(ref isadres, sıra + 1);
        }
        private void Btn_Listele_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            int eleman = ad.Length;
            for(int i =0;i<eleman;i++)
            {
                ListViewItem kayit = new ListViewItem();
                kayit.Text = ad[i];
                kayit.SubItems.Add(soyad[i]);
                kayit.SubItems.Add(ceptel[i]);
                listView1.Items.Add(kayit);
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //ilk Kayıt Butonu
            textBox1.Text = ad[0];
            textBox2.Text = soyad[0];
            maskedTextBox1.Text =evtel[0];
            maskedTextBox2.Text =ceptel[0];
            richTextBox1.Text = evadres[0];
            richTextBox2.Text = isadres[0];
            kacinci = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Son Kayıt Butonu
            int a = ad.Length - 2;
            textBox1.Text = ad[a];
            textBox2.Text = soyad[a];
            maskedTextBox1.Text = evtel[a];
            maskedTextBox2.Text = ceptel[a];
            richTextBox1.Text = evadres[a];
            richTextBox2.Text = isadres[a];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Sonraki Butonu
            if(kacinci < ad.Length-2)
            {
                textBox1.Text = ad[kacinci];
                textBox2.Text = soyad[kacinci];
                maskedTextBox1.Text = evtel[kacinci];
                maskedTextBox2.Text = ceptel[kacinci];
                richTextBox1.Text = evadres[kacinci];
                richTextBox2.Text = isadres[kacinci];
            }
            else
            {
                MessageBox.Show("Son Kayıttasınız.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Önceki Butonu
            if (kacinci != 0)
            {
                textBox1.Text = ad[kacinci];
                textBox2.Text = soyad[kacinci];
                maskedTextBox1.Text = evtel[kacinci];
                maskedTextBox2.Text = ceptel[kacinci];
                richTextBox1.Text = evadres[kacinci];
                richTextBox2.Text = isadres[kacinci];
            }
            else
            {
                MessageBox.Show("İlk Kayıttasınız.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btn_Arama_Click(object sender, EventArgs e)
        {
            //Arama Butonu
            string aranacak = Microsoft.VisualBasic.Interaction.InputBox("Arananın Adı :","Arama :","",0,0);
            int a = Array.IndexOf(ad, aranacak);
            textBox1.Text = ad[a];
            textBox2.Text = soyad[a];
            maskedTextBox1.Text = evtel[a];
            maskedTextBox2.Text = ceptel[a];
            richTextBox1.Text = evadres[a];
            richTextBox2.Text = isadres[a];
        }

        private void Btn_Düzenle_Click(object sender, EventArgs e)
        {
            //Düzenle Butonu
            ad[kacinci] = textBox1.Text;
            soyad[kacinci] = textBox2.Text;
            evtel[kacinci] = maskedTextBox1.Text;
            ceptel[kacinci] = maskedTextBox2.Text;
            evadres[kacinci] = richTextBox1.Text;
            isadres[kacinci] = richTextBox2.Text;
        }

        private void Btn_Yenikyt_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            Array.Clear(ad,kacinci,1);
            Array.Clear(soyad, kacinci,1);
            Array.Clear(evtel, kacinci,1);
            Array.Clear(ceptel, kacinci,1);
            Array.Clear(evadres, kacinci,1);
            Array.Clear(isadres, kacinci,1);
        }
    } } 
