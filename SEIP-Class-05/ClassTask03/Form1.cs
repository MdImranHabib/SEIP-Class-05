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
        public List<Book> bookList = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(textISBN.TextLength > 0 && textBook.TextLength > 0)
            {
                bookList.Add(new Book { isbnNumber = Convert.ToInt32(textISBN.Text), bookName = textBook.Text });
            }
            else
            {
                MessageBox.Show("User input can not be null.Please input a valid information!");

                textISBN.Clear();
                textBook.Clear();
            }

            textISBN.Clear();
            textBook.Clear();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            
            if (textISBNFind.TextLength > 0)
            {
                int isbn = Convert.ToInt32(textISBNFind.Text);

                foreach (var item in bookList)
                {
                    if (item.isbnNumber == isbn)
                    {
                        textBookShow.Text = item.bookName;
                        break;
                    }
                    textBookShow.Text = "Invalid ISBN no!";
                }
            }
            else
            {
                MessageBox.Show("ISBN number can not be null. please input a valid isbn number");
            }
        }
    }

    public class Book
    {
        public int isbnNumber { get; set; }
        public string bookName { get; set; }

    }
}

