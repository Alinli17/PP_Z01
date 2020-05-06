using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP_Z1_WinForms_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Find_Click(object sender, EventArgs e)
        {
            double v = Convert.ToDouble(Volume.Text);
            double a = Math.Pow(v, 1 / 3f);
            rez.Text = a.ToString();
        }

        private void Verity_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Number.Text);
            int rez = (a % 10) + (a / 10);
            if (rez % 2 == 0)
            {
                rez2.Text = "Сумма чётная";
            }
            else rez2.Text = "Сумма нечётная";
        }
    }
}
