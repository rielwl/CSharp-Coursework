
namespace homework1
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
            this.txtAddWord = new System.Windows.Forms.TextBox();
            this.txtAddDef = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAddWord = new System.Windows.Forms.Label();
            this.lblAddDef = new System.Windows.Forms.Label();
            this.lblDefWarn = new System.Windows.Forms.Label();
            this.lblWordWarn = new System.Windows.Forms.Label();
            this.lblWordAdded = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAddWord
            // 
            this.txtAddWord.Location = new System.Drawing.Point(101, 153);
            this.txtAddWord.Name = "txtAddWord";
            this.txtAddWord.Size = new System.Drawing.Size(603, 31);
            this.txtAddWord.TabIndex = 0;
            // 
            // txtAddDef
            // 
            this.txtAddDef.Location = new System.Drawing.Point(101, 252);
            this.txtAddDef.Name = "txtAddDef";
            this.txtAddDef.Size = new System.Drawing.Size(603, 31);
            this.txtAddDef.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAddWord
            // 
            this.lblAddWord.AutoSize = true;
            this.lblAddWord.Location = new System.Drawing.Point(365, 125);
            this.lblAddWord.Name = "lblAddWord";
            this.lblAddWord.Size = new System.Drawing.Size(56, 25);
            this.lblAddWord.TabIndex = 3;
            this.lblAddWord.Text = "Word";
            // 
            // lblAddDef
            // 
            this.lblAddDef.AutoSize = true;
            this.lblAddDef.Location = new System.Drawing.Point(352, 224);
            this.lblAddDef.Name = "lblAddDef";
            this.lblAddDef.Size = new System.Drawing.Size(89, 25);
            this.lblAddDef.TabIndex = 4;
            this.lblAddDef.Text = "Definition";
            // 
            // lblDefWarn
            // 
            this.lblDefWarn.AutoSize = true;
            this.lblDefWarn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDefWarn.Location = new System.Drawing.Point(101, 297);
            this.lblDefWarn.Name = "lblDefWarn";
            this.lblDefWarn.Size = new System.Drawing.Size(0, 25);
            this.lblDefWarn.TabIndex = 5;
            // 
            // lblWordWarn
            // 
            this.lblWordWarn.AutoSize = true;
            this.lblWordWarn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblWordWarn.Location = new System.Drawing.Point(101, 187);
            this.lblWordWarn.Name = "lblWordWarn";
            this.lblWordWarn.Size = new System.Drawing.Size(0, 25);
            this.lblWordWarn.TabIndex = 6;
            // 
            // lblWordAdded
            // 
            this.lblWordAdded.AutoSize = true;
            this.lblWordAdded.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblWordAdded.Location = new System.Drawing.Point(101, 344);
            this.lblWordAdded.Name = "lblWordAdded";
            this.lblWordAdded.Size = new System.Drawing.Size(0, 25);
            this.lblWordAdded.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblWordAdded);
            this.Controls.Add(this.lblWordWarn);
            this.Controls.Add(this.lblDefWarn);
            this.Controls.Add(this.lblAddDef);
            this.Controls.Add(this.lblAddWord);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAddDef);
            this.Controls.Add(this.txtAddWord);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddWord;
        private System.Windows.Forms.TextBox txtAddDef;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAddWord;
        private System.Windows.Forms.Label lblAddDef;
        private System.Windows.Forms.Label lblDefWarn;
        private System.Windows.Forms.Label lblWordWarn;
        private System.Windows.Forms.Label lblWordAdded;
    }
}