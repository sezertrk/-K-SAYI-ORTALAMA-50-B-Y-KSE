using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace İKİ_SAYI_ORTALAMA_50_BÜYÜKSE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1 = int.Parse(textBox1.Text);
            int s2 = int.Parse(textBox2.Text);
            int ort = 0;
            ort = (s1 + s2) / 2;
            if (ort < 50)
            {
                textBox3.Text = "Zarar";
            }
            else
            {
                textBox3 .Text = "Kar";
            }
        }
    }
}
