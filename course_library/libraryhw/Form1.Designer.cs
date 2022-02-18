
namespace libraryhw
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
            this.txtLoginUsername = new System.Windows.Forms.TextBox();
            this.txtLoginPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.radioNormalUser = new System.Windows.Forms.RadioButton();
            this.radioHighLeveluser = new System.Windows.Forms.RadioButton();
            this.grpAccntType = new System.Windows.Forms.GroupBox();
            this.btnNewAccnt = new System.Windows.Forms.Button();
            this.btnSwitchToCreate = new System.Windows.Forms.Button();
            this.grpAccntType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLoginUsername
            // 
            this.txtLoginUsername.Location = new System.Drawing.Point(288, 205);
            this.txtLoginUsername.Name = "txtLoginUsername";
            this.txtLoginUsername.Size = new System.Drawing.Size(218, 31);
            this.txtLoginUsername.TabIndex = 0;
            // 
            // txtLoginPassword
            // 
            this.txtLoginPassword.Location = new System.Drawing.Point(288, 286);
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.Size = new System.Drawing.Size(218, 31);
            this.txtLoginPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(288, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(334, 352);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // radioNormalUser
            // 
            this.radioNormalUser.AutoSize = true;
            this.radioNormalUser.Checked = true;
            this.radioNormalUser.Location = new System.Drawing.Point(31, 30);
            this.radioNormalUser.Name = "radioNormalUser";
            this.radioNormalUser.Size = new System.Drawing.Size(136, 29);
            this.radioNormalUser.TabIndex = 5;
            this.radioNormalUser.TabStop = true;
            this.radioNormalUser.Text = "Normal User";
            this.radioNormalUser.UseVisualStyleBackColor = true;
            // 
            // radioHighLeveluser
            // 
            this.radioHighLeveluser.AutoSize = true;
            this.radioHighLeveluser.Location = new System.Drawing.Point(31, 65);
            this.radioHighLeveluser.Name = "radioHighLeveluser";
            this.radioHighLeveluser.Size = new System.Drawing.Size(159, 29);
            this.radioHighLeveluser.TabIndex = 6;
            this.radioHighLeveluser.Text = "High Level User";
            this.radioHighLeveluser.UseVisualStyleBackColor = true;
            // 
            // grpAccntType
            // 
            this.grpAccntType.Controls.Add(this.radioNormalUser);
            this.grpAccntType.Controls.Add(this.radioHighLeveluser);
            this.grpAccntType.Location = new System.Drawing.Point(569, 34);
            this.grpAccntType.Name = "grpAccntType";
            this.grpAccntType.Size = new System.Drawing.Size(219, 121);
            this.grpAccntType.TabIndex = 7;
            this.grpAccntType.TabStop = false;
            this.grpAccntType.Text = "Account Type";
            // 
            // btnNewAccnt
            // 
            this.btnNewAccnt.Location = new System.Drawing.Point(315, 352);
            this.btnNewAccnt.Name = "btnNewAccnt";
            this.btnNewAccnt.Size = new System.Drawing.Size(144, 34);
            this.btnNewAccnt.TabIndex = 8;
            this.btnNewAccnt.Text = "Create Account";
            this.btnNewAccnt.UseVisualStyleBackColor = true;
            this.btnNewAccnt.Visible = false;
            this.btnNewAccnt.Click += new System.EventHandler(this.btnNewAccnt_Click);
            // 
            // btnSwitchToCreate
            // 
            this.btnSwitchToCreate.BackColor = System.Drawing.SystemColors.Control;
            this.btnSwitchToCreate.Location = new System.Drawing.Point(589, 404);
            this.btnSwitchToCreate.Name = "btnSwitchToCreate";
            this.btnSwitchToCreate.Size = new System.Drawing.Size(199, 34);
            this.btnSwitchToCreate.TabIndex = 9;
            this.btnSwitchToCreate.Text = "Create New Account";
            this.btnSwitchToCreate.UseVisualStyleBackColor = false;
            this.btnSwitchToCreate.Click += new System.EventHandler(this.btnSwitchToCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSwitchToCreate);
            this.Controls.Add(this.btnNewAccnt);
            this.Controls.Add(this.grpAccntType);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoginPassword);
            this.Controls.Add(this.txtLoginUsername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAccntType.ResumeLayout(false);
            this.grpAccntType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoginUsername;
        private System.Windows.Forms.TextBox txtLoginPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.RadioButton radioNormalUser;
        private System.Windows.Forms.RadioButton radioHighLeveluser;
        private System.Windows.Forms.GroupBox grpAccntType;
        private System.Windows.Forms.Button btnNewAccnt;
        private System.Windows.Forms.Button btnSwitchToCreate;
    }
}

