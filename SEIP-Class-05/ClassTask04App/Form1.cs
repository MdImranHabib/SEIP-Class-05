using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassTask04App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string contact = textBoxContact.Text;
            string email = textBoxEmail.Text;

            ListViewItem item = new ListViewItem(name);
            item.SubItems.Add(contact);
            item.SubItems.Add(email);

            listViewInfo.Items.Add(item);
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            listViewInfo.Items.Clear();
        }

        private void listViewInfo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }
    }
}
