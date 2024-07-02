using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Масссив_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Make_Click(object sender, EventArgs e)
        {
            Result.Clear();
            int count=Convert.ToInt32(Count.Text);
            int min=Convert.ToInt32(Min.Text);
            int max=Convert.ToInt32(Max.Text);
            List<int> list = new List<int>();
            int number;
            Random random = new Random();
            for(int i = 0; i < count; i++)
            {
                number=random.Next(min, max);
                list.Add(number);
                Result.Text += number+" ";
            }
            Class1 class1 = new Class1();
            Pos.Text = Math.Round(class1.PositivePro<int>(list),2).ToString()+"%" ;
            Neg.Text= Math.Round(class1.NegativePro<int>(list),2).ToString() + "%";
            Nul.Text = Math.Round(class1.NulPro<int>(list), 2).ToString() + "%";
        }

        private void Make_double_Click(object sender, EventArgs e)
        {
            Result.Clear();
            int count = Convert.ToInt32(Count.Text);
            int min = Convert.ToInt32(Min.Text);
            int max = Convert.ToInt32(Max.Text);
            List<double> list = new List<double>();
            double number;
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                number = Math.Round(random.NextDouble()*(max - min) + (min),2);
                list.Add(number);
                Result.Text += number + " ";
            }
            Class1 class1 = new Class1();
            Pos.Text = Math.Round(class1.PositivePro<double>(list), 2).ToString() + "%";
            Neg.Text = Math.Round(class1.NegativePro<double>(list), 2).ToString() + "%";
            Nul.Text = Math.Round(class1.NulPro<double>(list), 2).ToString() + "%";
        }
    }
}
