using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace İnt_Değişkeni_4_İşlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplama, cıkarma, bölme, carpma;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            toplama = sayi1 + sayi2;
            cıkarma = sayi1 - sayi2;
            bölme = sayi1 / sayi2;
            carpma = sayi1 * sayi2;
            MessageBox.Show("Toplam: "+ toplama + "\n" + "Fark: " +cıkarma + "\n" + "Bölüm: " + bölme + "\n" + "Çarpım: " + carpma);
        }
    }
}
