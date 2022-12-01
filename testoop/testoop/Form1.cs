using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testoop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }  


        krida_ krida = new krida_();


            Vzhled btn_class = new Vzhled();
        private void button1_Click(object sender, EventArgs e)
        {

            if (btn_class.popsana == false)
            {
                btn_class.psat_na_tabuli(label4);
                button1.Enabled = false;
                button2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Tabulka je už popsaná");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (btn_class.popsana == true)
            {
                btn_class.smazat_tabuli(label4);

                button1.Enabled = true;
                button2.Enabled = false;
            }
            else
            {
                MessageBox.Show("Tabulka je už čístá");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)) ||(string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text)))
            {
                MessageBox.Show("Zadejete prosím hodnoty");
            }
            else
            {   
                try
                {

                    Vzhled vzhled = new Vzhled(int.Parse(textBox1.Text), textBox2.Text);
                    krida_ krida = new krida_(textBox4.Text, int.Parse(textBox3.Text));
                    MessageBox.Show(vzhled.ToString());
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = false;

                    textBox1.Enabled = false;
                    textBox2.Enabled = false; 
                }
                catch
                {
                    MessageBox.Show("zadali jste špatně");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }
        }
    }
}
