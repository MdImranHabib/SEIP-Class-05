namespace Day5_PracticeProblemOne
{
    partial class indexForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.inputTextCountTotal = new System.Windows.Forms.TextBox();
            this.textBoxShow = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter  your name  :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // inputTextName
            // 
            this.inputTextName.Location = new System.Drawing.Point(197, 64);
            this.inputTextName.Name = "inputTextName";
            this.inputTextName.Size = new System.Drawing.Size(185, 20);
            this.inputTextName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(408, 64);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Show All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // inputTextCountTotal
            // 
            this.inputTextCountTotal.Location = new System.Drawing.Point(197, 279);
            this.inputTextCountTotal.Name = "inputTextCountTotal";
            this.inputTextCountTotal.Size = new System.Drawing.Size(185, 20);
            this.inputTextCountTotal.TabIndex = 5;
            this.inputTextCountTotal.TextChanged += new System.EventHandler(this.inputTextCountTotal_TextChanged);
            // 
            // textBoxShow
            // 
            this.textBoxShow.Location = new System.Drawing.Point(197, 111);
            this.textBoxShow.Name = "textBoxShow";
            this.textBoxShow.Size = new System.Drawing.Size(185, 96);
            this.textBoxShow.TabIndex = 6;
            this.textBoxShow.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Total :";
            // 
            // indexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxShow);
            this.Controls.Add(this.inputTextCountTotal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.inputTextName);
            this.Controls.Add(this.label1);
            this.Name = "indexForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Day 5  Practice Problem ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTextName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox inputTextCountTotal;
        private System.Windows.Forms.RichTextBox textBoxShow;
        private System.Windows.Forms.Label label2;
    }
}

