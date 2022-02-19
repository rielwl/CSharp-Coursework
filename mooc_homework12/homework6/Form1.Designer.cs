
namespace homework6
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
            this.components = new System.ComponentModel.Container();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblMeaning = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSpeedChange = new System.Windows.Forms.Button();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.btnProgress = new System.Windows.Forms.Button();
            this.btnPauseStart = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.BackColor = System.Drawing.Color.White;
            this.lblWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWord.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblWord.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWord.Location = new System.Drawing.Point(156, 111);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(480, 111);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "label1";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMeaning
            // 
            this.lblMeaning.BackColor = System.Drawing.Color.White;
            this.lblMeaning.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMeaning.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblMeaning.Font = new System.Drawing.Font("SimHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMeaning.Location = new System.Drawing.Point(156, 239);
            this.lblMeaning.Name = "lblMeaning";
            this.lblMeaning.Size = new System.Drawing.Size(480, 111);
            this.lblMeaning.TabIndex = 1;
            this.lblMeaning.Text = "label2";
            this.lblMeaning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSpeedChange
            // 
            this.btnSpeedChange.Location = new System.Drawing.Point(12, 51);
            this.btnSpeedChange.Name = "btnSpeedChange";
            this.btnSpeedChange.Size = new System.Drawing.Size(154, 34);
            this.btnSpeedChange.TabIndex = 2;
            this.btnSpeedChange.Text = "改速度";
            this.btnSpeedChange.UseVisualStyleBackColor = true;
            this.btnSpeedChange.Click += new System.EventHandler(this.btnSpeedChange_Click);
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(172, 51);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(150, 31);
            this.txtSpeed.TabIndex = 3;
            this.txtSpeed.Visible = false;
            // 
            // btnProgress
            // 
            this.btnProgress.Location = new System.Drawing.Point(12, 11);
            this.btnProgress.Name = "btnProgress";
            this.btnProgress.Size = new System.Drawing.Size(154, 34);
            this.btnProgress.TabIndex = 4;
            this.btnProgress.Text = "取出上次的进度";
            this.btnProgress.UseVisualStyleBackColor = true;
            this.btnProgress.Click += new System.EventHandler(this.btnProgress_Click);
            // 
            // btnPauseStart
            // 
            this.btnPauseStart.Location = new System.Drawing.Point(343, 384);
            this.btnPauseStart.Name = "btnPauseStart";
            this.btnPauseStart.Size = new System.Drawing.Size(112, 34);
            this.btnPauseStart.TabIndex = 5;
            this.btnPauseStart.Text = "开始";
            this.btnPauseStart.UseVisualStyleBackColor = true;
            this.btnPauseStart.Click += new System.EventHandler(this.btnPauseStart_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(328, 48);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(112, 34);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Visible = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "可以用Left和Right来换被显示的字";
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(676, 12);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(112, 34);
            this.btnViewAll.TabIndex = 8;
            this.btnViewAll.Text = "看全部";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnPauseStart);
            this.Controls.Add(this.btnProgress);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.btnSpeedChange);
            this.Controls.Add(this.lblMeaning);
            this.Controls.Add(this.lblWord);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblMeaning;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSpeedChange;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.Button btnProgress;
        private System.Windows.Forms.Button btnPauseStart;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewAll;
    }
}

