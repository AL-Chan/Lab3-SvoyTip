using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_SvoyTip
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void CalcOperations() // рассчётная формула
        {
            try
            {
                var firstValue = double.Parse(textOne.Text);
                var secondValue = double.Parse(textTwo.Text);
                var firstAmount = new Degree(firstValue, DegreeTip.C);
                var secondAmount = new Degree(secondValue, DegreeTip.C);
                var DegreeSum = firstAmount + secondAmount;
                textRes.Text = DegreeSum.Sort();
            }
            catch (FormatException)
            {
                // если тип преобразовать не смогли
            }
        }

        private void textOne_TextChanged(object sender, EventArgs e)
        {}
        private void textTwo_TextChanged(object sender, EventArgs e)
        {}

        private void summa_Click(object sender, EventArgs e)
        {
            CalcOperations();
        }

        private void raznost_Click(object sender, EventArgs e)
        {
        }

        private void proizved_Click(object sender, EventArgs e)
        {
        }

        private void sravnit_Click(object sender, EventArgs e)
        {
        }
    }
}
