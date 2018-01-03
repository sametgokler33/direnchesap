using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PERFORMANCEEEE
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            switch (comboBox1.Text)
            {
                case "Siyah":
                    comboBox1.SelectedItem = "Siyah";
                    btn1.BackColor = Color.Black;
                    break;

                case "Kahverengi":
                    comboBox1.SelectedItem = "Kahverengi";
                    btn1.BackColor = Color.Brown;
                    break;

                case "Kırmızı":
                    comboBox1.SelectedItem = "Kırmızı";
                    btn1.BackColor = Color.Red;
                    break;

                case "Turuncu":
                    comboBox1.SelectedItem = "Turuncu";
                    btn1.BackColor = Color.Orange;
                    break;

                case "Sarı":
                    comboBox1.SelectedItem = "Sarı";
                    btn1.BackColor = Color.Yellow;
                    break;

                case "Yeşil":
                    comboBox1.SelectedItem = "Yeşil";
                    btn1.BackColor = Color.Green;
                    break;

                case "Mavi":
                    comboBox1.SelectedItem = "Mavi";
                    btn1.BackColor = Color.Blue;
                    break;

                case "Mor":
                    comboBox1.SelectedItem = "Mor";
                    btn1.BackColor = Color.Purple;
                    break;

                case "Gri":
                    comboBox1.SelectedItem = "Gri";
                    btn1.BackColor = Color.Gray;
                    break;

                case "Beyaz":
                    comboBox1.SelectedItem = "Beyaz";
                    btn1.BackColor = Color.White;
                    break;
            }
            }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;
            switch (comboBox2.Text)
            {
                case "Siyah":
                    comboBox2.SelectedItem = "Siyah";
                    btn2.BackColor = Color.Black;
                    break;

                case "Kahverengi":
                    comboBox2.SelectedItem = "Kahverengi";
                    btn2.BackColor = Color.Brown;
                    break;

                case "Kırmızı":
                    comboBox2.SelectedItem = "Kırmızı";
                    btn2.BackColor = Color.Red;
                    break;

                case "Turuncu":
                    comboBox2.SelectedItem = "Turuncu";
                    btn2.BackColor = Color.Orange;
                    break;

                case "Sarı":
                    comboBox2.SelectedItem = "Sarı";
                    btn2.BackColor = Color.Yellow;
                    break;
                case "Yeşil":
                    comboBox2.SelectedItem = "Yeşil";
                    btn2.BackColor = Color.Green;
                    break;

                case "Mavi":
                    comboBox2.SelectedItem = "Mavi";
                    btn2.BackColor = Color.Blue;
                    break;

                case "Mor":
                    comboBox2.SelectedItem = "Mor";
                    btn2.BackColor = Color.Purple;
                    break;

                case "Gri":
                    comboBox2.SelectedItem = "Gri";
                    btn2.BackColor = Color.Gray;
                    break;

                case "Beyaz":
                    comboBox2.SelectedItem = "Beyaz";
                    btn2.BackColor = Color.White;
                    break;

            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox4.Enabled = true;
            switch (comboBox3.Text)
            {
                case "Siyah":
                    comboBox3.SelectedItem = "Siyah";
                    btn3.BackColor = Color.Black;
                    break;

                case "Kahverengi":
                    comboBox3.SelectedItem = "Kahverengi";
                    btn3.BackColor = Color.Brown;
                    break;

                case "Kırmızı":
                    comboBox3.SelectedItem = "Kırmızı";
                    btn3.BackColor = Color.Red;
                    break;

                case "Turuncu":
                    comboBox3.SelectedItem = "Turuncu";
                    btn3.BackColor = Color.Orange;
                    break;

                case "Yeşil":
                    comboBox3.SelectedItem = "Yeşil";
                    btn3.BackColor = Color.Green;
                    break;

                case "Sarı":
                    comboBox3.SelectedItem = "Sarı";
                    btn3.BackColor = Color.Yellow;
                    break;

                case "Mavi":
                    comboBox3.SelectedItem = "Mavi";
                    btn3.BackColor = Color.Blue;
                    break;

                case "Mor":
                    comboBox3.SelectedItem = "Mor";
                    btn3.BackColor = Color.Purple;
                    break;

                case "Gri":
                    comboBox3.SelectedItem = "Gri";
                    btn3.BackColor = Color.Gray;
                    break;

                case "Beyaz":
                    comboBox3.SelectedItem = "Beyaz";
                    btn3.BackColor = Color.White;
                    break;

            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.Text == "Altın")
            {
                btn4.BackColor = Color.Gold;
            }

            else if (comboBox4.Text == "Gümüş")
            {
                btn4.BackColor = Color.Silver;
            }
            else if (comboBox4.Text == "Kahverengi")
            {
                btn4.BackColor = Color.Brown;
            }
            else if (comboBox4.Text == "Kırmızı")
            {
                btn4.BackColor = Color.Red;
            }
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            double r1, r2, r3, r4, sonuc;
            r1 = comboBox1.SelectedIndex;
            r2 = comboBox2.SelectedIndex;
            r3 = comboBox3.SelectedIndex;
            r4 = comboBox4.SelectedIndex;
            string top = r1 + r2.ToString();
            sonuc = (Convert.ToDouble(top) * Math.Pow(10, r3));

            if (sonuc < 1000)
                textBox2.Text = sonuc + " Ohm".ToString();
            else if (sonuc < 1000000)
                textBox2.Text = (sonuc / 1000) + " Kilo Ohm".ToString();
            else if (sonuc < 1000000000)
                textBox2.Text = (sonuc / 1000000) + " Mega Ohm".ToString();
            else if (sonuc < 1000000000000)
                textBox2.Text = (sonuc / 1000000000) + " Giga Ohm".ToString();
            else
                textBox2.Text = "Hata";

            if (r4 == 0)
                textBox1.Text = "TOLERANS %1";
            else if (r4 == 1)
                textBox1.Text = "TOLERANS %2";
            else if (r4 == 2)
                textBox1.Text = "TOLERANS %5";
            else
                textBox1.Text = "TOLERANS %10";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox3.Text = DateTime.Now.ToString();
            textBox4.Text = DateTime.Now.ToLongDateString();
        }
    }
}
