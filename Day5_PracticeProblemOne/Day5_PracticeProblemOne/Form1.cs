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

namespace Day5_PracticeProblemOne
{
    public partial class indexForm : Form
    {

        //List<String> name = new List<string>();

        //ArrayList name = new ArrayList();

        String[] name = new String[10]; 

        int c;
        int i;
        public indexForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            name[i] = inputTextName.Text;

            inputTextName.Clear();
            textBoxShow.Clear();
            inputTextCountTotal.Clear();

            MessageBox.Show("Your name save Successfully !");

            i++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(var item in name)
            {
                textBoxShow.Text = textBoxShow.Text + item + "\n";
   
            }

            inputTextCountTotal.Text = Convert.ToString(name.Length);


        }

        private void inputTextCountTotal_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
