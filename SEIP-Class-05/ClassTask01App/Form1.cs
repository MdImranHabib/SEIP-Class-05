using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassTask01App
{
    public partial class Form1 : Form
    {
        public bool status = false;

        List<string> name = new List<string>();

        //string[] name =    

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //public void Clear()
        //{
        //    textName.Text = "";
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            name.Add(textName.Text);
            MessageBox.Show("Data has been saved successfully!");
            textName.Clear();
            textShowAllName.Clear();

            status = false;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                foreach (var item in name)
                {
                    textShowAllName.Text = textShowAllName.Text + item + "\n";
                }

                textTotalName.Text = Convert.ToString(name.Count());
                status = true;
            }

       
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
