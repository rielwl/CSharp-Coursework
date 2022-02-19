
namespace homework1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblcrct = new System.Windows.Forms.Label();
            this.lblincrct = new System.Windows.Forms.Label();
            this.lblinstr = new System.Windows.Forms.Label();
            this.txtCheck = new System.Windows.Forms.TextBox();
            this.btnTxtColor = new System.Windows.Forms.Button();
            this.btnOpenForm = new System.Windows.Forms.Button();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblAns = new System.Windows.Forms.Label();
            this.btnResetScr = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnResetList = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnCurrWords = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcrct
            // 
            this.lblcrct.AutoSize = true;
            this.lblcrct.Location = new System.Drawing.Point(33, 18);
            this.lblcrct.Name = "lblcrct";
            this.lblcrct.Size = new System.Drawing.Size(88, 25);
            this.lblcrct.TabIndex = 0;
            this.lblcrct.Text = "Correct: 0";
            // 
            // lblincrct
            // 
            this.lblincrct.AutoSize = true;
            this.lblincrct.Location = new System.Drawing.Point(661, 18);
            this.lblincrct.Name = "lblincrct";
            this.lblincrct.Size = new System.Drawing.Size(100, 25);
            this.lblincrct.TabIndex = 1;
            this.lblincrct.Text = "Incorrect: 0";
            // 
            // lblinstr
            // 
            this.lblinstr.AutoSize = true;
            this.lblinstr.Location = new System.Drawing.Point(216, 327);
            this.lblinstr.Name = "lblinstr";
            this.lblinstr.Size = new System.Drawing.Size(347, 25);
            this.lblinstr.TabIndex = 3;
            this.lblinstr.Text = "Press Enter to check the text with the word";
            // 
            // txtCheck
            // 
            this.txtCheck.Location = new System.Drawing.Point(173, 205);
            this.txtCheck.Name = "txtCheck";
            this.txtCheck.Size = new System.Drawing.Size(457, 31);
            this.txtCheck.TabIndex = 4;
            this.txtCheck.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkGame);
            // 
            // btnTxtColor
            // 
            this.btnTxtColor.Location = new System.Drawing.Point(33, 404);
            this.btnTxtColor.Name = "btnTxtColor";
            this.btnTxtColor.Size = new System.Drawing.Size(148, 34);
            this.btnTxtColor.TabIndex = 5;
            this.btnTxtColor.Text = "Text Color";
            this.btnTxtColor.UseVisualStyleBackColor = true;
            this.btnTxtColor.Click += new System.EventHandler(this.btnTxtColor_Click);
            // 
            // btnOpenForm
            // 
            this.btnOpenForm.Location = new System.Drawing.Point(613, 111);
            this.btnOpenForm.Name = "btnOpenForm";
            this.btnOpenForm.Size = new System.Drawing.Size(148, 34);
            this.btnOpenForm.TabIndex = 6;
            this.btnOpenForm.Text = "Add Words";
            this.btnOpenForm.UseVisualStyleBackColor = true;
            this.btnOpenForm.Click += new System.EventHandler(this.btnOpenForm_Click);
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.BackColor = System.Drawing.SystemColors.Control;
            this.lblWord.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWord.Location = new System.Drawing.Point(173, 165);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(81, 25);
            this.lblWord.TabIndex = 2;
            this.lblWord.Text = "Meaning";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(173, 254);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(0, 25);
            this.lblAns.TabIndex = 7;
            this.lblAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnResetScr
            // 
            this.btnResetScr.Location = new System.Drawing.Point(33, 60);
            this.btnResetScr.Name = "btnResetScr";
            this.btnResetScr.Size = new System.Drawing.Size(148, 34);
            this.btnResetScr.TabIndex = 8;
            this.btnResetScr.Text = "Reset Score";
            this.btnResetScr.UseVisualStyleBackColor = true;
            this.btnResetScr.Click += new System.EventHandler(this.btnResetScr_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(613, 60);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(148, 34);
            this.btnDefault.TabIndex = 9;
            this.btnDefault.Text = "Default Words";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "After adding words, press enter once";
            // 
            // btnResetList
            // 
            this.btnResetList.Location = new System.Drawing.Point(33, 111);
            this.btnResetList.Name = "btnResetList";
            this.btnResetList.Size = new System.Drawing.Size(148, 34);
            this.btnResetList.TabIndex = 11;
            this.btnResetList.Text = "Reset Word List";
            this.btnResetList.UseVisualStyleBackColor = true;
            this.btnResetList.Click += new System.EventHandler(this.btnResetList_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(613, 404);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(148, 34);
            this.btnHelp.TabIndex = 12;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnCurrWords
            // 
            this.btnCurrWords.Location = new System.Drawing.Point(613, 352);
            this.btnCurrWords.Name = "btnCurrWords";
            this.btnCurrWords.Size = new System.Drawing.Size(148, 34);
            this.btnCurrWords.TabIndex = 13;
            this.btnCurrWords.Text = "Current Words";
            this.btnCurrWords.UseVisualStyleBackColor = true;
            this.btnCurrWords.Click += new System.EventHandler(this.btnCurrWords_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCurrWords);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnResetList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnResetScr);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.btnOpenForm);
            this.Controls.Add(this.btnTxtColor);
            this.Controls.Add(this.txtCheck);
            this.Controls.Add(this.lblinstr);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblincrct);
            this.Controls.Add(this.lblcrct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcrct;
        private System.Windows.Forms.Label lblincrct;
        private System.Windows.Forms.Label lblinstr;
        private System.Windows.Forms.TextBox txtCheck;
        private System.Windows.Forms.Button btnTxtColor;
        private System.Windows.Forms.Button btnOpenForm;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Button btnResetScr;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnResetList;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnCurrWords;
    }
}

