
namespace libraryhw
{
    partial class Form2
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
            this.txtNormalBooks = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProtectedBooks = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrentBooks = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCheckoutCounter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtPlaceCheckout = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.txtReturnBooks = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNormalBooks
            // 
            this.txtNormalBooks.Location = new System.Drawing.Point(30, 48);
            this.txtNormalBooks.Multiline = true;
            this.txtNormalBooks.Name = "txtNormalBooks";
            this.txtNormalBooks.ReadOnly = true;
            this.txtNormalBooks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNormalBooks.Size = new System.Drawing.Size(396, 284);
            this.txtNormalBooks.TabIndex = 0;
            this.txtNormalBooks.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Normal Books";
            // 
            // txtProtectedBooks
            // 
            this.txtProtectedBooks.Location = new System.Drawing.Point(30, 390);
            this.txtProtectedBooks.Multiline = true;
            this.txtProtectedBooks.Name = "txtProtectedBooks";
            this.txtProtectedBooks.ReadOnly = true;
            this.txtProtectedBooks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtProtectedBooks.Size = new System.Drawing.Size(396, 292);
            this.txtProtectedBooks.TabIndex = 2;
            this.txtProtectedBooks.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Protected Books";
            // 
            // txtCurrentBooks
            // 
            this.txtCurrentBooks.Location = new System.Drawing.Point(528, 48);
            this.txtCurrentBooks.Multiline = true;
            this.txtCurrentBooks.Name = "txtCurrentBooks";
            this.txtCurrentBooks.ReadOnly = true;
            this.txtCurrentBooks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCurrentBooks.Size = new System.Drawing.Size(396, 284);
            this.txtCurrentBooks.TabIndex = 4;
            this.txtCurrentBooks.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Books Currently Borrowed";
            // 
            // txtCheckoutCounter
            // 
            this.txtCheckoutCounter.Location = new System.Drawing.Point(528, 390);
            this.txtCheckoutCounter.Multiline = true;
            this.txtCheckoutCounter.Name = "txtCheckoutCounter";
            this.txtCheckoutCounter.ReadOnly = true;
            this.txtCheckoutCounter.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCheckoutCounter.Size = new System.Drawing.Size(396, 284);
            this.txtCheckoutCounter.TabIndex = 6;
            this.txtCheckoutCounter.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Checkout Counter";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(30, 732);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 34);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Account";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtPlaceCheckout
            // 
            this.txtPlaceCheckout.Location = new System.Drawing.Point(949, 592);
            this.txtPlaceCheckout.Name = "txtPlaceCheckout";
            this.txtPlaceCheckout.Size = new System.Drawing.Size(290, 31);
            this.txtPlaceCheckout.TabIndex = 9;
            this.txtPlaceCheckout.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCheckoutCounter_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(949, 564);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Book to Place In Checkout Counter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(949, 626);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Enter to place book";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(528, 732);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(154, 34);
            this.btnCheckout.TabIndex = 12;
            this.btnCheckout.Text = "Checkout Book";
            this.btnCheckout.UseVisualStyleBackColor = true;
            // 
            // txtReturnBooks
            // 
            this.txtReturnBooks.Location = new System.Drawing.Point(952, 192);
            this.txtReturnBooks.Name = "txtReturnBooks";
            this.txtReturnBooks.Size = new System.Drawing.Size(287, 31);
            this.txtReturnBooks.TabIndex = 13;
            this.txtReturnBooks.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textReturnBooks_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(949, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Book to Return";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(952, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Enter to return book";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 827);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtReturnBooks);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPlaceCheckout);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCheckoutCounter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCurrentBooks);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProtectedBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNormalBooks);
            this.Name = "Form2";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNormalBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProtectedBooks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrentBooks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCheckoutCounter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtPlaceCheckout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.TextBox txtReturnBooks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}