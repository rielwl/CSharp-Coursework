
namespace homework2
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
            this.btnNext = new System.Windows.Forms.Button();
            this.lblDigit1 = new System.Windows.Forms.Label();
            this.lblOpr = new System.Windows.Forms.Label();
            this.lblDigit2 = new System.Windows.Forms.Label();
            this.lblEquals = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.lblCorr = new System.Windows.Forms.Label();
            this.lblIncorr = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSpd = new System.Windows.Forms.Button();
            this.txtSpd = new System.Windows.Forms.TextBox();
            this.lblMS = new System.Windows.Forms.Label();
            this.lblCurrSpd = new System.Windows.Forms.Label();
            this.lblCorrAns = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimerStart = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnScoringCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimerStop = new System.Windows.Forms.Button();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.btnSubmitSpd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(669, 405);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(99, 33);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "下一题";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblDigit1
            // 
            this.lblDigit1.AutoSize = true;
            this.lblDigit1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDigit1.Location = new System.Drawing.Point(19, 169);
            this.lblDigit1.Name = "lblDigit1";
            this.lblDigit1.Size = new System.Drawing.Size(79, 96);
            this.lblDigit1.TabIndex = 1;
            this.lblDigit1.Text = "0";
            // 
            // lblOpr
            // 
            this.lblOpr.AutoSize = true;
            this.lblOpr.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOpr.Location = new System.Drawing.Point(182, 169);
            this.lblOpr.Name = "lblOpr";
            this.lblOpr.Size = new System.Drawing.Size(89, 96);
            this.lblOpr.TabIndex = 2;
            this.lblOpr.Text = "+";
            // 
            // lblDigit2
            // 
            this.lblDigit2.AutoSize = true;
            this.lblDigit2.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDigit2.Location = new System.Drawing.Point(239, 172);
            this.lblDigit2.Name = "lblDigit2";
            this.lblDigit2.Size = new System.Drawing.Size(79, 96);
            this.lblDigit2.TabIndex = 3;
            this.lblDigit2.Text = "0";
            // 
            // lblEquals
            // 
            this.lblEquals.AutoSize = true;
            this.lblEquals.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEquals.Location = new System.Drawing.Point(416, 172);
            this.lblEquals.Name = "lblEquals";
            this.lblEquals.Size = new System.Drawing.Size(89, 96);
            this.lblEquals.TabIndex = 4;
            this.lblEquals.Text = "=";
            // 
            // txtAns
            // 
            this.txtAns.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAns.Location = new System.Drawing.Point(490, 169);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(150, 103);
            this.txtAns.TabIndex = 5;
            this.txtAns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAns_KeyPress);
            // 
            // lblCorr
            // 
            this.lblCorr.AutoSize = true;
            this.lblCorr.Location = new System.Drawing.Point(12, 9);
            this.lblCorr.Name = "lblCorr";
            this.lblCorr.Size = new System.Drawing.Size(93, 25);
            this.lblCorr.TabIndex = 6;
            this.lblCorr.Text = "Correct:  0";
            // 
            // lblIncorr
            // 
            this.lblIncorr.AutoSize = true;
            this.lblIncorr.Location = new System.Drawing.Point(12, 43);
            this.lblIncorr.Name = "lblIncorr";
            this.lblIncorr.Size = new System.Drawing.Size(100, 25);
            this.lblIncorr.TabIndex = 7;
            this.lblIncorr.Text = "Incorrect: 0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(13, 90);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(99, 33);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSpd
            // 
            this.btnSpd.Location = new System.Drawing.Point(19, 365);
            this.btnSpd.Name = "btnSpd";
            this.btnSpd.Size = new System.Drawing.Size(99, 33);
            this.btnSpd.TabIndex = 9;
            this.btnSpd.Text = "改速度";
            this.btnSpd.UseVisualStyleBackColor = true;
            this.btnSpd.Click += new System.EventHandler(this.btnSpd_Click);
            // 
            // txtSpd
            // 
            this.txtSpd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpd.Location = new System.Drawing.Point(124, 365);
            this.txtSpd.Name = "txtSpd";
            this.txtSpd.Size = new System.Drawing.Size(147, 31);
            this.txtSpd.TabIndex = 10;
            this.txtSpd.Visible = false;
            // 
            // lblMS
            // 
            this.lblMS.AutoSize = true;
            this.lblMS.Location = new System.Drawing.Point(124, 337);
            this.lblMS.Name = "lblMS";
            this.lblMS.Size = new System.Drawing.Size(0, 25);
            this.lblMS.TabIndex = 11;
            // 
            // lblCurrSpd
            // 
            this.lblCurrSpd.AutoSize = true;
            this.lblCurrSpd.Location = new System.Drawing.Point(277, 369);
            this.lblCurrSpd.Name = "lblCurrSpd";
            this.lblCurrSpd.Size = new System.Drawing.Size(0, 25);
            this.lblCurrSpd.TabIndex = 12;
            // 
            // lblCorrAns
            // 
            this.lblCorrAns.AutoSize = true;
            this.lblCorrAns.Location = new System.Drawing.Point(124, 353);
            this.lblCorrAns.Name = "lblCorrAns";
            this.lblCorrAns.Size = new System.Drawing.Size(0, 25);
            this.lblCorrAns.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "注意：除法时，答案只需写商数，不需写余数";
            // 
            // btnTimerStart
            // 
            this.btnTimerStart.Location = new System.Drawing.Point(669, 169);
            this.btnTimerStart.Name = "btnTimerStart";
            this.btnTimerStart.Size = new System.Drawing.Size(98, 33);
            this.btnTimerStart.TabIndex = 15;
            this.btnTimerStart.Text = "计时开始";
            this.btnTimerStart.UseVisualStyleBackColor = true;
            this.btnTimerStart.Click += new System.EventHandler(this.btnTimerStart_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(574, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(75, 25);
            this.lblScore.TabIndex = 16;
            this.lblScore.Text = "Score: 0";
            // 
            // btnScoringCalc
            // 
            this.btnScoringCalc.Location = new System.Drawing.Point(19, 410);
            this.btnScoringCalc.Name = "btnScoringCalc";
            this.btnScoringCalc.Size = new System.Drawing.Size(144, 34);
            this.btnScoringCalc.TabIndex = 17;
            this.btnScoringCalc.Text = "如何计算分数";
            this.btnScoringCalc.UseVisualStyleBackColor = true;
            this.btnScoringCalc.Click += new System.EventHandler(this.btnScoringCalc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "想要显示下一题可以直接用Enter key";
            // 
            // btnTimerStop
            // 
            this.btnTimerStop.Location = new System.Drawing.Point(669, 229);
            this.btnTimerStop.Name = "btnTimerStop";
            this.btnTimerStop.Size = new System.Drawing.Size(98, 33);
            this.btnTimerStop.TabIndex = 19;
            this.btnTimerStop.Text = "结束计时";
            this.btnTimerStop.UseVisualStyleBackColor = true;
            this.btnTimerStop.Click += new System.EventHandler(this.btnTimerStop_Click);
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Location = new System.Drawing.Point(574, 43);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(118, 25);
            this.lblHighScore.TabIndex = 21;
            this.lblHighScore.Text = "High Score: 0";
            // 
            // btnSubmitSpd
            // 
            this.btnSubmitSpd.Location = new System.Drawing.Point(279, 410);
            this.btnSubmitSpd.Name = "btnSubmitSpd";
            this.btnSubmitSpd.Size = new System.Drawing.Size(148, 33);
            this.btnSubmitSpd.TabIndex = 22;
            this.btnSubmitSpd.Text = "提交速度";
            this.btnSubmitSpd.UseVisualStyleBackColor = true;
            this.btnSubmitSpd.Visible = false;
            this.btnSubmitSpd.Click += new System.EventHandler(this.btnSubmitSpd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmitSpd);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.btnTimerStop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnScoringCalc);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnTimerStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCorrAns);
            this.Controls.Add(this.lblCurrSpd);
            this.Controls.Add(this.lblMS);
            this.Controls.Add(this.txtSpd);
            this.Controls.Add(this.btnSpd);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblIncorr);
            this.Controls.Add(this.lblCorr);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.lblEquals);
            this.Controls.Add(this.lblDigit2);
            this.Controls.Add(this.lblOpr);
            this.Controls.Add(this.lblDigit1);
            this.Controls.Add(this.btnNext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblDigit1;
        private System.Windows.Forms.Label lblOpr;
        private System.Windows.Forms.Label lblDigit2;
        private System.Windows.Forms.Label lblEquals;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Label lblCorr;
        private System.Windows.Forms.Label lblIncorr;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSpd;
        private System.Windows.Forms.TextBox txtSpd;
        private System.Windows.Forms.Label lblMS;
        private System.Windows.Forms.Label lblCurrSpd;
        private System.Windows.Forms.Label lblCorrAns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimerStart;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnScoringCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimerStop;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Button btnSubmitSpd;
    }
}

