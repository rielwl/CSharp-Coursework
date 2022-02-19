using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace homework1
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            this.Text = "Add Words!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblDefWarn.Text = "";
            lblWordWarn.Text = "";
            lblWordAdded.Text = "";
            if (txtAddWord.Text.Length == 0)
            {
                lblWordWarn.Text = "Please type in the word";
                if(txtAddDef.Text.Length == 0)
                {
                    lblDefWarn.Text = "Please type in the definition";
                }
            }
            else if (txtAddDef.Text.Length == 0)
            {
                lblDefWarn.Text = "Please type in the definition";
            }
            else
            {
                string addedWord = txtAddWord.Text.ToLower();
                string addedDef = txtAddDef.Text;
                Form1.instance.wordsList.Add(addedWord);
                Form1.instance.defList.Add(addedDef);
                lblWordAdded.Text = "Word added successfully!";
            }
        }
    }
}
