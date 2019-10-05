using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace ClassTask03App
{
    public partial class Form1 : Form
    {
        Hashtable bookList = new Hashtable();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(textBoxISBN.TextLength > 0 && textBoxBook.TextLength > 0)
            {
                string isbn = textBoxISBN.Text;
                string bookName = textBoxBook.Text;
                bookList.Add(isbn, bookName);
                textBoxISBN.Clear();
                textBoxBook.Clear();
            }
            else
            {
                MessageBox.Show("Input field can not be null!");
                //textBoxISBN.Clear();
                //textBoxBook.Clear();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(textBoxFindISBN.TextLength > 0)
            {
                string searchIsbn = textBoxFindISBN.Text;
                ICollection key = bookList.Keys;
                
                foreach(var item in key)
                {
                    string k = Convert.ToString(item);
                    if (k == searchIsbn)
                    {
                        textBoxShowBook.Text = Convert.ToString(bookList[item]);
                        break;
                    }
                    textBoxShowBook.Text = "Invalid ISBN no!";
                }
            }
            else
            {
                MessageBox.Show("ISBN number can not be null.\nPlease input a valid ISBN number!");
            }
        }
    }
}
