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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btncevır_Click(object sender, EventArgs e)
        {
            
            string[] renk = new string[10];
            string deger = "";
            renk[0] = "Siyah";
            renk[1] = "Kahverengi";
            renk[2] = "Kırmızı";
            renk[3] = "Turuncu";
            renk[4] = "Sarı";
            renk[5] = "Yeşil";
            renk[6] = "Mavi";
            renk[7] = "Mor";
            renk[8] = "Gri";
            renk[9] = "Beyaz";

            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {

                if (radioButton1.Checked == true)
                {
                    try
                    {
                        deger = textBox3.Text;
                    }
                    catch
                    {
                        MessageBox.Show("Lütfen Tam Sayı Değeri Giriniz!!");
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    try
                    {
                        deger = (int.Parse(textBox3.Text) * 1000).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Lütfen Tam Sayı Değeri Giriniz!!");
                    }
                    
                }
                else if (radioButton3.Checked == true)
                {
                    try
                    {
                        deger = (int.Parse(textBox3.Text) * 1000000).ToString();
                    }
                    catch
                    {
                        MessageBox.Show("Lütfen Tam Sayı değeri Giriniz!!");
                    }
                    
                }

                try
                {
                    string ilkdeger = deger.ToString().Substring(0, 1);
                    textBox4.Text = renk[Convert.ToInt32(ilkdeger)];
                }
                catch
                {

                }
                try
                {
                    string ikincideger = deger.Substring(1, 1);
                    textBox5.Text = renk[Convert.ToInt32(ikincideger)];
                }
                catch
                {

                }
                try
                {
                    string ucuncudeger = renk[deger.Length - 2].ToString();
                    textBox6.Text = ucuncudeger;
                }
                catch
                {

                }              
            }
            else
            {
                deger = textBox3.Text;
                try
                {
                    string ilkdeger = deger.ToString().Substring(0, 1);
                    textBox4.Text = renk[Convert.ToInt32(ilkdeger)];
                }
                catch
                {

                }
                try
                {
                    string ikincideger = deger.Substring(1, 1);
                    textBox5.Text = renk[Convert.ToInt32(ikincideger)];
                }
                catch
                {

                }
                try
                {
                    string ucuncudeger = renk[deger.Length - 2].ToString();
                    textBox6.Text = ucuncudeger;
                }
                catch
                {

                }      
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear(); 
        }
    }
}
