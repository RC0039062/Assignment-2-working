using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_working
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double RS1, RS2;
            try
            {
                RS1 = double.Parse(textBox1.Text);
                RS2 = double.Parse(textBox2.Text);
            }
            catch
            {
                MessageBox.Show("input error");
                RS1 = 0.0;
                RS2 = 0.0;
            }

            double RT1 = RS1 + RS2;
            textBox3.Text = String.Empty;
            textBox3.AppendText(RT1.ToString("0.000"));
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
