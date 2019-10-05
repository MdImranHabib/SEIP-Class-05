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

namespace Day5PracticeProblemThree
{
    public partial class Form1 : Form
    {


        //Hashtable bookList = new Hashtable();

        List<BookClass> bookList = new List<BookClass>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (inputTextBoxISBN.TextLength > 0 && inputTextBoxBookDetails.TextLength > 0)
            {

                bookList.Add(new BookClass { bookIsbn = Convert.ToInt32(inputTextBoxISBN.Text), bookDetails = inputTextBoxBookDetails.Text });

                inputTextBoxISBN.Clear();
                inputTextBoxBookDetails.Clear();
            }
            else
            {
                MessageBox.Show("Please complete this form properly where all input field are Required !");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (inputTextBoxSearch != null)
            {

                int isbn = Convert.ToInt32(inputTextBoxSearch.Text);
                

               foreach (var item in bookList)
                {
                   
                    if (Convert.ToInt32(item.bookIsbn) == isbn)
                    {
                        inputTextBoxShowDetails.Text = Convert.ToString(item.bookDetails);
                    }
                }


            }
            else
            {
                MessageBox.Show("Invalid input \nPlease enter ISBN number of a book");
            }
        }


        public class BookClass
        {
            public int bookIsbn { get; set; }
            public String bookDetails { get; set; }
        }

    }
}
