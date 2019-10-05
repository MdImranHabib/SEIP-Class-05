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

namespace ClassTask03
{
    public partial class Form1 : Form
    {
        private List<Book> bookList = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

    }

    public class Book
    {
        public int isbnNumber { get; set; }
        public string bookName { get; set; }

    }
}

