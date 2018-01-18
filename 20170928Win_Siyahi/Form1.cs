using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20170928Win_Siyahi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yaz = textBox1.Text + " " + textBox2.Text + ", " + comboBox1.SelectedItem;
            listView1.Items.Add(yaz);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 300000000;
            try
            {
                checked
                {
                    a = a * 1000;
                }
                MessageBox.Show(a.ToString());
            }
            catch
            {
                MessageBox.Show("Limiti kecdi");
            }

        }
    }
}
