using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudangasMartinkusPS01Git
{
    public partial class Form1 : Form
    {
        double[] masyvas = new double[10];
        double sum = 0;
        int i = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (i < 10)
            {
                masyvas[i] = double.Parse(textBox1.Text);
                label3.Visible = true;
                textBox1.Clear();
                i++;
            }
            if (i == 10)
            {
                label3.Visible = false;
                textBox1.Clear();
                for (int j = 0; j < 10; j++)
                {
                    sum += masyvas[j];
                }
                textBox2.Text = sum.ToString();
                label4.Visible = true;
                i++;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int zvaigzdes = 0;
            int aukstis = int.Parse(textBox3.Text);
            int tarpai = aukstis-1;
            for (int x = 0; x < aukstis; x++)
            {
                for (int y = 0; y < tarpai; y++)
                {
                    richTextBox1.Text += " ";
                }
                tarpai--;
                zvaigzdes++;
                for (int z = 0; z < zvaigzdes; z++)
                {
                    richTextBox1.Text += "* ";
                }
                richTextBox1.Text += "\n";
            }
            label7.Visible = true;



        }
    }
}
