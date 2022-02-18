
namespace hw1dice
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
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblDiceOne = new System.Windows.Forms.Label();
            this.lblDiceTwo = new System.Windows.Forms.Label();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lblVal2 = new System.Windows.Forms.Label();
            this.lblVal6 = new System.Windows.Forms.Label();
            this.lblVal7 = new System.Windows.Forms.Label();
            this.lblVal5 = new System.Windows.Forms.Label();
            this.lblVal3 = new System.Windows.Forms.Label();
            this.lblVal4 = new System.Windows.Forms.Label();
            this.lblVal11 = new System.Windows.Forms.Label();
            this.lblVal12 = new System.Windows.Forms.Label();
            this.lblVal10 = new System.Windows.Forms.Label();
            this.lblVal8 = new System.Windows.Forms.Label();
            this.lblVal9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(339, 256);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(112, 34);
            this.btnRandom.TabIndex = 0;
            this.btnRandom.Text = "Randomize!";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 34);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblDiceOne
            // 
            this.lblDiceOne.AutoSize = true;
            this.lblDiceOne.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiceOne.Location = new System.Drawing.Point(253, 134);
            this.lblDiceOne.Name = "lblDiceOne";
            this.lblDiceOne.Size = new System.Drawing.Size(81, 96);
            this.lblDiceOne.TabIndex = 2;
            this.lblDiceOne.Text = "0";
            // 
            // lblDiceTwo
            // 
            this.lblDiceTwo.AutoSize = true;
            this.lblDiceTwo.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiceTwo.Location = new System.Drawing.Point(452, 134);
            this.lblDiceTwo.Name = "lblDiceTwo";
            this.lblDiceTwo.Size = new System.Drawing.Size(81, 96);
            this.lblDiceTwo.TabIndex = 3;
            this.lblDiceTwo.Text = "0";
            // 
            // tableLayout
            // 
            this.tableLayout.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayout.ColumnCount = 11;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayout.Controls.Add(this.lblVal2, 0, 1);
            this.tableLayout.Controls.Add(this.lblVal6, 0, 1);
            this.tableLayout.Controls.Add(this.lblVal7, 0, 1);
            this.tableLayout.Controls.Add(this.lblVal5, 0, 1);
            this.tableLayout.Controls.Add(this.lblVal3, 0, 1);
            this.tableLayout.Controls.Add(this.lblVal4, 0, 1);
            this.tableLayout.Controls.Add(this.lblVal11, 0, 1);
            this.tableLayout.Controls.Add(this.lblVal12, 0, 1);
            this.tableLayout.Controls.Add(this.lblVal10, 0, 1);
            this.tableLayout.Controls.Add(this.lblVal8, 0, 1);
            this.tableLayout.Controls.Add(this.lblVal9, 0, 1);
            this.tableLayout.Controls.Add(this.label3, 1, 0);
            this.tableLayout.Controls.Add(this.label2, 0, 0);
            this.tableLayout.Controls.Add(this.label4, 2, 0);
            this.tableLayout.Controls.Add(this.label5, 3, 0);
            this.tableLayout.Controls.Add(this.label6, 4, 0);
            this.tableLayout.Controls.Add(this.label7, 5, 0);
            this.tableLayout.Controls.Add(this.label8, 6, 0);
            this.tableLayout.Controls.Add(this.label9, 7, 0);
            this.tableLayout.Controls.Add(this.label10, 8, 0);
            this.tableLayout.Controls.Add(this.label11, 9, 0);
            this.tableLayout.Controls.Add(this.label12, 10, 0);
            this.tableLayout.Location = new System.Drawing.Point(37, 339);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayout.Size = new System.Drawing.Size(729, 89);
            this.tableLayout.TabIndex = 4;
            // 
            // lblVal2
            // 
            this.lblVal2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVal2.AutoSize = true;
            this.lblVal2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVal2.Location = new System.Drawing.Point(22, 60);
            this.lblVal2.Name = "lblVal2";
            this.lblVal2.Size = new System.Drawing.Size(23, 28);
            this.lblVal2.TabIndex = 25;
            this.lblVal2.Text = "0";
            // 
            // lblVal6
            // 
            this.lblVal6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVal6.AutoSize = true;
            this.lblVal6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVal6.Location = new System.Drawing.Point(286, 60);
            this.lblVal6.Name = "lblVal6";
            this.lblVal6.Size = new System.Drawing.Size(23, 28);
            this.lblVal6.TabIndex = 24;
            this.lblVal6.Text = "0";
            // 
            // lblVal7
            // 
            this.lblVal7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVal7.AutoSize = true;
            this.lblVal7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVal7.Location = new System.Drawing.Point(352, 60);
            this.lblVal7.Name = "lblVal7";
            this.lblVal7.Size = new System.Drawing.Size(23, 28);
            this.lblVal7.TabIndex = 23;
            this.lblVal7.Text = "0";
            // 
            // lblVal5
            // 
            this.lblVal5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVal5.AutoSize = true;
            this.lblVal5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVal5.Location = new System.Drawing.Point(220, 60);
            this.lblVal5.Name = "lblVal5";
            this.lblVal5.Size = new System.Drawing.Size(23, 28);
            this.lblVal5.TabIndex = 22;
            this.lblVal5.Text = "0";
            // 
            // lblVal3
            // 
            this.lblVal3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVal3.AutoSize = true;
            this.lblVal3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVal3.Location = new System.Drawing.Point(88, 60);
            this.lblVal3.Name = "lblVal3";
            this.lblVal3.Size = new System.Drawing.Size(23, 28);
            this.lblVal3.TabIndex = 21;
            this.lblVal3.Text = "0";
            // 
            // lblVal4
            // 
            this.lblVal4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVal4.AutoSize = true;
            this.lblVal4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVal4.Location = new System.Drawing.Point(154, 60);
            this.lblVal4.Name = "lblVal4";
            this.lblVal4.Size = new System.Drawing.Size(23, 28);
            this.lblVal4.TabIndex = 20;
            this.lblVal4.Text = "0";
            // 
            // lblVal11
            // 
            this.lblVal11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVal11.AutoSize = true;
            this.lblVal11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVal11.Location = new System.Drawing.Point(616, 60);
            this.lblVal11.Name = "lblVal11";
            this.lblVal11.Size = new System.Drawing.Size(23, 28);
            this.lblVal11.TabIndex = 19;
            this.lblVal11.Text = "0";
            // 
            // lblVal12
            // 
            this.lblVal12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVal12.AutoSize = true;
            this.lblVal12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVal12.Location = new System.Drawing.Point(683, 60);
            this.lblVal12.Name = "lblVal12";
            this.lblVal12.Size = new System.Drawing.Size(23, 28);
            this.lblVal12.TabIndex = 18;
            this.lblVal12.Text = "0";
            // 
            // lblVal10
            // 
            this.lblVal10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVal10.AutoSize = true;
            this.lblVal10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVal10.Location = new System.Drawing.Point(550, 60);
            this.lblVal10.Name = "lblVal10";
            this.lblVal10.Size = new System.Drawing.Size(23, 28);
            this.lblVal10.TabIndex = 17;
            this.lblVal10.Text = "0";
            // 
            // lblVal8
            // 
            this.lblVal8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVal8.AutoSize = true;
            this.lblVal8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVal8.Location = new System.Drawing.Point(418, 60);
            this.lblVal8.Name = "lblVal8";
            this.lblVal8.Size = new System.Drawing.Size(23, 28);
            this.lblVal8.TabIndex = 16;
            this.lblVal8.Text = "0";
            // 
            // lblVal9
            // 
            this.lblVal9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVal9.AutoSize = true;
            this.lblVal9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVal9.Location = new System.Drawing.Point(484, 60);
            this.lblVal9.Name = "lblVal9";
            this.lblVal9.Size = new System.Drawing.Size(23, 28);
            this.lblVal9.TabIndex = 15;
            this.lblVal9.Text = "0";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(87, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "3";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "2";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(153, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(219, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "5";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(285, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "6";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(351, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "7";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(417, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 28);
            this.label8.TabIndex = 10;
            this.label8.Text = "8";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(483, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 28);
            this.label9.TabIndex = 11;
            this.label9.Text = "9";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(543, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 28);
            this.label10.TabIndex = 12;
            this.label10.Text = "10";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(609, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 28);
            this.label11.TabIndex = 13;
            this.label11.Text = "11";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(676, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 28);
            this.label12.TabIndex = 14;
            this.label12.Text = "12";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayout);
            this.Controls.Add(this.lblDiceTwo);
            this.Controls.Add(this.lblDiceOne);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnRandom);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblDiceOne;
        private System.Windows.Forms.Label lblDiceTwo;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblVal2;
        private System.Windows.Forms.Label lblVal6;
        private System.Windows.Forms.Label lblVal7;
        private System.Windows.Forms.Label lblVal5;
        private System.Windows.Forms.Label lblVal3;
        private System.Windows.Forms.Label lblVal4;
        private System.Windows.Forms.Label lblVal11;
        private System.Windows.Forms.Label lblVal12;
        private System.Windows.Forms.Label lblVal10;
        private System.Windows.Forms.Label lblVal8;
        private System.Windows.Forms.Label lblVal9;
    }
}