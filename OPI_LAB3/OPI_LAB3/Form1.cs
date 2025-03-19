using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPI_LAB3
{
    public partial class Form1 : Form
    {
        double katet1;
        double katet2;
        double hypot;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                katet1 = Convert.ToDouble(textBox1.Text);
                katet2 = Convert.ToDouble(textBox2.Text);
                if (katet1 > 0 && katet2 > 0)
                {
                    hypot = Math.Sqrt(Math.Pow(katet1, 2) + Math.Pow(katet2, 2));

                    listBox1.Items.Clear();
                    listBox1.Items.Add("Катет 1 = " + katet1);
                    listBox1.Items.Add("Катет 2 = " + katet2);
                    listBox1.Items.Add("Гіпотенуза = " + hypot);
                }
                else { MessageBox.Show("Введіть коректне значення катетів"); }
            }
            catch
            {
                MessageBox.Show("Введіть коректне значення катетів");
            }
           
        }
    }
}
