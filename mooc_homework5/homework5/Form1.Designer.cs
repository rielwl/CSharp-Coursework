
namespace homework5
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
            this.txtboxAngle1 = new System.Windows.Forms.TextBox();
            this.lblAngle1 = new System.Windows.Forms.Label();
            this.lblAngle2 = new System.Windows.Forms.Label();
            this.txtboxAngle2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLength1 = new System.Windows.Forms.Label();
            this.lblLength2 = new System.Windows.Forms.Label();
            this.txtboxLength1 = new System.Windows.Forms.TextBox();
            this.txtboxLength2 = new System.Windows.Forms.TextBox();
            this.btnLeavesColor = new System.Windows.Forms.Button();
            this.btnBranchesColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtboxAngle1
            // 
            this.txtboxAngle1.Location = new System.Drawing.Point(94, 12);
            this.txtboxAngle1.Name = "txtboxAngle1";
            this.txtboxAngle1.Size = new System.Drawing.Size(150, 31);
            this.txtboxAngle1.TabIndex = 0;
            this.txtboxAngle1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxAngle1_KeyPress);
            // 
            // lblAngle1
            // 
            this.lblAngle1.AutoSize = true;
            this.lblAngle1.Location = new System.Drawing.Point(12, 15);
            this.lblAngle1.Name = "lblAngle1";
            this.lblAngle1.Size = new System.Drawing.Size(60, 25);
            this.lblAngle1.TabIndex = 1;
            this.lblAngle1.Text = "角度1";
            // 
            // lblAngle2
            // 
            this.lblAngle2.AutoSize = true;
            this.lblAngle2.Location = new System.Drawing.Point(12, 52);
            this.lblAngle2.Name = "lblAngle2";
            this.lblAngle2.Size = new System.Drawing.Size(60, 25);
            this.lblAngle2.TabIndex = 2;
            this.lblAngle2.Text = "角度2";
            // 
            // txtboxAngle2
            // 
            this.txtboxAngle2.Location = new System.Drawing.Point(94, 49);
            this.txtboxAngle2.Name = "txtboxAngle2";
            this.txtboxAngle2.Size = new System.Drawing.Size(150, 31);
            this.txtboxAngle2.TabIndex = 3;
            this.txtboxAngle2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxAngle2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(597, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "注：只需输入时按enter就可以更改各种资料。 改完请click一下再生成树";
            // 
            // lblLength1
            // 
            this.lblLength1.AutoSize = true;
            this.lblLength1.Location = new System.Drawing.Point(287, 18);
            this.lblLength1.Name = "lblLength1";
            this.lblLength1.Size = new System.Drawing.Size(60, 25);
            this.lblLength1.TabIndex = 5;
            this.lblLength1.Text = "长度1";
            // 
            // lblLength2
            // 
            this.lblLength2.AutoSize = true;
            this.lblLength2.Location = new System.Drawing.Point(287, 52);
            this.lblLength2.Name = "lblLength2";
            this.lblLength2.Size = new System.Drawing.Size(60, 25);
            this.lblLength2.TabIndex = 6;
            this.lblLength2.Text = "长度2";
            // 
            // txtboxLength1
            // 
            this.txtboxLength1.Location = new System.Drawing.Point(375, 15);
            this.txtboxLength1.Name = "txtboxLength1";
            this.txtboxLength1.Size = new System.Drawing.Size(150, 31);
            this.txtboxLength1.TabIndex = 7;
            this.txtboxLength1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxLength1_KeyPress);
            // 
            // txtboxLength2
            // 
            this.txtboxLength2.Location = new System.Drawing.Point(375, 52);
            this.txtboxLength2.Name = "txtboxLength2";
            this.txtboxLength2.Size = new System.Drawing.Size(150, 31);
            this.txtboxLength2.TabIndex = 8;
            this.txtboxLength2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxLength2_KeyPress);
            // 
            // btnLeavesColor
            // 
            this.btnLeavesColor.Location = new System.Drawing.Point(565, 13);
            this.btnLeavesColor.Name = "btnLeavesColor";
            this.btnLeavesColor.Size = new System.Drawing.Size(112, 34);
            this.btnLeavesColor.TabIndex = 9;
            this.btnLeavesColor.Text = "树叶颜色";
            this.btnLeavesColor.UseVisualStyleBackColor = true;
            this.btnLeavesColor.Click += new System.EventHandler(this.btnLeavesColor_Click);
            // 
            // btnBranchesColor
            // 
            this.btnBranchesColor.Location = new System.Drawing.Point(565, 53);
            this.btnBranchesColor.Name = "btnBranchesColor";
            this.btnBranchesColor.Size = new System.Drawing.Size(112, 34);
            this.btnBranchesColor.TabIndex = 10;
            this.btnBranchesColor.Text = "树枝颜色";
            this.btnBranchesColor.UseVisualStyleBackColor = true;
            this.btnBranchesColor.Click += new System.EventHandler(this.btnBranchesColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBranchesColor);
            this.Controls.Add(this.btnLeavesColor);
            this.Controls.Add(this.txtboxLength2);
            this.Controls.Add(this.txtboxLength1);
            this.Controls.Add(this.lblLength2);
            this.Controls.Add(this.lblLength1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxAngle2);
            this.Controls.Add(this.lblAngle2);
            this.Controls.Add(this.lblAngle1);
            this.Controls.Add(this.txtboxAngle1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxAngle1;
        private System.Windows.Forms.Label lblAngle1;
        private System.Windows.Forms.Label lblAngle2;
        private System.Windows.Forms.TextBox txtboxAngle2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLength1;
        private System.Windows.Forms.Label lblLength2;
        private System.Windows.Forms.TextBox txtboxLength1;
        private System.Windows.Forms.TextBox txtboxLength2;
        private System.Windows.Forms.Button btnLeavesColor;
        private System.Windows.Forms.Button btnBranchesColor;
    }
}

