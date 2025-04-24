using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deney_1
{
    public partial class Form1 : Form
    {
        const int GECMENOTU = 55;
        const int DERSSAYISI = 3;
        double dersnotu = 0;
        double [] dersnotlari = new double [DERSSAYISI];
        int yertutucu = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0 ; i < DERSSAYISI ; i++)
            {
                dersnotlari[i] = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || Convert.ToInt16(textBox1.Text) > 100)
            {
                MessageBox.Show("Lütfen Gecerli Vize Notu Giriniz !");
                return;
            }
            if (textBox2.Text == null || Convert.ToInt16(textBox2.Text) > 100)
            {
                MessageBox.Show("Lütfen Gecerli Final Notu Giriniz !");
                return;
            }
            double ortalama = (Convert.ToInt16(textBox1.Text) * 40 / 100) + (Convert.ToInt16(textBox2.Text) * 60 / 100);
            label3.Text = Convert.ToString(ortalama);

            if (ortalama >= GECMENOTU)
            {
                label4.Text = Convert.ToString("Tebrikler Dersi Gectiniz !");
            }
            else
            {
                label4.Text = Convert.ToString("Dersten Kaldınız !");
            }
            
            if (ortalama >= GECMENOTU)
            {
                dersnotu = ortalama / 25;
            }
            else
            {
                dersnotu = 0;
            }
            label5.Text = Convert.ToString(dersnotu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DERSSAYISI == yertutucu)
            {
                label6.Text = Convert.ToString("Dizi Dolu !");
                return;
            }
            dersnotlari[yertutucu] = dersnotu;
            yertutucu++;
            label6.Text = Convert.ToString("Eklendi !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double Ortalama = 0;
            int gecerderssayisi = 0;
            for (int i = 0; i < DERSSAYISI; i++) 
            {
                if (dersnotlari[i] < 2.5)
                {
                    continue;
                }
                gecerderssayisi++;
                Ortalama += dersnotlari[i];
            }
            Ortalama /= DERSSAYISI;
            label6.Text = Convert.ToString(Ortalama);
        }
    }
}
