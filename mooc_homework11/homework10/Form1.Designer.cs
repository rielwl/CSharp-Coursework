
namespace homework10
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
            this.txtMaxCount = new System.Windows.Forms.TextBox();
            this.lblMaxCount = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCrawlFrom = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMaxCount
            // 
            this.txtMaxCount.Location = new System.Drawing.Point(86, 192);
            this.txtMaxCount.Name = "txtMaxCount";
            this.txtMaxCount.Size = new System.Drawing.Size(528, 31);
            this.txtMaxCount.TabIndex = 0;
            // 
            // lblMaxCount
            // 
            this.lblMaxCount.AutoSize = true;
            this.lblMaxCount.Location = new System.Drawing.Point(86, 154);
            this.lblMaxCount.Name = "lblMaxCount";
            this.lblMaxCount.Size = new System.Drawing.Size(202, 25);
            this.lblMaxCount.TabIndex = 1;
            this.lblMaxCount.Text = "想要下载几个页面呢？";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(86, 292);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(528, 31);
            this.txtUrl.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "想要从其他页面下载？请输入URL";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(502, 377);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(112, 34);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "访问：";
            // 
            // lblCrawlFrom
            // 
            this.lblCrawlFrom.AutoSize = true;
            this.lblCrawlFrom.Location = new System.Drawing.Point(86, 107);
            this.lblCrawlFrom.Name = "lblCrawlFrom";
            this.lblCrawlFrom.Size = new System.Drawing.Size(317, 25);
            this.lblCrawlFrom.TabIndex = 6;
            this.lblCrawlFrom.Text = "http://www.cnblogs.com/dstang2000/";
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(295, 442);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(112, 34);
            this.btnDownload.TabIndex = 7;
            this.btnDownload.Text = "下载";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(86, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "默认为 10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(738, 511);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblCrawlFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblMaxCount);
            this.Controls.Add(this.txtMaxCount);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMaxCount;
        private System.Windows.Forms.Label lblMaxCount;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCrawlFrom;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label label3;
    }
}

