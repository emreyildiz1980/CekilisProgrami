using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cekilis_Programi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string isim = textBox1.Text;
            isim = isim.Trim();
            int say = isim.Length;

            if (say<1)
            {
                MessageBox.Show("Lütfen isim alanını boş bırakmayınız !");
            }
            else
            {
                listBox1.Items.Add(isim);
            }
                
            textBox1.Clear();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            int sayi;
            Random rd = new Random();
            int control = listBox1.Items.Count;
            if (control==0)
            {
                MessageBox.Show("İşlem Tamam !");
            }
            else
            {
                sayi = rd.Next(0, listBox1.Items.Count);
                label3.Text = listBox1.Items[sayi].ToString();
                listBox2.Items.Add(label3.Text);
                listBox1.Items.Remove(label3.Text);


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}


            
