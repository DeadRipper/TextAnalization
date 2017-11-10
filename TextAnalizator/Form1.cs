using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAnalizator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox2.Text = textBox1.Text.Length.ToString();
            this.chart1.Series["Частота"].Points.AddXY("a", textBox1.Text.Length);
            this.chart1.Series["Частота"].Points.AddXY("b", textBox1.Text.Length);
            this.chart1.Series["Частота"].Points.AddXY("c", textBox1.Text.Length);
            /*this.chart1.Series["Частота"].Points.AddXY("Bukva", textBox1.MaxLength);
            this.chart1.Series["Частота"].Points.AddXY(textBox1.MaxLength, "Cifra");*/
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
