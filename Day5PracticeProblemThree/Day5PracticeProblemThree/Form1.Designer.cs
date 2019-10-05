namespace Day5PracticeProblemThree
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBoxISBN = new System.Windows.Forms.TextBox();
            this.inputTextBoxBookDetails = new System.Windows.Forms.TextBox();
            this.inputTextBoxSearch = new System.Windows.Forms.TextBox();
            this.inputTextBoxShowDetails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBoxISBN
            // 
            this.inputTextBoxISBN.Location = new System.Drawing.Point(145, 41);
            this.inputTextBoxISBN.Name = "inputTextBoxISBN";
            this.inputTextBoxISBN.Size = new System.Drawing.Size(187, 20);
            this.inputTextBoxISBN.TabIndex = 0;
            // 
            // inputTextBoxBookDetails
            // 
            this.inputTextBoxBookDetails.Location = new System.Drawing.Point(145, 99);
            this.inputTextBoxBookDetails.Name = "inputTextBoxBookDetails";
            this.inputTextBoxBookDetails.Size = new System.Drawing.Size(187, 20);
            this.inputTextBoxBookDetails.TabIndex = 1;
            // 
            // inputTextBoxSearch
            // 
            this.inputTextBoxSearch.Location = new System.Drawing.Point(145, 158);
            this.inputTextBoxSearch.Name = "inputTextBoxSearch";
            this.inputTextBoxSearch.Size = new System.Drawing.Size(187, 20);
            this.inputTextBoxSearch.TabIndex = 2;
            // 
            // inputTextBoxShowDetails
            // 
            this.inputTextBoxShowDetails.Location = new System.Drawing.Point(145, 204);
            this.inputTextBoxShowDetails.Name = "inputTextBoxShowDetails";
            this.inputTextBoxShowDetails.ReadOnly = true;
            this.inputTextBoxShowDetails.Size = new System.Drawing.Size(187, 20);
            this.inputTextBoxShowDetails.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ISBN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Book Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ISBN :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Book Details Show";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(350, 99);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(350, 156);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBoxShowDetails);
            this.Controls.Add(this.inputTextBoxSearch);
            this.Controls.Add(this.inputTextBoxBookDetails);
            this.Controls.Add(this.inputTextBoxISBN);
            this.Name = "Form1";
            this.Text = "Day5_Problem_Three";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBoxISBN;
        private System.Windows.Forms.TextBox inputTextBoxBookDetails;
        private System.Windows.Forms.TextBox inputTextBoxSearch;
        private System.Windows.Forms.TextBox inputTextBoxShowDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSearch;
    }
}

