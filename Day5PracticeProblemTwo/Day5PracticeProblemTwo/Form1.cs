using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day5PracticeProblemTwo
{
    public partial class Day5 : Form
    {


        List<double> numberList = new List<double>();

        double sumOfNumberList;

        bool IsDoubleClicked = false;

        public Day5()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            numberList.Add(Convert.ToDouble(inputTextBox.Text));

            inputTextBox.Clear();

            foreach (var item in numberList)
            {
                listBoxShowAll.Items.Remove(item);
            
            }

            inputTextBoxShowSum.Clear();
            sumOfNumberList = 0;
            IsDoubleClicked = false;
           

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
           if(IsDoubleClicked == false)
            {
                foreach (var item in numberList)
                {
                    listBoxShowAll.Items.Add(item);

                    sumOfNumberList += item;

                }

                inputTextBoxShowSum.Text = Convert.ToString(sumOfNumberList);

                IsDoubleClicked = true;
            }
        }
    }
}
