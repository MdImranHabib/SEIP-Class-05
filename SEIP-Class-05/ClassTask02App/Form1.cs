using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassTask02App
{
    public partial class Form1 : Form
    {
        public double convertNumbers;
        public double sum=0;
        public bool status = false;
        List<double> number = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            convertNumbers = Convert.ToDouble((textNumber.Text));
            number.Add(convertNumbers);
            textNumber.Clear();
            foreach (var obj in number)
            {
                numberList.Items.Remove(obj);
            }
            textSum.Clear();
            sum = 0;
            status = false;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                foreach (var obj in number)
                {
                    numberList.Items.Add(obj);
                    sum = sum + obj;
                }

                textSum.Text = Convert.ToString(sum);
                status = true;
            }
            
        }
    }
}
