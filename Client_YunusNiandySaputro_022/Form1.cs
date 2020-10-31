using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_YunusNiandySaputro_022
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int val1 = 0;
                int val2 = 0;
                ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
                try
                {
                    val1 = Int32.Parse(textBox1.Text);
                    val2 = Int32.Parse(textBox2.Text);
                }
                catch
                {
                    MessageBox.Show("Number only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                label7.Text = obj.Tambah(val1, val2).ToString();
                label8.Text = obj.Kurang(val1, val2).ToString();
                label9.Text = obj.Kali(val1, val2).ToString();
                label10.Text = obj.Bagi(val1, val2).ToString();

            }
            catch
            {
                MessageBox.Show("Can't connect to server", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
